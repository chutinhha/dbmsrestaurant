
use [QLNhaHang]
go
create type TableType_ChiTietDatHang as table
(MaHoaDon int ,MaNL int ,SoLuong int,ThanhTien float);
go
--------------- table ChiTietDatHang --------------------------------------------------------------------

-- Select chi tiết đặt hàng theo Mã Hóa Đơn
---------------------------------------------------------------
create proc SelectChiTietDatHang @MaHoaDon int
as
begin
	begin tran
	set transaction isolation level read uncommitted
		select ct.*,nl.TenNL,nl.DonVi
		from ChiTietDatHang ct,NguyenLieu nl
		where MaHoaDon = @MaHoaDon and ct.MaNL = nl.MaNL
	commit tran
end
GO

-- Delete chi tiết đặt hàng theo Mã Hóa Đơn
-----------------------------------------------------------------
create proc DeleteChiTietDatHang  @MaHoaDon int
as
begin
	begin tran
	set transaction isolation level read uncommitted
		delete ChiTietDatHang
		where MaHoaDon=@MaHoaDon
	commit tran
end
GO


--GO
--------------- table DatHang -------------------------------------------------------------------------

-- Slect đơn đặt hàng theo Mã Nhà Hàng
----------------------------------------------------------------
create proc SelectDatHang  @MaNH nchar(10)
as
begin
	begin tran
	set transaction isolation level read uncommitted
		select dh.*,ncc.TenNCC from DatHang dh,NhaCungCap ncc 
		where MaNH = @MaNH and dh.MaNCC = ncc.MaNCC
	commit tran
end

GO
alter proc InsertDatHang  
	@MaHoaDon int out,
	@MaNCC int,
	@MaNH nchar(10),
	@TongTien float,
	@ThoiGianDat datetime,
	@ThoiGianGiao datetime,
	@TinhTrang nvarchar(50),
	@ChiTiet TableType_ChiTietDatHang readonly
as
begin
	set @MaHoaDon = -1
    begin tran
    set transaction isolation level read uncommitted
        --Insert Nha Cung Cap
        insert into DatHang
        values(@MaNCC,@MaNH,@TongTien,@ThoiGianDat,@ThoiGianGiao,@TinhTrang)
        	
        set @MaHoaDon = (select scope_identity())
        --waitfor delay '00:00:05'
        
        if (@@ERROR<>0)
        begin
            set @MaHoaDon = -1
            rollback
            return
        end
        
        --Insert Chi Tiet NCC
        insert into ChiTietDatHang
        select MaHoaDon = @MaHoaDon
              ,MaNL
              ,SoLuong
              ,ThanhTien
        from   @ChiTiet
        
        if (@@ERROR<>0)
        begin
            set @MaHoaDon= -1
            rollback
            return
        end
    commit tran
end
GO
alter proc UpdateDatHang 
	@Flag int out,
	@MaHoaDon int,
	@MaNCC int,
	@MaNH nchar(10),
	@TongTien float,
	@ThoiGianDat datetime,
	@ThoiGianGiao datetime,
	@TinhTrang nvarchar(50),
	@ChiTiet TableType_ChiTietDatHang readonly
as
begin 
	set @Flag = 0
    begin tran
    set transaction isolation level read uncommitted
    
    if(( select count(*) from  DatHang where  MaHoaDon = @MaHoaDon )<>0)
    begin
    	--waitfor delay '00:00:06'
        update DatHang
        set    MaNCC         = @MaNCC
              ,MaNH          = @MaNH
              ,TongTien      = @TongTien
              ,ThoiGianDat   = @ThoiGianDat
              ,ThoiGianGiao  = @ThoiGianGiao
              ,TinhTrang     = @TinhTrang
        where  MaHoaDon      = @MaHoaDon
        -- waitfor delay '00:00:04'
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end
        
        --Xoa nguyen lieu da bi mat trong danh sach
        delete ChiTietDatHang
        where  MaHoaDon = @MaHoaDon
               and MaNL in (
                       select ct.MaNL
                       from   ChiTietDatHang ct
                       where  ct.MaHoaDon = @MaHoaDon
                              and ct.MaNL not in (select MaNL
                                                   from   @ChiTiet))
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end      
        --cap nhat so luong va thanh tien cho nguyen lieu
        --dong thoi them nguyen lieu vua cap nhat trong don dat hang
        declare @manl int,@soluong int,@thanhtien int
		declare @cur cursor 
		set @cur = cursor for select MaNL,SoLuong,ThanhTien from @ChiTiet
		open @cur
		fetch next from @cur into @manl,@soluong,@thanhtien
		while @@FETCH_STATUS=0
		begin
			if(exists(select * from ChiTietDatHang 
					  where MaHoaDon = @MaHoaDon and MaNL = @manl))
			begin
				update ChiTietDatHang set 
				SoLuong = @soluong,ThanhTien = @thanhtien 
				where MaNL = @manl and MaHoaDon = @MaHoaDon
			end
			else
				insert into ChiTietDatHang values(@MaHoaDon,@manl,@soluong,@thanhtien) 
				
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end               
			fetch next from @cur into @manl,@soluong,@thanhtien
		end
                                      
        --Them cac nguyen lieu moi cap nhat
        --insert into ChiTietDatHang
        --select ct.MaHoaDon
        --      ,ct.MaNL
        --      ,ct.SoLuong
        --      ,ct.ThanhTien
        --from   @ChiTiet ct
        --where  ct.MaNL not in (select ctdh.MaNL
        --                    from   ChiTietDatHang ctdh
        --                    where  ctdh.MaHoaDon = @MaHoaDon)
                            
        --if(@@ERROR<>0)
        --begin
        --    set @Flag = 0
        --    rollback
        --    return
        --end                      
    end
    set @Flag = 1
    commit tran
end
go
create proc UpdateTinhTrangDatHang
	@MaHoaDon int,
	@TinhTrang nvarchar(50)
as
begin
	begin tran
	set transaction isolation level read uncommitted
		update DatHang set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
	commit tran 
end
	
GO
alter proc DeleteDatHang 
	@Flag int out,
	@MaHoaDon int
as
begin	
	set @Flag = 0
	begin tran
	set transaction isolation level read uncommitted
		exec DeleteChiTietDatHang @MaHoaDon
		if(@@ERROR<>0)
        begin
            rollback
            return
        end 
        
		delete DatHang
		where MaHoaDon=@MaHoaDon
		
		if(@@ERROR<>0)
        begin
            rollback
            return
        end 
    set @Flag = 1  
	commit tran
end
GO
