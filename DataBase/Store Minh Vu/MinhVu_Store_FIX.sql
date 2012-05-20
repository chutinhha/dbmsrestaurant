
use [QLNhaHang]
go
------------------- Table Nguyen Lieu -----------------------------------------------------------------
--- Lay danh sach nguyen lieu
------------------------------------------------------------------------------------- 
create proc SPoV_FIX_SelectNguyenLieu 
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read committed
    select *
    from   NguyenLieu nl
    where  nl.MaNH = @MaNH
    order by
           nl.TenNL
    
    commit tran
end
go

--- lay danh sach nguyen lieu cua nha cung cap
--- va danh sanh nguyen lieu nha cung cap khong co
-------------------------------------------------------------------------------------
create proc SPoV_FIX_SelectNguyenLieu_NCC 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    serializable
    exec SPoV_SelectNguyenLieu_In_NCC 
		@MaNCC
        ,@MaNH
    waitfor delay '00:00:05'
    exec SPoV_SelectNguyenLieu_NotIn_NCC 
		@MaNCC
		,@MaNH
    commit tran
end
go
alter proc SPoV_FIX_UpdateTinhTrangDatHang
	@Flag int out,
	@MaHoaDon int,
	@TinhTrang nvarchar(50)
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	repeatable read
	if(@TinhTrang <> N'Đã Giao')
	begin
	    update DatHang 
	    set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
			
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end         
	end
	else
	begin
		update DatHang 
		set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end  			
		--Cap nhat so luong nguyen lieu ton
		declare @soluongton int,
				@soluongthem int,
				@MaNL int
		declare @cur cursor
		set @cur =  cursor for 
		select MaNL
		from   ChiTietDatHang ctdh
		where  ctdh.MaHoaDon = @MaHoaDon
		
		open @cur 
		fetch next from @cur into @MaNL
		while @@FETCH_STATUS = 0
		begin
			set @soluongthem = (
		        select ctdh.SoLuong
		        from   ChiTietDatHang ctdh with(updlock)
		        where ctdh.MaHoaDon = @MaHoaDon
		               and MaNL = @MaNL)
			set @soluongton =
				 (select SoLuongTon 
                  from   NguyenLieu with(updlock)
                  where  MaNL = @MaNL)
			waitfor delay '00:00:06'                  
			update NguyenLieu
			set	SoLuongTon=@soluongthem+@soluongton
			where MaNL = @MaNL
			
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end  
			fetch next from @cur into @MaNL
		end
	end
	set @Flag = 1	
	commit tran 
end