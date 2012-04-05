create database QLNhaHanga
GO
use QLNhaHanga
--use master
--drop database QLNhaHanga
GO
create table NhanVien
(
MaNV int identity,
TenNV nvarchar(50),
MaNH int,
Maloai nchar(10),
primary key(MaNV)
)
--insert into NhanVien(TenNV,MaNH,Maloai) values('sdf',1,'sd')
--select * from NhanVien
--drop table NhanVien



GO
create table LoaiNV
(
MaLoai nchar(10),
TenLoai nvarchar(30),
Luong money,
primary key(MaLoai)
)
GO
create table NhaHang
(
MaNH int identity,
TenNH nvarchar(30),
DiaChi nvarchar(50),
sdt int,
MaNQL int,
primary key(manh)
)


GO --drop table LoaiNV
create table HoaDon
(
MaHD int identity,
TongTien money,
ThoiGianLap datetime,
MaNV int,
MaBan int,
primary key(MaHD)
)

GO
create table ChiTietHoaDon
(
MaHD int,
MaMon int,
SoLuong int,
ThanhTien money,
primary key(MaHD,MaMon)
)

GO
create table KhuVuc
(
MaKhuVuc nchar(10),
TenKhuVuc nvarchar(30),
ViTri nchar(10),
primary key (MaKhuVuc)
)
GO --drop table loaiban
create table LoaiBan
(
Maloai nchar(10),
SucChua int,
primary key(MaLoai)
)
GO
create table BanAn
(
MaBan int identity,
MaKhuVuc nchar(10),
LoaiBan nchar(10),
TrangThai bit,
MaNH int,
primary key (MaBan)
)

GO--drop table BanAn
create table MonAn
(
MaMon int identity,
TenMon nvarchar(30),
LoaiMon int,
Gia money,
DonViTinh nchar(10),
MaNH int,
primary key (MaMon)
)

GO
create table LoaiMonAn
(
MaLoai int identity,
TenLoai nvarchar(50),
primary key(MaLoai)
)
GO
create table ChiTietMonAn
(
MaMon int,
MaNguyenLieu int,
SoLuong int,
primary key(MaMon,MaNguyenLieu)
)

GO
create table DatBan
(
MaNH int,
MaBan int,
sdtKhachHang int,
ThoiGianDat datetime,
TrangThai int,
ThoiGianDen datetime,
primary key(MaNH,MaBan,ThoiGianDen)
)

GO
create table NhaCungCap
(
MaNCC int identity,
TenNCC nvarchar(50),
sdt int,
DiaChi nvarchar(50),
DiemUuTien int,
primary key (MaNCC)
)
GO--Them cot SucChua vao bang NguyenLieu
create table NguyenLieu
(
MaNL int identity,
TenNL nvarchar(50),
Gia money,
SoLuongTon int,
MaNH int,
MaNCC int,
SucChua int,
primary key (MaNL)
)

GO
create table DatHang
(
MaHoaDonDat int identity,
ThanhTien int,
ThoiGianDat datetime,
ThoiGianGiao nchar(10),
MaNH int,
primary key(MaHoaDonDat)
)

GO
create table ChiTietDatHang
(
MaHoaDonDat int,
MaNCC int,
MaNguyenLieu int,
SoLuong int,
Gia money,
primary key(MaHoaDonDat,MaNCC,MaNguyenLieu)
)

GO
create table QLNguoiDung
(
UserName nvarchar(50),
Pass nvarchar(50),
QuyenHan nchar(10),
Email nvarchar(50),
primary key(UserName)
)
GO

alter table NhanVien add constraint FK_NhanVien_LoaiNV foreign key(MaLoai) references LoaiNV(Maloai)
alter table NhanVien add constraint FK_NhanVien_MaNH foreign key(MaNH) references NhaHang(MaNH)

alter table ChiTietDatHang  add constraint FK_ChiTietDatHang_DatHang foreign key(MaHoaDonDat)  references DatHang(MaHoaDonDat)
alter table ChiTietDatHang  add constraint FK_ChiTietDatHang_NhaCungCap foreign key(MaNCC)  references NhaCungCap(MaNCC)
alter table ChiTietDatHang  add constraint FK_ChiTietDatHang_NguyenLieu foreign key(MaNguyenLieu)  references NguyenLieu(MaNL)

alter table DatHang  add constraint FK_DatHang_NhaHang foreign key (MaNH)  references NhaHang(MaNH)

alter table NguyenLieu  add constraint FK_NguyenLieu_NhaHang foreign key(MaNH)  references NhaHang(MaNH)
alter table NguyenLieu   add constraint FK_NguyenLieu_NhaCungCap foreign key(MaNCC)  references NhaCungCap(MaNCC)

alter table DatBan add constraint FK_DatBan_NhaHang foreign key (MaNH) references NhaHang(MaNH)
alter table DatBan add constraint FK_DatBan_BanAn foreign key (MaBan) references BanAn(MaBan)

alter table ChiTietMonAn add constraint FK_ChiTietMonAn_MonAn foreign key(MaMon) references MonAn(MaMon)
alter table ChiTietMonAn add constraint FK_ChiTietMonAn_NguyenLieu foreign key(MaNguyenLieu) references NguyenLieu(MaNL)

alter table MonAn add constraint FK_MonAn_LoaiMonAn foreign key(LoaiMon) references LoaiMonAn(MaLoai)
alter table MonAn add constraint FK_MonAn_NhaHang foreign key (MaNH) references NhaHang(MaNH)

alter table BanAn add constraint FK_BanAn_KhuVuc foreign key(MaKhuVuc) references KhuVuc(MaKhuVuc)
alter table BanAn add constraint FK_BanAn_LoaiBan foreign key(LoaiBan) references LoaiBan(MaLoai)
alter table BanAn add constraint FK_BanAn_NhaHang foreign key(MaNH) references NhaHang(MaNH)


alter table ChiTietHoaDon add constraint FK_ChiTietHoaDon_HoaDon foreign key(MaHD) references HoaDon(MaHD)
alter table ChiTietHoaDon add constraint FK_ChiTietHoaDon_MonAn foreign key(MaMOn) references MonAn(MaMon)

alter table HoaDon add constraint FK_HoaDon_NhanVien foreign key(MaNV) references NhanVien(MaNV)
alter table HoaDon add constraint FK_HoaDon_BanAn foreign key(MaBan) references BanAn(MaBan)

alter table NhaHang add constraint FK_NhanHang_NhanVien foreign key(MaNQL) references NhanVien(MaNV)



