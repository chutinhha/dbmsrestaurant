USE [QLNhaHang]
GO
/****** Object:  UserDefinedTableType [dbo].[TableType_ChiTietDatHang]    Script Date: 05/20/2012 20:56:55 ******/
CREATE TYPE [dbo].[TableType_ChiTietDatHang] AS TABLE(
	[MaHoaDon] [int] NULL,
	[MaNL] [int] NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [float] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[TableType_ChiTietNCC]    Script Date: 05/20/2012 20:56:55 ******/
CREATE TYPE [dbo].[TableType_ChiTietNCC] AS TABLE(
	[MaNL] [int] NULL,
	[MaNCC] [int] NULL,
	[Gia] [float] NULL
)
GO
