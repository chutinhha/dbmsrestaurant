
USE [QLNhaHang]
------------------------------ FIX TABLE NGUYEN LIEU -------------------------------------
GO
------
drop table NguyenLieu
GO
create table NguyenLieu
(
	MaNL int identity(1,1) not null,
	MaNH nchar(10) null,
	TenNL nvarchar(50) null,
	DonVi nvarchar(20) null,
	SoLuongTon int null,
	constraint PK_NguyenLieu primary key(MaNL)
)
GO
create table ChiTietNCC
(
	MaNL int,
	MaNCC int,
	Gia float,
	primary key (MaNL,MaNCC)
)
GO
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bánh tráng', N'Chục', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bánh tráng', N'Chục', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bánh tráng', N'Chục', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Trứng cút', N'Trăm', 20)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Trứng cút', N'Trăm', 20)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Trứng cút', N'Trăm', 20)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Thịt bò', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Hành tây', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Mì sợi', N'Kg', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Chem chép', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Hào', N'Con', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Nghêu', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Ốc hương', N'Kg', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Gà', N'Kg', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Mực', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Trứng vịt lộn', N'Trứng', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Chim sẻ', N'Con', 175)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Cá kèo', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Ếch', N'Con', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Cua', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Gạo', N'Kg', 200)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Cá diêu hồng', N'Kg', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Đậu phộng', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Đậu phộng', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Đậu phộng', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Thuốc mèo', N'Gói', 1120)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Thuốc mèo', N'Gói', 1120)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Thuốc mèo', N'Gói', 1120)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bánh phồng', N'Chục', 60)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bánh phồng', N'Chục', 60)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bánh phồng', N'Chục', 60)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Đậu hũ', N'Kg', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Đậu hũ', N'Kg', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Đậu hũ', N'Kg', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Hành, ngò, xả…', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Hành, ngò, xả…', N'Kg ', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Hành, ngò, xả…', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Nấm', N'Kg ', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Nấm', N'K', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Nấm', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Ốc móng tay', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Sò huyết', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Sò điệp', N'Kg', 30)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Mực ống', N'Kg', 40)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Tôm', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bún', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bún', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bún', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Lươn', N'Kg', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Mì', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Mì', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Mì', N'Kg', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bia 333', N'Lon', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bia 333', N'Lon', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bia 333', N'Lon', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bia Heniken chai', N'Chai', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bia Heniken chai', N'Chai', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bia Heniken chai', N'Chai', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bia Heniken lon', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bia Heniken lon', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bia Heniken lon', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bia sài gòn đỏ', N'Lon', 80)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bia sài gòn đỏ', N'Lon', 80)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bia sài gòn đỏ', N'Lon', 80)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Bia Tiger', N'Lon', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Bia Tiger', N'Lon', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Bia Tiger', N'Lon', 75)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'7 UP', N'Lon', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'7 UP', N'Lon', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'7 UP', N'Lon', 50)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Cam ép', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Cam ép', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Cam ép', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Coca cola', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Coca cola', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Coca cola', N'Lon', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Nước suối', N'Chai', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Nước suối', N'Chai', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Nước suối', N'Chai', 100)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Sting dau', N'Chai', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Sting dau', N'Chai', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Sting dau', N'Chai', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Thuốc 333', N'Gói', 200)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Thuốc 333', N'Gói', 200)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Thuốc 333', N'Gói', 200)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'1         ', N'Thuốc JET', N'Gói', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'2         ', N'Thuốc JET', N'Gói', 150)
INSERT INTO [dbo].[NguyenLieu] VALUES (N'3         ', N'Thuốc JET', N'Gói', 150)

------------------------ FIX TABLE DAT HANG & CHI TIET DAT HANG ----------------------------------
GO
drop table ChiTietDatHang
GO
create table [dbo].ChiTietDatHang
(
	MaHoaDon int not null,
	MaNL int not null,
	SoLuong int null,
	ThanhTien float null,
	constraint PK_ChiTietDatHang primary key(MaHoaDon,MaNL)
)
GO
drop table DatHang 	
GO
create table DatHang
(
	MaHoaDon int identity(1,1) not null,
	MaNCC int not null,
	MaNH nchar(10) null,
	TongTien float null,
	ThoiGianDat datetime null,
	ThoiGianGiao datetime null,
	TinhTrang nvarchar(50) null,
	constraint PK_DatHang primary key(MaHoaDon)
)
GO
alter table NguyenLieu 
add constraint FK_NguyenLieu_NhaHang foreign key(MaNH) references NhaHang(MaNH)
GO
alter table ChiTietNCC 
add constraint FK_ChiTietNCC_NhaCungCap foreign key (MaNCC) references NhaCungCap(MaNCC)
GO
alter table ChiTietNCC 
add constraint FK_ChiTietNCC_NguyenLieu foreign key (MaNL) references NguyenLieu(MaNL)
GO
alter table ChiTietDatHang 
add constraint FK_ChiTietDatHang_DatHang foreign key(MaHoaDon) references DatHang(MaHoaDon)
GO
alter table ChiTietDatHang 
add constraint FK_ChiTietDatHang_NguyenLieu foreign key(MaNL) references NguyenLieu(MaNL)
GO
alter table DatHang
add constraint FK_DatHang_NhaHang foreign key(MaNH) references NhaHang(MaNH)
GO
alter table DatHang
add constraint FK_DatHang_NhaCungCap foreign key(MaNCC) references NhaCungCap(MaNCC)

GO
----------------- INSERT DAT HANG -----------
