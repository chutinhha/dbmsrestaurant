
use [QLNhaHang]
GO
--------------- table ChiTietDatHang -------------------------

create proc SelectChiTietDatHang @MaHoaDon int
as
begin
	select ct.*,nl.TenNL,nl.DonVi
	from ChiTietDatHang ct,NguyenLieu nl
	where MaHoaDon = @MaHoaDon and ct.MaNL = nl.MaNL
end
GO
create proc InsertChiTietDatHang @MaHoaDon int,@MaNL int,@SoLuong int,@ThanhTien float
as
begin
	insert into ChiTietDatHang values(@MaHoaDon,@MaNL,@SoLuong,@ThanhTien)
end
GO
create proc DeleteChiTietDatHang  @MaHoaDon int
as
begin
	delete ChiTietDatHang
	where MaHoaDon=@MaHoaDon
end
GO
create proc DeleteChiTietDatHang_fromNL  @MaNL int
as
begin
	delete ChiTietDatHang
	where MaNL = @MaNL
end
GO
--------------- table DatHang --------------------------------
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
	insert into DatHang values(@MaNCC,@MaNH,@TongTien,@ThoiGianDat,@ThoiGianGiao,@TinhTrang)
	set @MaHoaDon = (select MaHoaDon from DatHang where MaNCC = @MaNCC and MaNH = @MaNH and ThoiGianDat = @ThoiGianDat)
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
