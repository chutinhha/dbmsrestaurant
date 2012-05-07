	--drop database QLNhaHang
	--create database QLNhaHang

use [QLNhaHang]
GO
------------------- Table Nguyen Lieu -----------------------------------
create proc SelectNguyenLieu @MaNH nchar(10)
as
begin
	select *
	from NguyenLieu nl
	where nl.MaNH = @MaNH
end
GO
create  proc InsertNguyenLieu @MaNH nchar(10),@TenNL nvarchar(50),@Gia float,@DonVi nvarchar(20),@SoLuongTon int
as
begin
	if((select count(*) from NguyenLieu where TenNL = @TenNL and MaNH =@MaNH)=0)
	begin
		insert into NguyenLieu values (@MaNH,@TenNL,@Gia,@DonVi,@SoLuongTon)
		return 1
	end
	else
		return 0
end
GO
alter proc UpdateNguyenLieu @TenNL_old nvarchar(50),@MaNL int,@MaNH nchar(10),@TenNL nvarchar(50),@Gia float,@DonVi nvarchar(20),@SoLuongTon int
as
begin
	if(@TenNL_old = @TenNL or(select count(*) from NguyenLieu where TenNL = @TenNL and MaNH =@MaNH)=0)
	begin
		update NguyenLieu set  MaNH=@MaNH,TenNL=@TenNL,Gia=@Gia,DonVi=@Donvi,SoLuongTon=@SoLuongTon
			where MaNL=@MaNL
		return 1
	end
	else
		return 0
end
GO
create proc DeleteNguyenLieu  @MaNL int,@MaNH nchar(10)
as
begin
delete from NguyenLieu where MaNL=@MaNL and MaNH=@MaNH
end

------------- table NhaCungCap --------------------------------------------
GO
create proc SelectNhaCungCap
as
begin
	select * 
	from NhaCungCap
end
GO
create proc InsertNhaCungCap @TenNCC nvarchar(50),@sdt nvarchar(50),@DiaChi nvarchar(50),@DiemUuTien int
as
begin
insert into NhaCungCap values(@TenNCC,@sdt,@DiaChi,@DiemUuTien)
end
GO
create proc UpdateNhaCungCap @MaNCC int,@TenNCC nvarchar(50),@sdt nvarchar(50),@DiaChi nvarchar(50),@DiemUuTien int
as
begin
	update NhaCungCap set TenNCC=@TenNCC,sdt=@sdt,DiaChi=@DiaChi,DiemUuTien=@DiemUuTien
	where MaNCC=@MaNCC
end
GO
create proc DeleteNhaCungCap @MaNCC int
as
begin
	delete NhaCungCap
	where MaNCC=@MaNCC
end
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