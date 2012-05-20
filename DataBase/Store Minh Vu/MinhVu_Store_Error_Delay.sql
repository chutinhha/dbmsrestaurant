
use [QLNhaHang]
go
--- Them nguyen lieu moi
------------------------------------------------------------------------------------- 
create proc SPoV_Delay_InsertNguyenLieu
	@Flag int out,
	@MaNH nchar(10),
	@TenNL nvarchar(50),
	@DonVi nvarchar(20),
	@SoLuongTon int
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    insert into NguyenLieu
    values
      (
        @MaNH
       ,@TenNL
       ,@DonVi
       ,@SoLuongTon
      )
    waitfor delay '00:00:05'		
    if ((select count(*)
         from   NguyenLieu
         where  TenNL = @TenNL
				and DonVi = @DonVi
                and MaNH = @MaNH)<>1)
    begin
        rollback tran
        return
    end
    
    if (@@error<>0)
    begin
        rollback tran
        return
    end
    
    set @Flag = 1
    commit
end
go
--- lay danh sach nguyen lieu cua nha cung cap
--- va danh sanh nguyen lieu nha cung cap khong co
-------------------------------------------------------------------------------------
create proc SPoV_Delay_SelectNguyenLieu_NCC 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted  
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

create proc SPoV_Delay_UpdateTinhTrangDatHang
	@Flag int out,
	@MaHoaDon int,
	@TinhTrang nvarchar(50)
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	read uncommitted
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
		        from   ChiTietDatHang ctdh
		        where ctdh.MaHoaDon = @MaHoaDon
		               and MaNL = @MaNL)
			set @soluongton =
				 (select SoLuongTon
                  from   NguyenLieu
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
	