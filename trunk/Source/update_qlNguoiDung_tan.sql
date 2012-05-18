USE [QLNhaHang]
GO
/****** Object:  Table [dbo].[QLNguoiDung]    Script Date: 05/18/2012 12:58:37 ******/
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
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'hatu', N'qwerty', N'hatu@fit.hcmus.edu.vn')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'Nbngoc', N'asdf1234', N'nbngoc@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'Ngvu', N'asdffdsa', N'nmvu@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'nmnghia', N'123456', N'nmnghia@gmail.com')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'tmvuong', N'123456', N'tmvuong@gmail.cm')
INSERT [dbo].[QLNguoiDung] ([UserName], [Pass], [Email]) VALUES (N'trungtan', N'123654', N'trungtanbui@gmail.com')
/****** Object:  Table [dbo].[LoaiNV]    Script Date: 05/18/2012 12:58:37 ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 05/18/2012 12:58:37 ******/
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
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (1, N'Nguyễn Bá Ngọc', N'1         ', N'3         ', 123456789, 936214587, N'Nbngoc')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (2, N'Nguyễn Minh Vũ', N'1         ', N'2         ', 321654987, 963258774, N'Ngvu')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (3, N'Bùi Trung Tân', N'1         ', N'4         ', 271955488, 936786110, N'trungtan')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (4, N'Nguyễn Minh Nghĩa', N'1         ', N'1         ', 321654874, 978541231, N'nmnghia')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (5, N'Hoàng Anh Tú', N'4         ', N'6         ', 214547874, 905214533, N'hatu')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (6, N'Trần Minh Vương', N'1         ', N'7         ', 963258741, 936521447, N'tmvuong')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaNH], [Maloai], [cmnd], [sdt], [Username]) VALUES (7, N'Nguyễn Bảo Thanh Thanh', N'1         ', N'4         ', 741214754, 984125631, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
/****** Object:  ForeignKey [FK_NhanVien_LoaiNV]    Script Date: 05/18/2012 12:58:37 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_LoaiNV] FOREIGN KEY([Maloai])
REFERENCES [dbo].[LoaiNV] ([MaLoai])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_LoaiNV]
GO
/****** Object:  ForeignKey [FK_NhanVien_MaNH]    Script Date: 05/18/2012 12:58:37 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_MaNH] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhaHang] ([MaNH])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_MaNH]
GO
