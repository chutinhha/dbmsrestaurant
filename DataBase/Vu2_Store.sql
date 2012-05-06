	--drop database QLNhaHang
	--create database QLNhaHang

use [QLNhaHang]
GO
------------------- Table Nguyen Lieu -----------------------------------
create proc SelectNguyenLieu @maNH nchar(10)
as
begin
	select *
	from NguyenLieu nl
	where nl.MaNH = @maNH
end
GO
create  proc InsertNguyenLieu @maNH nchar(10),@tenNL nvarchar(50),@gia float,@donvi nvarchar(20),@soluongton int
as
begin
	insert into NguyenLieu values (@maNH,@tenNL,@gia,@donvi,@soluongton)
end
GO
create proc UpdateNguyenLieu @maNL int,@maNH nchar(10),@tenNL nvarchar(50),@gia float,@donvi nvarchar(20),@soluongton int
as
begin
	update NguyenLieu set TenNL=@tenNL,Gia=@gia,DonVi=@donvi,SoLuongTon=@soluongton
	where MaNL=@maNL and MaNH=@maNH
end
GO
create proc DeleteNguyenLieu  @maNL int,@maNH nchar(10)
as
begin
delete from NguyenLieu where MaNL=@maNL and MaNH=@maNH
end

--TEST 
--exec SelectNguyenLieu 2
--exec InsertNguyenLieu 2,N'Bánh Trángưqwqwq',30000,N'Chục',50,1
--exec UpdateNguyenLieu 100,2,N'Bánh Tráng',30000,N'Chục',50,1
--exec DeleteNguyenLieu 100,2

------------- table NhaCungCap --------------------------------------------
GO
create proc SelectNhaCungCap
as
begin
	select * 
	from NhaCungCap
end
GO
create proc InsertNhaCungCap @tenNCC nvarchar(50),@sdt nvarchar(50),@diachi nvarchar(50),@diemuutien int
as
begin
insert into NhaCungCap values(@tenNCC,@sdt,@diachi,@diemuutien)
end
GO
create proc UpdateNhaCungCap @maNCC int,@tenNCC nvarchar(50),@sdt nvarchar(50),@diachi nvarchar(50),@diemuutien int
as
begin
	update NhaCungCap set TenNCC=@tenNCC,sdt=@sdt,DiaChi=@diachi,DiemUuTien=@diemuutien
	where MaNCC=@maNCC
end
GO
create proc DeleteNhaCungCap @maNCC int
as
begin
	delete NhaCungCap
	where MaNCC=@maNCC
end
------ TEST ---
--exec SelectNhaCungCap
--exec InsertNhaCungCap N'Minh Vũ','2323232','232424dfdsfds',2
--exec UpdateNhaCungCap 9,N'Minh Vũdfdslfsd','2323232','232424dfdsfds',2
--exec DeleteNhaCungCap 9

------------- table DatHang --------------------------------
GO
create proc SelectDatHang
as
begin
	select *
	from DatHang
end
GO
create proc InsertDatHang  @ThanhTien float,@ThoiGianDat datetime,@ThoiGianGiao nvarchar(10),@MaNH nchar(10)
as
begin
	insert into DatHang values(@ThanhTien,@ThoiGianDat,@ThoiGianGiao,@MaNH)
end
GO
create proc UpdateDatHang @MaHoaDonDat int,@ThanhTien float,@ThoiGianDat datetime,@ThoiGianGiao nvarchar(10),@MaNH nchar(10)
as
begin 
	update DatHang set ThanhTien=@ThanhTien,ThoiGianDat=@ThoiGianDat,ThoiGianGiao=@ThoiGianGiao,MaNH=@MaNH
	where MaHoaDonDat=@MaHoaDonDat
end
GO
create proc DeleteDatHang @MaHoaDonDat int
as
begin
	delete DatHang
	where MaHoaDonDat=@MaHoaDonDat
end
------------- table ChiTietDatHang -------------------------
GO
create proc SelectChiTietDatHang
as
begin
	select *
	from ChiTietDatHang
end
GO
create proc InsertChiTietDatHang @MaHoaDonDat int,@MaNCC int,@MaNguyenLieu int,@SoLuong int,@Gia float
as
begin
	insert into ChiTietDatHang values(@MaHoaDonDat,@MaNCC,@MaNguyenLIeu,@SoLuong,@Gia)
end
GO
create proc UpdateChiTietDatHang  @MaHoaDonDat int,@MaNCC int,@MaNguyenLieu int,@SoLuong int,@Gia float
as
begin
	update ChiTietDatHang set SoLuong=@SoLuong,Gia=@Gia
	where MaHoaDonDat=@MaHoaDonDat and MaNCC=@MaNCC and MaNguyenLieu=@MaNguyenLIeu
end
GO
create proc DeleteChiTietDatHang  @MaHoaDonDat int,@MaNCC int,@MaNguyenLieu int
as
begin
	delete ChiTietDatHang
	where MaHoaDonDat=@MaHoaDonDat and MaNCC=@MaNCC and MaNguyenLieu=@MaNguyenLIeu
end

-------- TEST ----------
--exec SelectChiTietDatHang 
--exec InsertChiTietDatHang 1,5,1,50,32032
--exec UpdateChiTietDatHang 1,5,1,50,0
--exec DeleteChiTietDatHang 1,5,1

GO
------------- table ChiTietNCC ---------
create proc SelectChiTietNCC
as
begin
	select *
	from ChiTietNCC
end
GO
create proc InsertChiTietNCC @MaNL int,@MaNCC int
as
begin
	insert into ChiTietNCC values (@MaNL,@MaNCC)
end
GO
create proc UpdateChiTietNCC @MaNL_old int,@MaNCC_old int,@MaNL int,@MaNCC int
as
begin
	update ChiTietNCC set MaNL =@MaNL,MaNCC =@MaNCC
	where MaNL =@MaNL_old and MaNCC=@MaNCC_old
end
GO
create proc DeleteChiTietNCC @MaNL int,@MaNCC int
as
begin
	delete ChiTietNCC
	where MaNL =@MaNL and MaNCC=@MaNCC
end