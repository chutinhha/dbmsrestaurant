USE [QLNhaHang]
GO
/****** Object:  UserDefinedTableType [dbo].[TableType_ChiTietNCC]    Script Date: 05/20/2012 18:26:58 ******/
CREATE TYPE [dbo].[TableType_ChiTietNCC] AS TABLE(
	[MaNL] [int] NULL,
	[MaNCC] [int] NULL,
	[Gia] [float] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TableType_ChiTietDatHang]    Script Date: 05/20/2012 18:26:58 ******/
CREATE TYPE [dbo].[TableType_ChiTietDatHang] AS TABLE(
	[MaHoaDon] [int] NULL,
	[MaNL] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL
)
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 05/20/2012 18:26:48 ******/
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
/****** Object:  Table [dbo].[QLNguoiDung]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QLNguoiDung](
	[UserName] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'quanly', N'1', N'nmnghia@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'quantri', N'1', N'hatu@fit.hcmus.edu.vn')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'thukho', N'1', N'nmvu@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'thungan', N'1', N'trungtanbui@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'tieptan', N'1', N'nbngoc@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'tongquanly', N'1', N'tmvuong@gmail.cm')
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 05/20/2012 18:26:48 ******/
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
INSERT [dbo].[LoaiNV] ([MaLoai], [TenLoai], [Luong]) VALUES (N'7         ', N'Tổng quản lý', 8000000.0000)
/****** Object:  Table [dbo].[LoaiMonAn]    Script Date: 05/20/2012 18:26:48 ******/
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
/****** Object:  Table [dbo].[LoaiBan]    Script Date: 05/20/2012 18:26:48 ******/
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
/****** Object:  Table [dbo].[NhaHang]    Script Date: 05/20/2012 18:26:48 ******/
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
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 05/20/2012 18:26:48 ******/
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
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [sdt], [DiaChi], [DiemUuTien]) VALUES (7, N'Công ty TNHH Yến Sào Khánh Hoà', N'08.3865 5495', N'540 đường  3/2 Quận 10 Tp. HCM', 4)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [sdt], [DiaChi], [DiemUuTien]) VALUES (8, N'CTY TNHH Kinh doanh thực phẩm trực tuyến', N'08.3829.7342', N'174 Đinh Tiên Hoàng - Q.1 - TP.HCM', 3)
SET IDENTITY_INSERT [dbo].[NhaCungCap] OFF
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNL] [int] IDENTITY(1,1) NOT NULL,
	[MaNH] [nchar](10) NULL,
	[TenNL] [nvarchar](50) NULL,
	[DonVi] [nvarchar](20) NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_NguyenLieu] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (1, N'1         ', N'Bánh tráng', N'Chục', 52)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (2, N'2         ', N'Bánh tráng', N'Chục', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (3, N'3         ', N'Bánh tráng', N'Chục', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (4, N'1         ', N'Trứng cút', N'Trăm', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (5, N'2         ', N'Trứng cút', N'Trăm', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (6, N'3         ', N'Trứng cút', N'Trăm', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (7, N'2         ', N'Thịt bò', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (8, N'2         ', N'Hành tây', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (9, N'2         ', N'Mì sợi', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (10, N'1         ', N'Chem chép', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (11, N'1         ', N'Hào', N'Con', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (12, N'1         ', N'Nghêu', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (13, N'1         ', N'Ốc hương', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (14, N'3         ', N'Gà', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (15, N'1         ', N'Mực', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (16, N'3         ', N'Trứng vịt lộn', N'Trứng', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (17, N'3         ', N'Chim sẻ', N'Con', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (18, N'1         ', N'Cá kèo', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (19, N'1         ', N'Ếch', N'Con', 20)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (20, N'1         ', N'Cua', N'Kg', 53)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (21, N'1         ', N'Gạo', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (22, N'1         ', N'Cá diêu hồng', N'Kg', 52)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (23, N'1         ', N'Đậu phộng', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (24, N'2         ', N'Đậu phộng', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (25, N'3         ', N'Đậu phộng', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (26, N'1         ', N'Thuốc mèo', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (27, N'2         ', N'Thuốc mèo', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (28, N'3         ', N'Thuốc mèo', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (29, N'1         ', N'Bánh phồng', N'Chục', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (30, N'2         ', N'Bánh phồng', N'Chục', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (31, N'3         ', N'Bánh phồng', N'Chục', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (32, N'1         ', N'Đậu hũ', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (33, N'2         ', N'Đậu hũ', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (34, N'3         ', N'Đậu hũ', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (35, N'1         ', N'Hành, ngò, xả…', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (36, N'2         ', N'Hành, ngò, xả…', N'Kg ', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (37, N'3         ', N'Hành, ngò, xả…', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (38, N'1         ', N'Nấm', N'Kg ', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (39, N'2         ', N'Nấm', N'K', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (40, N'3         ', N'Nấm', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (41, N'1         ', N'Ốc móng tay', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (42, N'1         ', N'Sò huyết', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (43, N'1         ', N'Sò điệp', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (44, N'1         ', N'Mực ống', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (45, N'1         ', N'Tôm', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (46, N'1         ', N'Bún', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (47, N'2         ', N'Bún', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (48, N'3         ', N'Bún', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (49, N'1         ', N'Lươn', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (50, N'1         ', N'Mì', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (51, N'2         ', N'Mì', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (52, N'3         ', N'Mì', N'Kg', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (53, N'1         ', N'Bia 333', N'Lon', 52)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (54, N'2         ', N'Bia 333', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (55, N'3         ', N'Bia 333', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (56, N'1         ', N'Bia Heniken chai', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (57, N'2         ', N'Bia Heniken chai', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (58, N'3         ', N'Bia Heniken chai', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (59, N'1         ', N'Bia Heniken lon', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (60, N'2         ', N'Bia Heniken lon', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (61, N'3         ', N'Bia Heniken lon', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (62, N'1         ', N'Bia sài gòn đỏ', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (63, N'2         ', N'Bia sài gòn đỏ', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (64, N'3         ', N'Bia sài gòn đỏ', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (65, N'1         ', N'Bia Tiger', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (66, N'2         ', N'Bia Tiger', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (67, N'3         ', N'Bia Tiger', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (69, N'2         ', N'7 UP', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (70, N'3         ', N'7 UP', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (71, N'1         ', N'Cam ép', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (72, N'2         ', N'Cam ép', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (73, N'3         ', N'Cam ép', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (74, N'1         ', N'Coca cola', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (75, N'2         ', N'Coca cola', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (76, N'3         ', N'Coca cola', N'Lon', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (77, N'1         ', N'Nước suối', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (78, N'2         ', N'Nước suối', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (79, N'3         ', N'Nước suối', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (80, N'1         ', N'Sting dau', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (81, N'2         ', N'Sting dau', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (82, N'3         ', N'Sting dau', N'Chai', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (83, N'1         ', N'Thuốc 333', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (84, N'2         ', N'Thuốc 333', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (85, N'3         ', N'Thuốc 333', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (86, N'1         ', N'Thuốc JET', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (87, N'2         ', N'Thuốc JET', N'Gói', 51)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [DonVi], [SoLuongTon]) VALUES (88, N'3         ', N'Thuốc JET', N'Gói', 51)
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
/****** Object:  Table [dbo].[MonAn]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonAn](
	[MaMon] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](30) NULL,
	[LoaiMon] [nchar](10) NULL,
	[Gia] [float] NULL,
	[DonViTinh] [nchar](10) NULL,
	[MaNH] [nchar](10) NULL,
 CONSTRAINT [PK__MonAn__3A5B29A807020F21] PRIMARY KEY CLUSTERED 
(
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MonAn] ON
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (1, N'Bánh tráng nướng', N'KV        ', 8000, N'Cái       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (2, N'Đậu phộng rang', N'KV        ', 10000, N'Gói       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (3, N'Trứng cút luộc', N'KV        ', 12000, N'Chục      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (4, N'Đậu hũ chiên xả', N'KV        ', 28000, N'Đĩa       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (5, N'Bò lúc lắc', N'MonBo     ', 58000, N'Đĩa       ', N'2         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (6, N'Bò Xào Hành Tây', N'MonBo     ', 50000, N'Đĩa       ', N'2         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (7, N'Hủ tiếu - mì bò kho', N'MonBo     ', 18000, N'Tô        ', N'2         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (9, N'Chem chép', N'NgheuSo   ', 35000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (10, N'Hào sống', N'NgheuSo   ', 18000, N'Con       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (11, N'Nghêu', N'NgheuSo   ', 29000, N'Thố       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (12, N'Ốc hương', N'NgheuSo   ', 25000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (13, N'Ốc móng tay', N'NgheuSo   ', 40000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (16, N'Sò huyết', N'NgheuSo   ', 29000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (17, N'Sò điệp', N'NgheuSo   ', 39000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (18, N'Cánh gà', N'GaCuaGhe  ', 39000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (19, N'Chân gà', N'GaCuaGhe  ', 13000, N'Cặp       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (20, N'Khô mực', N'GaCuaGhe  ', 55000, N'Con       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (21, N'Trứng vịt lộn', N'GaCuaGhe  ', 10000, N'Trứng     ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (22, N'Chim sẻ', N'GaCuaGhe  ', 39000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (23, N'Cá kèo', N'HS        ', 39000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (24, N'Ếch', N'HS        ', 21000, N'Con       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (25, N'Mực ống', N'HS        ', 44000, N'Đĩa       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (26, N'Tôm càng xanh', N'HS        ', 20000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (27, N'Tôm sú', N'HS        ', 30000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (28, N'Cua gạch', N'HS        ', 20000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (29, N'Cua thịt', N'HS        ', 25000, N'Lạng      ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (31, N'Bún thêm', N'Com       ', 6000, N'Đĩa       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (32, N'Cháo', N'Com       ', 40000, N'Thố       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (33, N'Cơm chiên', N'Com       ', 50000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (34, N'Lẩu cá diêu hồng', N'Com       ', 80000, N'Cái       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (36, N'Lẩu lươn', N'Com       ', 85000, N'Cái       ', N'1         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (37, N'Mì xào', N'Com       ', 50000, N'Đĩa       ', N'3         ')
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (38, N'Bia 333', N'Bia       ', 11000, N'Lon       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (39, N'Bia Heniken chai', N'Bia       ', 16000, N'Ly        ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (40, N'Bia Heniken lon', N'Bia       ', 18000, N'Lon       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (41, N'Bia sài gòn đỏ', N'Bia       ', 9000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (42, N'Bia Tiger', N'Bia       ', 15000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (43, N'7 UP', N'NN        ', 8000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (44, N'Cam ép', N'NN        ', 9000, N'Lon       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (45, N'Coca cola', N'NN        ', 7000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (46, N'Nước suối', N'NN        ', 6000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (47, N'Sting dau', N'NN        ', 10000, N'Chai      ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (48, N'Thuốc 333', N'TL        ', 35000, N'Gói       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (49, N'Thuốc JET', N'TL        ', 20000, N'Gói       ', NULL)
INSERT [dbo].[MonAn] ([MaMon], [TenMon], [LoaiMon], [Gia], [DonViTinh], [MaNH]) VALUES (50, N'Thuốc mèo', N'TL        ', 20000, N'Gói       ', NULL)
SET IDENTITY_INSERT [dbo].[MonAn] OFF
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 05/20/2012 18:26:48 ******/
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
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (1, N'Sảnh – tầng trệt', N'Giữa đại sảnh của nhà hang', N'1         ')
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (2, N'Góc – tầng trệt', N'Nằm ở góc', N'1         ')
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (3, N'Sát tường - tầng trệt', N'Sát tường, nhìn ra bên ngoài', N'1         ')
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (4, N'Lầu 1', N'Lầu 1', N'1         ')
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (5, N'Lầu 2', N'Lầu 2', N'1         ')
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [ViTri], [MaNH]) VALUES (6, N'Sân thượng', N'Sân thượng', N'1         ')
/****** Object:  Table [dbo].[DatHang]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaNCC] [int] NOT NULL,
	[MaNH] [nchar](10) NULL,
	[TongTien] [float] NULL,
	[ThoiGianDat] [datetime] NULL,
	[ThoiGianGiao] [datetime] NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_DatHang] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DatHang] ON
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (2, 6, N'1         ', 98000, CAST(0x0000A05700D2735F AS DateTime), CAST(0x0000A05400A62E94 AS DateTime), N'Chưa Giao')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (3, 7, N'1         ', 81500, CAST(0x0000A04E00A64F64 AS DateTime), CAST(0x0000A04E00A64604 AS DateTime), N'Hủy')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (4, 8, N'1         ', 129000, CAST(0x0000A04E00A65E92 AS DateTime), CAST(0x0000A05900A65515 AS DateTime), N'Chưa Giao')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (7, 7, N'1         ', 56000, CAST(0x0000A05700D0B334 AS DateTime), CAST(0x0000A04F003C5FDC AS DateTime), N'Đã Giao')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (19, 6, N'1         ', 40000, CAST(0x0000A04F0109F770 AS DateTime), CAST(0x0000A04F0109F493 AS DateTime), N'Đã Giao')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (24, 7, N'1         ', 51500, CAST(0x0000A0560152D942 AS DateTime), CAST(0x0000A0560152B756 AS DateTime), N'Chưa Giao')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (25, 1, N'1         ', 20000, CAST(0x0000A056015C76F8 AS DateTime), CAST(0x0000A056015C7156 AS DateTime), N'Đã Giao')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (26, 5, N'1         ', 12000, CAST(0x0000A057000445DD AS DateTime), CAST(0x0000A05700044215 AS DateTime), N'Đã Giao')
INSERT [dbo].[DatHang] ([MaHoaDon], [MaNCC], [MaNH], [TongTien], [ThoiGianDat], [ThoiGianGiao], [TinhTrang]) VALUES (27, 7, N'1         ', 10000, CAST(0x0000A0570004571D AS DateTime), CAST(0x0000A0570004533B AS DateTime), N'Đã Giao')
SET IDENTITY_INSERT [dbo].[DatHang] OFF
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/20/2012 18:26:48 ******/
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
	[Username] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (1, N'Nguyễn Bá Ngọc', N'1         ', N'3         ', 123456789, 936214587, N'tieptan')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (2, N'Nguyễn Minh Vũ', N'1         ', N'2         ', 321654987, 963258774, N'thukho')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (3, N'Bùi Trung Tân', N'1         ', N'4         ', 271955488, 936786110, N'thungan')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (4, N'Nguyễn Minh Nghĩa', N'1         ', N'1         ', 321654874, 978541231, N'quanly')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (5, N'Hoàng Anh Tú', N'4         ', N'6         ', 214547874, 905214533, N'quantri')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (6, N'Trần Minh Vương', N'1         ', N'7         ', 963258741, 936521447, N'tongquanly')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (7, N'Nguyễn Bảo Thanh Thanh', N'1         ', N'4         ', 741214754, 984125631, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
/****** Object:  StoredProcedure [dbo].[sp_SelectUser]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SelectUser] @username nvarchar(50), @pass nvarchar(50), @kq int out
as
begin
	SET @kq = (SELECT COUNT(*) FROM QLNguoiDung WHERE UserName = @username AND Pass = @pass)
end
/*declare @kq int
exec sp_SelectUser 'trungtan', '123654', @kq out
print @kq + 3*/
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNhaCungCap]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------- table NhaCungCap -----------------------------------------------------------
-- lay danh sach nha cung cap
-------------------------------------------------------------------------
create proc [dbo].[SPoV_SelectNhaCungCap]
as
begin
    begin tran
    set transaction isolation level read uncommitted
    select *
    from   NhaCungCap
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------- Table Nguyen Lieu -----------------------------------------------------------------
--- Lay danh sach nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_FIX_SelectNguyenLieu] 
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
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateNguyenLieu]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- cap nhat thong tin mot nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_UpdateNguyenLieu] 
	@Flag int out,
	@MaNL int,
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
    if ( (select count(*)
          from   NguyenLieu
          where  MaNL = @MaNL)=1)
    begin
        --waitfor delay '00:00:06'
        update NguyenLieu
        set    MaNH = @MaNH
              ,TenNL = @TenNL
              ,DonVi = @Donvi
              ,SoLuongTon = @SoLuongTon
        where  MaNL = @MaNL
      -- waitfor delay '00:00:04'
       if ((select count(*)
            from   NguyenLieu
            where  TenNL = @TenNL
                   and DonVi = @DonVi
                   and MaNH = @MaNH)<>1)
        begin
            rollback tran
            return
        end
    end
    if (@@error<>0)
    begin
        rollback tran
        return
    end  
    set @Flag = 1 
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_InsertNguyenLieu]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- Them nguyen lieu moi
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_InsertNguyenLieu] 
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
    --waitfor delay '00:00:05'		
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
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------- Table Nguyen Lieu -----------------------------------------------------------------
--- Lay danh sach nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu] 
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select *
    from   NguyenLieu nl
    where  nl.MaNH = @MaNH
    order by
           nl.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectDatHang_TinhTrang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_SelectDatHang_TinhTrang]  
	@MaNH nchar(10),
	@TinhTrang nvarchar(50)
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	select dh.*
	      ,ncc.TenNCC
	from   DatHang dh
	      ,NhaCungCap ncc
	where  MaNH = @MaNH
	       and dh.MaNCC = ncc.MaNCC
	       and dh.TinhTrang = @TinhTrang
	       
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--GO
--------------- table DatHang -------------------------------------------------------------------------

-- Slect đơn đặt hàng theo Mã Nhà Hàng
----------------------------------------------------------------
create proc [dbo].[SPoV_SelectDatHang]  
	@MaNH nchar(10)
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	select dh.*,ncc.TenNCC from DatHang dh,NhaCungCap ncc 
	where MaNH = @MaNH and dh.MaNCC = ncc.MaNCC
		
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_InsertNguyenLieu]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- Them nguyen lieu moi
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_Delay_InsertNguyenLieu]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectNhanVien]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SelectNhanVien] @username nvarchar(50)
as
begin
	SELECT * FROM NhanVien WHERE Username = @username
end
GO
/****** Object:  Table [dbo].[ChiTietDatHang]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDatHang](
	[MaHoaDon] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_ChiTietDatHang] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaNL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (2, 22, 20, 1000000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (3, 44, 1, 30000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (3, 46, 1, 5500)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (3, 56, 1, 12000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (3, 59, 1, 10000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (3, 62, 1, 15000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (3, 65, 1, 9000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (4, 20, 1, 40000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (4, 38, 1, 20000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (4, 43, 1, 60000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (4, 86, 1, 9000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (7, 1, 1, 8000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (19, 20, 1, 40000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (24, 44, 1, 30000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (24, 46, 1, 5500)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (24, 59, 1, 10000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (24, 71, 1, 6000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (25, 20, 1, 20000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (26, 53, 1, 12000)
INSERT [dbo].[ChiTietDatHang] ([MaHoaDon], [MaNL], [SoLuong], [ThanhTien]) VALUES (27, 53, 1, 10000)
/****** Object:  Table [dbo].[BanAn]    Script Date: 05/20/2012 18:26:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanAn](
	[MaBan] [int] IDENTITY(1,1) NOT NULL,
	[MaKhuVuc] [int] NULL,
	[LoaiBan] [nchar](10) NULL,
	[MaNH] [nchar](10) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK__BanAn__3520ED6C1A14E395] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BanAn] ON
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (1, 1, N'4         ', N'1         ', 1)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (2, 2, N'3         ', N'1         ', 0)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (3, 6, N'2         ', N'1         ', 0)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (4, 4, N'2         ', N'2         ', 1)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (5, 1, N'2         ', N'2         ', 1)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (6, 1, N'3         ', N'1         ', 1)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (7, 3, N'4         ', N'1         ', 1)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (8, 5, N'5         ', N'1         ', 0)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (9, 2, N'3         ', N'1         ', 1)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (10, 4, N'4         ', N'2         ', 0)
INSERT [dbo].[BanAn] ([MaBan], [MaKhuVuc], [LoaiBan], [MaNH], [TrangThai]) VALUES (11, 1, N'5         ', N'1         ', 0)
SET IDENTITY_INSERT [dbo].[BanAn] OFF
/****** Object:  Table [dbo].[ChiTietNCC]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNCC](
	[MaNL] [int] NOT NULL,
	[MaNCC] [int] NOT NULL,
	[Gia] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC,
	[MaNCC] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (1, 6, 20)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (1, 7, 8000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (10, 5, 30000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (12, 8, 70000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (13, 1, 0)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (20, 1, 20000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (20, 6, 40000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (20, 8, 40000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (21, 1, 0)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (22, 5, 50000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (22, 6, 50000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (23, 1, 5000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (23, 5, 30000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (32, 1, 5000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (32, 5, 10000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (38, 8, 20000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (43, 8, 60000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (44, 7, 30000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (46, 5, 6000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (46, 6, 6000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (46, 7, 5500)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (49, 5, 80000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (53, 5, 12000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (53, 7, 10000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (56, 6, 10000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (56, 7, 12000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (59, 7, 10000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (62, 7, 15000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (65, 7, 9000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (71, 5, 5000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (71, 7, 6000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (71, 8, 9000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (74, 5, 7000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (74, 8, 7000)
INSERT [dbo].[ChiTietNCC] ([MaNL], [MaNCC], [Gia]) VALUES (86, 8, 9000)
/****** Object:  Table [dbo].[ChiTietMonAn]    Script Date: 05/20/2012 18:26:48 ******/
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
/****** Object:  Table [dbo].[DatBan]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatBan](
	[MaNH] [nchar](10) NOT NULL,
	[MaBan] [int] NOT NULL,
	[maKhachHang] [int] NULL,
	[ThoiGianDat] [datetime] NULL,
	[TrangThai] [int] NOT NULL,
	[ThoiGianDen] [datetime] NOT NULL,
	[Sdt] [int] NULL,
 CONSTRAINT [PK__DatBan__46E29EED276EDEB3] PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC,
	[MaBan] ASC,
	[TrangThai] ASC,
	[ThoiGianDen] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DatBan] ([MaNH], [MaBan], [maKhachHang], [ThoiGianDat], [TrangThai], [ThoiGianDen], [Sdt]) VALUES (N'1         ', 1, 123654789, CAST(0x0000A00B00000000 AS DateTime), 1, CAST(0x0000A0E100000000 AS DateTime), NULL)
/****** Object:  Table [dbo].[HoaDon]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[TongTien] [float] NULL,
	[ThoiGianLap] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[MaNV] [int] NULL,
	[MaBan] [int] NULL,
 CONSTRAINT [PK__HoaDon__2725A6E01BFD2C07] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON
INSERT [dbo].[HoaDon] ([MaHD], [TongTien], [ThoiGianLap], [ThoiGianKetThuc], [MaNV], [MaBan]) VALUES (1, 1390000, CAST(0x0000A00B0128A180 AS DateTime), CAST(0x0000A00B0172C9E0 AS DateTime), 7, 2)
INSERT [dbo].[HoaDon] ([MaHD], [TongTien], [ThoiGianLap], [ThoiGianKetThuc], [MaNV], [MaBan]) VALUES (2, 0, CAST(0x0000A00B0128A180 AS DateTime), CAST(0x0000A00B0128A180 AS DateTime), 7, 1)
INSERT [dbo].[HoaDon] ([MaHD], [TongTien], [ThoiGianLap], [ThoiGianKetThuc], [MaNV], [MaBan]) VALUES (3, 0, CAST(0x0000A00B0128A180 AS DateTime), CAST(0x0000A00B0128A180 AS DateTime), 3, 6)
INSERT [dbo].[HoaDon] ([MaHD], [TongTien], [ThoiGianLap], [ThoiGianKetThuc], [MaNV], [MaBan]) VALUES (4, 0, CAST(0x0000A00B0128A180 AS DateTime), CAST(0x0000A00B0128A180 AS DateTime), 7, 9)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteChiTietNCC_fromNCC]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeleteChiTietNCC_fromNCC] 
	@MaNCC int
as
begin
    begin tran
	set transaction isolation level 
	read uncommitted
	
	delete ChiTietNCC
	where  MaNCC = @MaNCC
		   
	if(@@error<>0)
    begin
        rollback
        return
    end 
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteChiTietDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Delete chi tiết đặt hàng theo Mã Hóa Đơn
-----------------------------------------------------------------
create proc [dbo].[SPoV_DeleteChiTietDatHang]  
	@MaHoaDon int
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	delete ChiTietDatHang
	where MaHoaDon=@MaHoaDon
	
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_Delay_UpdateTinhTrangDatHang]
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
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeadLock_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeadLock_UpdateTinhTrangDatHang]
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
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteNguyenLieu]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- xoa nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_DeleteNguyenLieu]  
	@Flag int out,
	@MaNL int,
	@MaNH nchar(10)
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    if ((select count(*)
         from   NguyenLieu
         where  MaNL = @MaNL)=1 )
    begin
        if (( select count(*)
              from   ChiTietNCC
              where  MaNL = @MaNL)=1
              or ( select count(*)
                   from   ChiTietDatHang
                   where  MaNL = @MaNL )=1)
        begin
            set @Flag = -1
            rollback tran
            return
        end
        
        delete 
        from   NguyenLieu
        where  MaNL = @MaNL
               and MaNH = @MaNH
    end
    
    if (@@ERROR<>0)
    begin
        rollback tran
        return
    end
    
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectChiTietDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------- table ChiTietDatHang --------------------------------------------------------------------

-- Select chi tiết đặt hàng theo Mã Hóa Đơn
---------------------------------------------------------------
create proc [dbo].[SPoV_SelectChiTietDatHang] 
	@MaHoaDon int
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	select ct.*,nl.TenNL,nl.DonVi
	from ChiTietDatHang ct,NguyenLieu nl
	where MaHoaDon = @MaHoaDon and ct.MaNL = nl.MaNL
	
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_InsertNhaCungCap]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- them nha cung cap moi dong thoi them chi tiet nha cung cap
---------------------------------------------------------------------------------------
create proc [dbo].[SPoV_InsertNhaCungCap] 
	@MaNCC int out,
	@TenNCC nvarchar(50),
	@sdt nvarchar(50),
	@DiaChi nvarchar(50),
	@DiemUuTien int,
	@ChiTiet TableType_ChiTietNCC readonly
as
begin
    set @MaNCC = -1
    begin tran
    set transaction isolation level 
    read uncommitted

    --Insert Nha Cung Cap
    insert into NhaCungCap
    values
      (
        @TenNCC
       ,@sdt
       ,@DiaChi
       ,@DiemUuTien
      )
    set @MaNCC = (select scope_identity())
    --waitfor delay '00:00:05'
	if ((select count(*)from NhaCungCap
		 where TenNCC = @TenNCC)<>1)
	begin
		set @MaNCC = -1
		rollback tran
		return
	end
    
    if (@@ERROR<>0)
    begin
        set @MaNCC = -1
        rollback
        return
    end
    
    --Insert Chi Tiet NCC
    insert into ChiTietNCC
    select MaNL
          ,MaNCC = @MaNCC
          ,Gia
    from   @ChiTiet
    
    if (@@ERROR<>0)
    begin
        set @MaNCC = -1
        rollback
        return
    end
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_InsertDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_InsertDatHang]  
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
    set transaction isolation level 
    read uncommitted
    --Insert Nha Cung Cap
    insert into DatHang
    values
      (
        @MaNCC
       ,@MaNH
       ,@TongTien
       ,@ThoiGianDat
       ,@ThoiGianGiao
       ,@TinhTrang
      )
    	
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
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SPoV_FIX_UpdateTinhTrangDatHang]
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
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NotIn_NCC]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu nha cung cap khong co
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu_NotIn_NCC] 
	@MaNCC int ,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select *
    from   NguyenLieu nl1
    where  nl1.MaNH = @MaNH
           and nl1.MaNL not in 
           (select nl.MaNL
            from   NguyenLieu nl
                  ,ChiTietNCC ct
            where  ct.MaNCC = @MaNCC
                   and nl.MaNH = @MaNH
                   and nl.MaNL = ct.MaNL)
    order by nl1.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NotIn_DatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---lay danh sach nguyen lieu cua nha cung cap
---khong co trong don dat hang voi nha cung cap do
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu_NotIn_DatHang] 
	@MaHoaDon int,
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select nl1.*
          ,ctncc.Gia
    from   NguyenLieu nl1
          ,ChiTietNCC ctncc
    where  nl1.MaNL = ctncc.MaNL
           and nl1.MaNH = @MaNH
           and ctncc.MaNCC = @MaNCC
           and nl1.MaNL not in 
           (select nl.MaNL
            from   NguyenLieu nl
                  ,ChiTietDatHang ct
            where  nl.MaNL = ct.MaNL
                   and ct.MaHoaDon = @MaHoaDon
                   and nl.MaNH = @MaNH)
    order by
           nl1.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_UpdateDatHang] 
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
    set transaction isolation level 
    read uncommitted
    
    if(( select count(*)
         from   DatHang
         where  MaHoaDon = @MaHoaDon )<>0)
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
                      and ct.MaNL not in (
                      	select MaNL
                        from   @ChiTiet))
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end      
        --cap nhat so luong va thanh tien cho nguyen lieu
        --dong thoi them nguyen lieu vua cap nhat trong don dat hang
        declare @manl int,
				@soluong int,
				@thanhtien int
		declare @cur cursor 
		set @cur =  cursor for 
		select MaNL
		      ,SoLuong
		      ,ThanhTien
		from   @ChiTiet
		
		open @cur
		fetch next from @cur into @manl,@soluong,@thanhtien
		while @@FETCH_STATUS=0
		begin
			if(exists(select * from ChiTietDatHang 
					  where MaHoaDon = @MaHoaDon 
					  and MaNL = @manl))
			begin
				update ChiTietDatHang set 
					SoLuong = @soluong,
					ThanhTien = @thanhtien 
				where MaNL = @manl 
				and MaHoaDon = @MaHoaDon
			end
			else
				insert into ChiTietDatHang
				values
				  (
				    @MaHoaDon
				   ,@manl
				   ,@soluong
				   ,@thanhtien
				  ) 
				
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end               
			fetch next from @cur into @manl,@soluong,@thanhtien
		end                     
    end
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateChiTietNCC]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------- table ChiTietNCC ---------------------------------------------------------

-------------------------------------------------------------------------
--create proc InsertChiTietNCC @MaNL int,@MaNCC int ,@Gia float
--as
--begin
--    insert into ChiTietNCC
--    values
--      (
--        @MaNL
--       ,@MaNCC
--       ,@Gia
--      )
--end
--go
-- cap nhat gia nguyen nguyen lieu cua nha cung cap
-------------------------------------------------------------------------
create proc [dbo].[SPoV_UpdateChiTietNCC] 
	@Flag int out,
	@MaNL int,
	@MaNCC int ,
	@Gia float
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    if((select count(*)
        from   ChiTietNCC
        where  MaNL = @MaNL
               and MaNCC = @MaNCC)=0)
    begin
        rollback tran
        return
    end
    
    --waitfor delay '00:00:06'
    update ChiTietNCC
    set    Gia = @Gia
    where  MaNL = @MaNL
           and MaNCC = @MaNCC
    
    --waitfor delay '00:00:03'
    if (@@error<>0)
    begin
        rollback tran
        return
    end
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNhaCungCap_fromNH]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Select nhung nha cung cap , co cung cap nguyen lieu cho nha hang dang xet
create proc [dbo].[SPoV_SelectNhaCungCap_fromNH] 
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted

	select distinct ncc.*
	from   NhaCungCap ncc
		  ,ChiTietNCC ct
		  ,NguyenLieu nl
	where  ncc.MaNCC = ct.MaNCC
		   and nl.MaNL = ct.MaNL
		   and NL.MANH = @MaNH
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_In_NCC]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua mot nha cung cap
------------------------------------------------------------------------------------- 
create  proc [dbo].[SPoV_SelectNguyenLieu_In_NCC] 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select nl.*
          ,ct.Gia
    from   NhaCungCap ncc
          ,ChiTietNCC ct
          ,NguyenLieu nl
    where  ct.MaNCC = @MaNCC
           and nl.MaNH = @MaNH
           and ct.MaNL = nl.MaNL
           and ct.MaNCC = ncc.MaNCC
    order by nl.TenNL
    --SET  @Count = @@ROWCOUNT
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_In_DatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua mot nha cung cap
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu_In_DatHang] 
	@MaHoaDon int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select nl.*
          ,ct.SoLuong
          ,ct.ThanhTien
    from   DatHang dh
          ,ChiTietDatHang ct
          ,NguyenLieu nl
    where  ct.MaHoaDon = @MaHoaDon
           and nl.MaNH = @MaNH
           and ct.MaNL = nl.MaNL
           and ct.MaHoaDon = dh.MaHoaDon
    order by
           nl.TenNL
    --SET  @Count = @@ROWCOUNT
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_UpdateTinhTrangDatHang]
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
			--waitfor delay '00:00:06'                  
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
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateNhaCungCap]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_UpdateNhaCungCap] 
	@Flag int out,
	@MaNCC int,
	@TenNCC nvarchar(50),
	@sdt nvarchar(50),
	@DiaChi nvarchar(50),
	@DiemUuTien int,
	@ChiTiet TableType_ChiTietNCC readonly
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    
    if(( select count(*) from  NhaCungCap 
         where  MaNCC = @MaNCC )<>0)
    begin
    	-- waitfor delay '00:00:06'
        update NhaCungCap
        set    TenNCC = @TenNCC
              ,sdt = @sdt
              ,DiaChi = @DiaChi
              ,DiemUuTien = @DiemUuTien
        where  MaNCC = @MaNCC
         --waitfor delay '00:00:04'
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end
        
        --Xoa nguyen lieu da bi mat trong danh sach
        delete ChiTietNCC
        where  MaNCC = @MaNCC
               and MaNL in 
              (select ctn.MaNL
               from   ChiTietNCC ctn
               where  ctn.MaNCC = @MaNCC
                      and ctn.MaNL not in 
                      (select MaNL
                       from   @ChiTiet))
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end                                           
        --Them cac nguyen lieu moi cap nhat
        insert into ChiTietNCC
        select ct.MaNL
              ,ct.MaNCC
              ,ct.Gia
        from   @ChiTiet ct
        where  ct.MaNL not in 
			  (select ctn.MaNL
			   from   ChiTietNCC ctn
			   where  ctn.MaNCC = @MaNCC)
                            
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end                      
    end
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteNhaCungCap]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeleteNhaCungCap] 
	@Flag int out,
	@MaNCC int
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	read uncommitted
	
	exec SPoV_DeleteChiTietNCC_fromNCC @MaNCC
	if(@@ERROR<>0)
    begin
        rollback
        return
    end 
    
	delete NhaCungCap
	where  MaNCC = @MaNCC
	
	if(@@ERROR<>0)
    begin
        rollback
        return
    end 
    set @Flag = 1  
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_DatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_SelectNguyenLieu_DatHang] 
	@MaHoaDon int,
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted   
    exec SPoV_SelectNguyenLieu_NotIn_DatHang 
		@MaHoaDon,@MaNCC,
		@MaNH
    --waitfor delay '00:00:05'
    exec SPoV_SelectNguyenLieu_In_DatHang 
		@MaHoaDon,
		@MaNH
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NCC]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua nha cung cap
--- va danh sanh nguyen lieu nha cung cap khong co
-------------------------------------------------------------------------------------
create proc [dbo].[SPoV_SelectNguyenLieu_NCC] 
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
    --waitfor delay '00:00:05'
    exec SPoV_SelectNguyenLieu_NotIn_NCC 
		@MaNCC
		,@MaNH
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu_NCC]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SPoV_FIX_SelectNguyenLieu_NCC] 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    repeatable read
    exec SPoV_SelectNguyenLieu_In_NCC 
		@MaNCC
        ,@MaNH
    waitfor delay '00:00:05'
    exec SPoV_SelectNguyenLieu_NotIn_NCC 
		@MaNCC
		,@MaNH
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteDatHang]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeleteDatHang] 
	@Flag int out,
	@MaHoaDon int
as
begin	
	set @Flag = 0
	begin tran
	set transaction isolation level 
	read uncommitted

	exec SPoV_DeleteChiTietDatHang 
		@MaHoaDon
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
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_SelectNguyenLieu_NCC]    Script Date: 05/20/2012 18:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua nha cung cap
--- va danh sanh nguyen lieu nha cung cap khong co
-------------------------------------------------------------------------------------
create proc [dbo].[SPoV_Delay_SelectNguyenLieu_NCC] 
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
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 05/20/2012 18:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [int] NOT NULL,
	[MaMon] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK__ChiTietH__B480147A1FCDBCEB] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (1, 1, 3, 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (1, 9, 1, 35000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (1, 34, 1, 80000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (2, 34, 1, 80000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (2, 39, 2, 32000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (2, 41, 2, 18000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (3, 3, 2, 24000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (3, 25, 1, 44000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (3, 41, 3, 27000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (4, 12, 1, 25000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (4, 13, 1, 40000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMon], [SoLuong], [ThanhTien]) VALUES (4, 39, 2, 16000)
/****** Object:  Default [DF__BanAn__TrangThai__1BFD2C07]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[BanAn] ADD  CONSTRAINT [DF__BanAn__TrangThai__1BFD2C07]  DEFAULT ((0)) FOR [TrangThai]
GO
/****** Object:  ForeignKey [FK_BanAn_KhuVuc]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[BanAn]  WITH CHECK ADD  CONSTRAINT [FK_BanAn_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[BanAn] CHECK CONSTRAINT [FK_BanAn_KhuVuc]
GO
/****** Object:  ForeignKey [FK_BanAn_LoaiBan]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[BanAn]  WITH CHECK ADD  CONSTRAINT [FK_BanAn_LoaiBan] FOREIGN KEY([LoaiBan])
REFERENCES [dbo].[LoaiBan] ([Maloai])
GO
ALTER TABLE [dbo].[BanAn] CHECK CONSTRAINT [FK_BanAn_LoaiBan]
GO
/****** Object:  ForeignKey [FK_ChiTietDatHang_DatHang]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[ChiTietDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatHang_DatHang] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[DatHang] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietDatHang] CHECK CONSTRAINT [FK_ChiTietDatHang_DatHang]
GO
/****** Object:  ForeignKey [FK_ChiTietDatHang_NguyenLieu]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[ChiTietDatHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDatHang_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[ChiTietDatHang] CHECK CONSTRAINT [FK_ChiTietDatHang_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_HoaDon]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
/****** Object:  ForeignKey [FK_ChiTietHoaDon_MonAn]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_MonAn] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAn] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_MonAn]
GO
/****** Object:  ForeignKey [FK_ChiTietMonAn_MonAn]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[ChiTietMonAn]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietMonAn_MonAn] FOREIGN KEY([MaMon])
REFERENCES [dbo].[MonAn] ([MaMon])
GO
ALTER TABLE [dbo].[ChiTietMonAn] CHECK CONSTRAINT [FK_ChiTietMonAn_MonAn]
GO
/****** Object:  ForeignKey [FK_ChiTietNCC_NguyenLieu]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[ChiTietNCC]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNCC_NguyenLieu] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NguyenLieu] ([MaNL])
GO
ALTER TABLE [dbo].[ChiTietNCC] CHECK CONSTRAINT [FK_ChiTietNCC_NguyenLieu]
GO
/****** Object:  ForeignKey [FK_ChiTietNCC_NhaCungCap]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[ChiTietNCC]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietNCC_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[ChiTietNCC] CHECK CONSTRAINT [FK_ChiTietNCC_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_DatBan_BanAn]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[DatBan]  WITH CHECK ADD  CONSTRAINT [FK_DatBan_BanAn] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BanAn] ([MaBan])
GO
ALTER TABLE [dbo].[DatBan] CHECK CONSTRAINT [FK_DatBan_BanAn]
GO
/****** Object:  ForeignKey [FK_DatBan_NhaHang]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[DatBan]  WITH CHECK ADD  CONSTRAINT [FK_DatBan_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[DatBan] CHECK CONSTRAINT [FK_DatBan_NhaHang]
GO
/****** Object:  ForeignKey [FK_DatHang_NhaCungCap]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_DatHang_NhaHang]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[DatHang]  WITH CHECK ADD  CONSTRAINT [FK_DatHang_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[DatHang] CHECK CONSTRAINT [FK_DatHang_NhaHang]
GO
/****** Object:  ForeignKey [FK_HoaDon_BanAn]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_BanAn] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BanAn] ([MaBan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_BanAn]
GO
/****** Object:  ForeignKey [FK_KhuVuc_NhaHang]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[KhuVuc]  WITH CHECK ADD  CONSTRAINT [FK_KhuVuc_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[KhuVuc] CHECK CONSTRAINT [FK_KhuVuc_NhaHang]
GO
/****** Object:  ForeignKey [FK_MonAn_LoaiMonAn]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_LoaiMonAn] FOREIGN KEY([LoaiMon])
REFERENCES [dbo].[LoaiMonAn] ([MaLoai])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_LoaiMonAn]
GO
/****** Object:  ForeignKey [FK_MonAn_NhaHang]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[MonAn]  WITH CHECK ADD  CONSTRAINT [FK_MonAn_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[MonAn] CHECK CONSTRAINT [FK_MonAn_NhaHang]
GO
/****** Object:  ForeignKey [FK_NguyenLieu_NhaHang]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[NguyenLieu]  WITH CHECK ADD  CONSTRAINT [FK_NguyenLieu_NhaHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[NguyenLieu] CHECK CONSTRAINT [FK_NguyenLieu_NhaHang]
GO
/****** Object:  ForeignKey [FK_NhanVien_LoaiNV]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNV] FOREIGN KEY([Maloai])
REFERENCES [dbo].[LoaiNV] ([MaLoai])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNV]
GO
/****** Object:  ForeignKey [FK_NhanVien_MaNH]    Script Date: 05/20/2012 18:26:48 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_MaNH] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_MaNH]
GO
