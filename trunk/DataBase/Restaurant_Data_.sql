USE [QLNhaHang]
GO
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMonAn](
	[MaLoai] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'Bia       ', N'Bia các loại')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'Com       ', N'Cơm, mì, cháo, lẩu')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'GaCuaGhe  ', N'Gà, cua, ghẹ, mực')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'HS        ', N'Hải sản tươi sống')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'KV        ', N'Khai vị')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'MonBo     ', N'Các món bò')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'NgheuSo   ', N'Nghêu sò ốc')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'NN        ', N'Nước ngọt các loại')
INSERT [dbo].[LoaiMonAn] ([MaLoai], [TenLoai]) VALUES (N'TL        ', N'Thuốc lá')
/****** Object:  Table [dbo].[NhaHang]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaHang](
	[MaNH] [nchar](10) NOT NULL,
	[TenNH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[sdt] [int] NULL,
	[MaNQL] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhaHang] ([MaNH], [TenNH], [DiaChi], [sdt], [MaNQL]) VALUES (N'1         ', N'Nhà hàng hải sản Nha Trang', N'123, Quang Trung, Gò Vấp', 83888666, 3)
INSERT [dbo].[NhaHang] ([MaNH], [TenNH], [DiaChi], [sdt], [MaNQL]) VALUES (N'2         ', N'Nhà hàng Tân Sơn Nhất', N'456, Hoàng Văn Thụ, Bình Thạnh', 83444555, 1)
INSERT [dbo].[NhaHang] ([MaNH], [TenNH], [DiaChi], [sdt], [MaNQL]) VALUES (N'3         ', N'Nhà hàng Caravel', N'5, Đồng Khởi, Q.1', 83777555, 3)
INSERT [dbo].[NhaHang] ([MaNH], [TenNH], [DiaChi], [sdt], [MaNQL]) VALUES (N'4         ', N'Nhà hàng Cepage', N'22-22BIS Lê Thánh Tôn, Q.1', 88238321, 3)
INSERT [dbo].[NhaHang] ([MaNH], [TenNH], [DiaChi], [sdt], [MaNQL]) VALUES (N'5         ', N'Nhà hàng CATHAY kim cương', N'19A, Bùi Thị Xuân, Q.1', 88399651, 3)
/****** Object:  Table [dbo].[MonAn]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMon] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](30) NULL,
	[LoaiMon] [nchar](10) NULL,
	[Gia] [money] NULL,
	[DonViTinh] [nchar](10) NULL,
	[MaNH] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MonAn] ON
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (1, N'Bánh tráng nướng', N'KV        ', 8000.0000, N'Cái       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (2, N'Đậu phộng rang', N'KV        ', 10000.0000, N'Gói       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (3, N'Trứng cút luộc', N'KV        ', 12000.0000, N'Chục      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (4, N'Đậu hũ chiên xả', N'KV        ', 28000.0000, N'Đĩa       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (5, N'Bò lúc lắc', N'MonBo     ', 58000.0000, N'Đĩa       ', N'2         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (6, N'Bò Xào Hành Tây', N'MonBo     ', 50000.0000, N'Đĩa       ', N'2         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (7, N'Hủ tiếu - mì bò kho', N'MonBo     ', 18000.0000, N'Tô        ', N'2         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (9, N'Chem chép', N'NgheuSo   ', 35000.0000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (10, N'Hào sống', N'NgheuSo   ', 18000.0000, N'Con       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (11, N'Nghêu', N'NgheuSo   ', 29000.0000, N'Thố       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (12, N'Ốc hương', N'NgheuSo   ', 25000.0000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (13, N'Ốc móng tay', N'NgheuSo   ', 40000.0000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (16, N'Sò huyết', N'NgheuSo   ', 29000.0000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (17, N'Sò điệp', N'NgheuSo   ', 39000.0000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (18, N'Cánh gà', N'GaCuaGhe  ', 39000.0000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (19, N'Chân gà', N'GaCuaGhe  ', 13000.0000, N'Cặp       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (20, N'Khô mực', N'GaCuaGhe  ', 55000.0000, N'Con       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (21, N'Trứng vịt lộn', N'GaCuaGhe  ', 10000.0000, N'Trứng     ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (22, N'Chim sẻ', N'GaCuaGhe  ', 39000.0000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (23, N'Cá kèo', N'HS        ', 39000.0000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (24, N'Ếch', N'HS        ', 21000.0000, N'Con       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (25, N'Mực ống', N'HS        ', 44000.0000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (26, N'Tôm càng xanh', N'HS        ', 20000.0000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (27, N'Tôm sú', N'HS        ', 30000.0000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (28, N'Cua gạch', N'HS        ', 20000.0000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (29, N'Cua thịt', N'HS        ', 25000.0000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (31, N'Bún thêm', N'Com       ', 6000.0000, N'Đĩa       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (32, N'Cháo', N'Com       ', 40000.0000, N'Thố       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (33, N'Cơm chiên', N'Com       ', 50000.0000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (34, N'Lẩu cá diêu hồng', N'Com       ', 80000.0000, N'Cái       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (36, N'Lẩu lươn', N'Com       ', 85000.0000, N'Cái       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (37, N'Mì xào', N'Com       ', 50000.0000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (38, N'Bia 333', N'Bia       ', 11000.0000, N'Lon       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (39, N'Bia Heniken chai', N'Bia       ', 16000.0000, N'Ly        ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (40, N'Bia Heniken lon', N'Bia       ', 18000.0000, N'Lon       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (41, N'Bia sài gòn đỏ', N'Bia       ', 9000.0000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (42, N'Bia Tiger', N'Bia       ', 15000.0000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (43, N'7 UP', N'NN        ', 8000.0000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (44, N'Cam ép', N'NN        ', 9000.0000, N'Lon       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (45, N'Coca cola', N'NN        ', 7000.0000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (46, N'Nước suối', N'NN        ', 6000.0000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (47, N'Sting dau', N'NN        ', 10000.0000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (48, N'Thuốc 333', N'TL        ', 35000.0000, N'Gói       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (49, N'Thuốc JET', N'TL        ', 20000.0000, N'Gói       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (50, N'Thuốc mèo', N'TL        ', 20000.0000, N'Gói       ', NULL)
SET IDENTITY_INSERT [dbo].[MonAn] OFF
/****** Object:  Table [dbo].[ChiTietMonAn]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietMonAn](
	[MaMon] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuong] [float] NULL,
 CONSTRAINT [PK__ChiTietM__762E309D2E1BDC42] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (1, 1, 2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (2, 19, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (3, 2, 0.1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (4, 20, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (4, 21, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (5, 3, 0.4)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (5, 22, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (6, 3, 0.4)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (6, 4, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (7, 3, 0.4)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (7, 5, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (7, 22, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (9, 6, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (10, 7, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (11, 8, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (12, 9, 0.6)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (13, 23, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (16, 24, 0.6)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (17, 25, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (18, 10, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (19, 10, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (20, 11, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (21, 12, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (22, 13, 3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (22, 21, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (23, 14, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (23, 21, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (24, 15, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (24, 21, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (25, 21, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (25, 22, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (25, 26, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (26, 21, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (26, 22, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (26, 27, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (27, 21, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (27, 27, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (28, 16, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (29, 16, 0.4)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (31, 28, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (32, 17, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (33, 17, 0.4)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (34, 18, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (34, 21, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (34, 22, 0.7)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (36, 21, 0.2)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (36, 22, 0.3)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (36, 29, 0.5)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (37, 30, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (38, 31, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (39, 32, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (40, 33, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (41, 34, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (42, 35, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (43, 36, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (44, 37, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (45, 38, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (46, 39, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (47, 40, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (48, 41, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (49, 42, 1)
INSERT [dbo].[ChiTietMonAn] ([MaMon], [MaNguyenLieu], [SoLuong]) VALUES (50, 43, 1)
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNV](
	[MaLoai] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](30) NULL,
	[Luong] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai], [Luong]) VALUES (N'1         ', N'Quản lý nhà hàng', 10000000.0000)
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai], [Luong]) VALUES (N'2         ', N'Quản lý kho', 6000000.0000)
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai], [Luong]) VALUES (N'3         ', N'Tiếp tân', 5000000.0000)
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai], [Luong]) VALUES (N'4         ', N'Thu ngân', 5000000.0000)
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai], [Luong]) VALUES (N'5         ', N'Phục vụ', 4000000.0000)
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai], [Luong]) VALUES (N'6         ', N'Quản trị hệ thống', 8000000.0000)
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[MaNH] [nchar](10) NULL,
	[Maloai] [nchar](10) NULL,
	[cmnd] [int] NULL,
	[sdt] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt]) VALUES (1, N'Nguyễn Bá Ngọc', N'2         ', N'1         ', 123456789, 936214587)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt]) VALUES (2, N'Nguyễn Minh Vũ', N'1         ', N'2         ', 321654987, 963258774)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt]) VALUES (3, N'Bùi Trung Tân', N'1         ', N'1         ', 271955488, 936786110)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt]) VALUES (4, N'Nguyễn Minh Nghĩa', N'3         ', N'2         ', 321654874, 978541231)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt]) VALUES (5, N'Hoàng Anh Tú', N'4         ', N'6         ', 214547874, 905214533)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt]) VALUES (6, N'Trần Minh Vương', N'1         ', N'5         ', 963258741, 936521447)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt]) VALUES (7, N'Nguyễn Bảo Thanh Thanh', N'1         ', N'4         ', 741214754, 984125631)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
/****** Object:  Table [dbo].[LoaiBan]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBan](
	[Maloai] [nchar](10) NOT NULL,
	[SucChua] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Maloai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiBan] ([Maloai], [SucChua]) VALUES (N'1         ', 5)
INSERT [dbo].[LoaiBan] ([Maloai], [SucChua]) VALUES (N'2         ', 10)
INSERT [dbo].[LoaiBan] ([Maloai], [SucChua]) VALUES (N'3         ', 15)
INSERT [dbo].[LoaiBan] ([Maloai], [SucChua]) VALUES (N'4         ', 20)
INSERT [dbo].[LoaiBan] ([Maloai], [SucChua]) VALUES (N'5         ', 30)
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[MaKhuVuc] [int] NOT NULL,
	[TenKhuVuc] [nvarchar](30) NULL,
	[ViTri] [nvarchar](30) NULL,
	[MaNH] [nchar](10) NULL,
 CONSTRAINT [PK__KhuVuc__0676EB831273C1CD] PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (1, N'Sảnh – tầng trệt', N'Giữa đại sảnh của nhà hang', NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (2, N'Góc – tầng trệt', N'Nằm ở góc', NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (3, N'Sát tường - tầng trệt', N'Sát tường, nhìn ra bên ngoài', NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (4, N'Lầu 1', N'Lầu 1', NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (5, N'Lầu 2', N'Lầu 2', NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (6, N'Sân thượng', N'Sân thượng', NULL)
/****** Object:  Table [dbo].[BanAn]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[MaBan] [int] IDENTITY(1,1) NOT NULL,
	[MaKhuVuc] [int] NULL,
	[LoaiBan] [nchar](10) NULL,
	[MaNH] [nchar](10) NULL,
	[TrangThai] [tinyint] NULL,
 CONSTRAINT [PK__BanAn__3520ED6C1A14E395] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BanAn] ON
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (1, 1, N'4         ', N'1         ', 0)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (2, 2, N'3         ', N'1         ', 0)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (3, 6, N'2         ', N'1         ', 0)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (4, 4, N'2         ', N'2         ', 2)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (5, 1, N'2         ', N'2         ', 1)
SET IDENTITY_INSERT [dbo].[BanAn] OFF
/****** Object:  Table [dbo].[HoaDon]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[TongTien] [money] NULL,
	[ThoiGianLap] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[MaNV] [int] NULL,
	[MaBan] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON
INSERT [dbo].[HoaDon] ([MaHD], [TongTien], [ThoiGianLap], [ThoiGianKetThuc], [MaNV], [MaBan]) VALUES (1, 1390000.0000, CAST(0x0000A00B0128A180 AS DateTime), CAST(0x0000A00B0172C9E0 AS DateTime), 7, 2)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [int] NOT NULL,
	[MaMon] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (1, 1, 3, 24000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (1, 9, 1, 35000.0000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (1, 34, 1, 80000.0000)
/****** Object:  Table [dbo].[DatHang]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MaHoaDonDat] [int] IDENTITY(1,1) NOT NULL,
	[ThanhTien] [int] NULL,
	[ThoiGianDat] [datetime] NULL,
	[ThoiGianGiao] [nchar](10) NULL,
	[MaNH] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDonDat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DatHang] ON
INSERT [dbo].[DatHang] ([MaHoaDonDat], [ThanhTien], [ThoiGianDat], [ThoiGianGiao], [MaNH]) VALUES (1, 2200000, CAST(0x0000A00B00000000 AS DateTime), N'6/5/2012  ', N'2         ')
SET IDENTITY_INSERT [dbo].[DatHang] OFF
/****** Object:  Table [dbo].[DatBan]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatBan](
	[MaNH] [nchar](10) NOT NULL,
	[MaBan] [int] NOT NULL,
	[maKhachHang] [int] NULL,
	[ThoiGianDat] [datetime] NULL,
	[TrangThai] [int] NULL,
	[ThoiGianDen] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC,
	[MaBan] ASC,
	[ThoiGianDen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DatBan] ([MaNH], [MaBan], [maKhachHang], [ThoiGianDat], [TrangThai], [ThoiGianDen]) VALUES (N'1         ', 1, 123654789, CAST(0x0000A00B00000000 AS DateTime), 1, CAST(0x0000A0E100000000 AS DateTime))
/****** Object:  Table [dbo].[QLNguoiDung]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLNguoiDung](
	[UserName] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
	[QuyenHan] [nchar](10) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [QuyenHan], [Email]) VALUES (N'Nbngoc', N'asdf1234', N'4         ', N'nbngoc@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [QuyenHan], [Email]) VALUES (N'Ngvu', N'asdffdsa', N'2         ', N'nmvu@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [QuyenHan], [Email]) VALUES (N'trungtan', N'123654', N'1         ', N'trungtanbui@gmail.com')
/****** Object:  Table [dbo].[KhachHang]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[cmnd] [int] NOT NULL,
	[TenKhachHang] [nvarchar](30) NULL,
	[sdt] [int] NULL,
	[loai] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[cmnd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KhachHang] ([cmnd], [TenKhachHang], [sdt], [loai]) VALUES (123654789, N'Trung Tân', 936786110, N'1         ')
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[sdt] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DiemUuTien] [int] NULL,
 CONSTRAINT [PK__NhaCungC__3A185DEB267ABA7A] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhaCungCap] ON
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [sdt], [DiaChi], [DiemUuTien]) VALUES (1, N'Đại lý thực phẩm Vissan', N'(08) 3840 4826', N'114B, Trần Quang Khải, Quận 1, TP.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [sdt], [DiaChi], [DiemUuTien]) VALUES (5, N'Công ty thực phẩn SAFACO', N'(848) 37 245 275 – 37 245 272', N'7  Kha Vạn Cân, P.Linh Tây, Q.Thủ Đức, Tp.HCM', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [sdt], [DiaChi], [DiemUuTien]) VALUES (6, N'Công ty CP thực phẩm Cholimex', N'(08) – 38 573482 – 38 548258', N'Đường số 7, KCN Vĩnh Lộc, huyện Bình Chánh, TP HCM', 3)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [sdt], [DiaChi], [DiemUuTien]) VALUES (7, N'Công ty TNHH Yến Sào Khánh Hoà', N'08.3865 5495', N'540 đường  3/2 Quận 10 Tp. HCM  ', 4)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [sdt], [DiaChi], [DiemUuTien]) VALUES (8, N'CTY TNHH Kinh doanh thực phẩm trực tuyến', N'08.3829.7342', N'174 Đinh Tiên Hoàng - Q.1 - TP.HCM', 3)
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNL] [int] NOT NULL,
	[MaNH] [nchar](10) NOT NULL,
	[TenNL] [nvarchar](50) NULL,
	[Gia] [money] NULL,
	[DonVi] [nchar](10) NULL,
	[SoLuongTon] [int] NULL,
	[MaNCC] [int] NULL,
 CONSTRAINT [PK__NguyenLi__2725D73C2A4B4B5E] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC,
	[MaNH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (1, N'1         ', N'Bánh tráng', 30000.0000, N'Chục      ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (1, N'2         ', N'Bánh tráng', 30000.0000, N'Chục      ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (1, N'3         ', N'Bánh tráng', 30000.0000, N'Chục      ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (2, N'1         ', N'Trứng cút', 50000.0000, N'Trăm      ', 20, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (2, N'2         ', N'Trứng cút', 50000.0000, N'Trăm      ', 20, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (2, N'3         ', N'Trứng cút', 50000.0000, N'Trăm      ', 20, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (3, N'2         ', N'Thịt bò', 100000.0000, N'Kg        ', 100, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (4, N'2         ', N'Hành tây', 20000.0000, N'Kg        ', 100, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (5, N'2         ', N'Mì sợi', 50000.0000, N'Kg        ', 150, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (6, N'1         ', N'Chem chép', 40000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (7, N'1         ', N'Hào', 10000.0000, N'Con       ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (8, N'1         ', N'Nghêu', 30000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (9, N'1         ', N'Ốc hương', 100000.0000, N'Kg        ', 75, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (10, N'3         ', N'Gà', 55000.0000, N'Kg        ', 150, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (11, N'1         ', N'Mực', 120000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (12, N'3         ', N'Trứng vịt lộn', 3000.0000, N'Trứng     ', 75, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (13, N'3         ', N'Chim sẻ', 10000.0000, N'Con       ', 175, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (14, N'1         ', N'Cá kèo', 60000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (15, N'1         ', N'Ếch', 15000.0000, N'Con       ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (16, N'1         ', N'Cua', 50000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (17, N'1         ', N'Gạo', 13000.0000, N'Kg        ', 200, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (18, N'1         ', N'Cá diêu hồng', 40000.0000, N'Kg        ', 75, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (19, N'1         ', N'Đậu phộng', 30000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (19, N'2         ', N'Đậu phộng', 30000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (19, N'3         ', N'Đậu phộng', 30000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (20, N'1         ', N'Đậu hũ', 30000.0000, N'Kg        ', 75, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (20, N'2         ', N'Đậu hũ', 30000.0000, N'Kg        ', 75, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (20, N'3         ', N'Đậu hũ', 30000.0000, N'Kg        ', 75, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (21, N'1         ', N'Hành, ngò, xả…', 10000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (21, N'2         ', N'Hành, ngò, xả…', 10000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (21, N'3         ', N'Hành, ngò, xả…', 10000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (22, N'1         ', N'Nấm', 30000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (22, N'2         ', N'Nấm', 30000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (22, N'3         ', N'Nấm', 30000.0000, N'Kg        ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (23, N'1         ', N'Ốc móng tay', 60000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (24, N'1         ', N'Sò huyết', 30000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (25, N'1         ', N'Sò điệp', 30000.0000, N'Kg        ', 30, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (26, N'1         ', N'Mực ống', 40000.0000, N'Kg        ', 40, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (27, N'1         ', N'Tôm', 60000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (28, N'1         ', N'Bún', 20000.0000, N'Kg        ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (28, N'2         ', N'Bún', 20000.0000, N'Kg        ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (28, N'3         ', N'Bún', 20000.0000, N'Kg        ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (29, N'1         ', N'Lươn', 100000.0000, N'Kg        ', 50, 5)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (30, N'1         ', N'Mì', 20000.0000, N'Kg        ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (30, N'2         ', N'Mì', 20000.0000, N'Kg        ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (30, N'3         ', N'Mì', 20000.0000, N'Kg        ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (31, N'1         ', N'Bia 333', 10000.0000, N'Lon       ', 150, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (31, N'2         ', N'Bia 333', 10000.0000, N'Lon       ', 150, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (31, N'3         ', N'Bia 333', 10000.0000, N'Lon       ', 150, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (32, N'1         ', N'Bia Heniken chai', 12000.0000, N'Chai      ', 100, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (32, N'2         ', N'Bia Heniken chai', 12000.0000, N'Chai      ', 100, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (32, N'3         ', N'Bia Heniken chai', 12000.0000, N'Chai      ', 100, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (33, N'1         ', N'Bia Heniken lon', 14000.0000, N'Lon       ', 100, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (33, N'2         ', N'Bia Heniken lon', 14000.0000, N'Lon       ', 100, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (33, N'3         ', N'Bia Heniken lon', 14000.0000, N'Lon       ', 100, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (34, N'1         ', N'Bia sài gòn đỏ', 7500.0000, N'Lon       ', 80, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (34, N'2         ', N'Bia sài gòn đỏ', 7500.0000, N'Lon       ', 80, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (34, N'3         ', N'Bia sài gòn đỏ', 7500.0000, N'Lon       ', 80, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (35, N'1         ', N'Bia Tiger', 12000.0000, N'Lon       ', 75, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (35, N'2         ', N'Bia Tiger', 12000.0000, N'Lon       ', 75, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (35, N'3         ', N'Bia Tiger', 12000.0000, N'Lon       ', 75, 6)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (36, N'1         ', N'7 UP', 6000.0000, N'Lon       ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (36, N'2         ', N'7 UP', 6000.0000, N'Lon       ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (36, N'3         ', N'7 UP', 6000.0000, N'Lon       ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (37, N'1         ', N'Cam ép', 8000.0000, N'Lon       ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (37, N'2         ', N'Cam ép', 8000.0000, N'Lon       ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (37, N'3         ', N'Cam ép', 8000.0000, N'Lon       ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (38, N'1         ', N'Coca cola', 6000.0000, N'Lon       ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (38, N'2         ', N'Coca cola', 6000.0000, N'Lon       ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (38, N'3         ', N'Coca cola', 6000.0000, N'Lon       ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (39, N'1         ', N'Nước suối', 3000.0000, N'Chai      ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (39, N'2         ', N'Nước suối', 3000.0000, N'Chai      ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (39, N'3         ', N'Nước suối', 3000.0000, N'Chai      ', 100, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (40, N'1         ', N'Sting dau', 8000.0000, N'Chai      ', 150, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (40, N'2         ', N'Sting dau', 8000.0000, N'Chai      ', 150, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (40, N'3         ', N'Sting dau', 8000.0000, N'Chai      ', 150, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (41, N'1         ', N'Thuốc 333', 30000.0000, N'Gói       ', 200, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (41, N'2         ', N'Thuốc 333', 30000.0000, N'Gói       ', 200, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (41, N'3         ', N'Thuốc 333', 30000.0000, N'Gói       ', 200, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (42, N'1         ', N'Thuốc JET', 15000.0000, N'Gói       ', 150, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (42, N'2         ', N'Thuốc JET', 15000.0000, N'Gói       ', 150, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (42, N'3         ', N'Thuốc JET', 15000.0000, N'Gói       ', 150, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (43, N'1         ', N'Thuốc mèo', 15000.0000, N'Gói       ', 1120, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (43, N'2         ', N'Thuốc mèo', 15000.0000, N'Gói       ', 1120, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (43, N'3         ', N'Thuốc mèo', 15000.0000, N'Gói       ', 1120, 8)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (45, N'1         ', N'Bánh tráng', 30000.0000, N'Chục      ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (45, N'2         ', N'Bánh tráng', 30000.0000, N'Chục      ', 50, 1)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon], [MaNCC]) VALUES (45, N'3         ', N'Bánh tráng', 30000.0000, N'Chục      ', 50, 1)
/****** Object:  Table [dbo].[ChiTietDatHang]    Script Date: 05/03/2012 19:30:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatHang](
	[MaHoaDonDat] [int] NOT NULL,
	[MaNCC] [int] NOT NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[Gia] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDonDat] ASC,
	[MaNCC] ASC,
	[MaNguyenLieu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDatHang] ([MaHoaDonDat], [MaNCC], [MaNguyenLieu], [SoLuong], [Gia]) VALUES (1, 5, 3, 20, 2000000.0000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDonDat], [MaNCC], [MaNguyenLieu], [SoLuong], [Gia]) VALUES (1, 6, 4, 10, 200000.0000)
/****** Object:  Default [DF__BanAn__TrangThai__1BFD2C07]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[BanAn] ADD  CONSTRAINT [DF__BanAn__TrangThai__1BFD2C07]  DEFAULT ((0)) FOR [TrangThai]
GO
/****** Object:  ForeignKey [FK_BanAn_KhuVuc]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[BanAn]  WITH CHECK ADD  CONSTRAINT [FK_BanAn_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[BanAn] CHECK CONSTRAINT [FK_BanAn_KhuVuc]
GO
/****** Object:  ForeignKey [FK_BanAn_LoaiBan]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[BanAn]  WITH CHECK ADD  CONSTRAINT [FK_BanAn_LoaiBan] FOREIGN KEY([LoaiBan])
REFERENCES [dbo].[LoaiBan] ([Maloai])
GO
ALTER TABLE [dbo].[BanAn] CHECK CONSTRAINT [FK_BanAn_LoaiBan]
GO
/****** Object:  ForeignKey [FK_ChiTietDatHang_DatHang]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[ChiTietDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatHang_DatHang] FOREIGN KEY([MaHoaDonDat])
REFERENCES [dbo].[DatHang] ([MaHoaDonDat])
GO
ALTER TABLE [dbo].[ChiTietDatHang] CHECK CONSTRAINT [FK_ChiTietDatHang_DatHang]
GO
/****** Object:  ForeignKey [FK_ChiTietDatHang_NhaCungCap]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[ChiTietDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[ChiTietDatHang] CHECK CONSTRAINT [FK_ChiTietDatHang_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HoaDon]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_MonAn]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_MonAn] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAn] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_MonAn]
GO
/****** Object:  ForeignKey [FK_ChiTietMonAn_MonAn]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[ChiTietMonAn]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMonAn_MonAn] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAn] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietMonAn] CHECK CONSTRAINT [FK_ChiTietMonAn_MonAn]
GO
/****** Object:  ForeignKey [FK_DatBan_BanAn]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[DatBan]  WITH CHECK ADD  CONSTRAINT [FK_DatBan_BanAn] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BanAn] ([MaBan])
GO
ALTER TABLE [dbo].[DatBan] CHECK CONSTRAINT [FK_DatBan_BanAn]
GO
/****** Object:  ForeignKey [FK_DatBan_NhaHang]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[DatBan]  WITH CHECK ADD  CONSTRAINT [FK_DatBan_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[DatBan] CHECK CONSTRAINT [FK_DatBan_NhaHang]
GO
/****** Object:  ForeignKey [FK_DatHang_NhaHang]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhaHang]
GO
/****** Object:  ForeignKey [FK_HoaDon_BanAn]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_BanAn] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BanAn] ([MaBan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_BanAn]
GO
/****** Object:  ForeignKey [FK_HoaDon_NhanVien]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  ForeignKey [FK_KhuVuc_NhaHang]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[KhuVuc]  WITH CHECK ADD  CONSTRAINT [FK_KhuVuc_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[KhuVuc] CHECK CONSTRAINT [FK_KhuVuc_NhaHang]
GO
/****** Object:  ForeignKey [FK_MonAn_LoaiMonAn]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_LoaiMonAn] FOREIGN KEY([LoaiMon])
REFERENCES [dbo].[LoaiMonAn] ([MaLoai])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_LoaiMonAn]
GO
/****** Object:  ForeignKey [FK_MonAn_NhaHang]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_NhaHang]
GO
/****** Object:  ForeignKey [FK_NguyenLieu_NhaCungCap]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_NguyenLieu_NhaHang]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_NhaHang]
GO
/****** Object:  ForeignKey [FK_NhanHang_NhanVien]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[NhaHang]  WITH CHECK ADD  CONSTRAINT [FK_NhanHang_NhanVien] FOREIGN KEY([MaNQL])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhaHang] CHECK CONSTRAINT [FK_NhanHang_NhanVien]
GO
/****** Object:  ForeignKey [FK_NhanVien_LoaiNV]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNV] FOREIGN KEY([Maloai])
REFERENCES [dbo].[LoaiNV] ([MaLoai])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNV]
GO
/****** Object:  ForeignKey [FK_NhanVien_MaNH]    Script Date: 05/03/2012 19:30:16 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_MaNH] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_MaNH]
GO
