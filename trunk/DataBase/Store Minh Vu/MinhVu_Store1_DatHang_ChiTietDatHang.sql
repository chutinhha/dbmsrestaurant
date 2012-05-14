
use [QLNhaHang]
GO
--------------- table ChiTietDatHang --------------------------------------------------------------------

-- Select chi tiết đặt hàng theo Mã Hóa Đơn
---------------------------------------------------------------
create proc SelectChiTietDatHang @MaHoaDon int
as
begin
	select ct.*,nl.TenNL,nl.DonVi
	from ChiTietDatHang ct,NguyenLieu nl
	where MaHoaDon = @MaHoaDon and ct.MaNL = nl.MaNL
end
GO

-- Kiểm tra một nguyên liệu có trong bảng chi tiết đặt hàng hay không
----------------------------------------------------------------

create proc CountChiTietDatHang_fromMaNL @MaNL int
as
begin
	return (select count(*)
	from NguyenLieu nl
	where nl.MaNL = @MaNL)
end
GO
-- insert chi tiết đặt hàng 
----------------------------------------------------------------
create proc InsertChiTietDatHang @MaHoaDon int,@MaNL int,@SoLuong int,@ThanhTien float
as
begin
	begin tran
	set transaction isolation level read uncommitted
	insert into ChiTietDatHang values(@MaHoaDon,@MaNL,@SoLuong,@ThanhTien)
	commit
end
GO

-- Delete chi tiết đặt hàng theo Mã Hóa Đơn
-----------------------------------------------------------------
create proc DeleteChiTietDatHang  @MaHoaDon int
as
begin
	delete ChiTietDatHang
	where MaHoaDon=@MaHoaDon
end
GO

-- Delete chi tiết đặt hàng theo Mã Nguyên Liệu
----------------------------------------------------------------
create proc DeleteChiTietDatHang_fromNL  @MaNL int
as
begin
	delete ChiTietDatHang
	where MaNL = @MaNL
end

GO
--------------- table DatHang -------------------------------------------------------------------------

-- Slect đơn đặt hàng theo Mã Nhà Hàng
----------------------------------------------------------------
create proc SelectDatHang  @MaNH nchar(10)
as
begin
	select dh.*,ncc.TenNCC from DatHang dh,NhaCungCap ncc 
	where MaNH = @MaNH and dh.MaNCC = ncc.MaNCC
end

GO
create proc InsertDatHang  @MaHoaDon int out, @MaNCC int,@MaNH nchar(10),@TongTien float,@ThoiGianDat datetime,@ThoiGianGiao datetime,@TinhTrang nvarchar(50)
as
begin
	begin tran
	set transaction isolation level read uncommitted
	insert into DatHang values(@MaNCC,@MaNH,@TongTien,@ThoiGianDat,@ThoiGianGiao,@TinhTrang)
	set @MaHoaDon = (select MaHoaDon from DatHang where MaNCC = @MaNCC and MaNH = @MaNH and ThoiGianDat = @ThoiGianDat)
	commit tran
end
GO
create proc UpdateDatHang @MaHoaDon int, @MaNCC int,@MaNH nchar(10),@TongTien float,@ThoiGianDat datetime,@ThoiGianGiao datetime,@TinhTrang nvarchar(50)
as
begin 
	update DatHang set MaNCC=@MaNCC, MaNH=@MaNH, TongTien=@TongTien, ThoiGianDat=@ThoiGianDat, ThoiGianGiao=@ThoiGianGiao, TinhTrang=@TinhTrang
	where MaHoaDon = @MaHoaDon
end
GO
create proc DeleteDatHang @MaHoaDon int
as
begin
	exec DeleteChiTietDatHang @MaHoaDon
	delete DatHang
	where MaHoaDon=@MaHoaDon
end
GO
