USE [QLNhaHang]
GO
alter table NguyenLieu alter column Gia float
GO
alter table NguyenLieu alter column DonVi nvarchar(20)
GO
alter table NguyenLieu drop constraint FK_NguyenLieu_NhaCungCap
GO
alter table NguyenLieu drop column maNCC
GO
Delete from NguyenLieu
GO
alter table NguyenLieu drop constraint PK__NguyenLi__2725D73C2A4B4B5E
GO
alter table NguyenLieu add constraint PK_NguyenLieu primary key(MaNL)
GO
alter table DatHang alter column ThoiGianGiao nvarchar(10)
GO
alter table DatHang alter column ThanhTien float
GO
alter table ChiTietDatHang alter column Gia float
GO
create table ChiTietNCC
(
	MaNL int,
	MaNCC int,
	primary key (MaNL,MaNCC)
)
GO
alter table ChiTietNCC add constraint FK_ChiTietNCC_NhaCungCap foreign key (MaNCC) references NhaCungCap(MaNCC)
GO
alter table ChiTietNCC add constraint FK_ChiTietNCC_NguyenLieu foreign key (MaNL) references NguyenLieu(MaNL)
GO
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (1, N'1         ', N'Bánh tráng', 30000, N'Chục', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (2, N'2         ', N'Bánh tráng', 30000, N'Chục', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (3, N'3         ', N'Bánh tráng', 30000, N'Chục', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (4, N'1         ', N'Trứng cút', 50000, N'Trăm', 20)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (5, N'2         ', N'Trứng cút', 50000, N'Trăm', 20)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (6, N'3         ', N'Trứng cút', 50000, N'Trăm', 20)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (7, N'2         ', N'Thịt bò', 100000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (8, N'2         ', N'Hành tây', 20000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (9, N'2         ', N'Mì sợi', 50000, N'Kg', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (10, N'1         ', N'Chem chép', 40000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (11, N'1         ', N'Hào', 10000, N'Con', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (12, N'1         ', N'Nghêu', 30000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (13, N'1         ', N'Ốc hương', 100000, N'Kg', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (14, N'3         ', N'Gà', 55000, N'Kg', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (15, N'1         ', N'Mực', 120000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (16, N'3         ', N'Trứng vịt lộn', 3000, N'Trứng', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (17, N'3         ', N'Chim sẻ', 10000, N'Con', 175)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (18, N'1         ', N'Cá kèo', 60000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (19, N'1         ', N'Ếch', 15000, N'Con', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (20, N'1         ', N'Cua', 50000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (21, N'1         ', N'Gạo', 13000, N'Kg', 200)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (22, N'1         ', N'Cá diêu hồng', 40000, N'Kg', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (23, N'1         ', N'Đậu phộng', 30000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (24, N'2         ', N'Đậu phộng', 30000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (25, N'3         ', N'Đậu phộng', 30000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (26, N'1         ', N'Thuốc mèo', 15000, N'Gói', 1120)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (27, N'2         ', N'Thuốc mèo', 15000, N'Gói', 1120)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (28, N'3         ', N'Thuốc mèo', 15000, N'Gói', 1120)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (29, N'1         ', N'Bánh tráng', 30000, N'Chục', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (30, N'2         ', N'Bánh tráng', 30000, N'Chục', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (31, N'3         ', N'Bánh tráng', 30000, N'Chục', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (32, N'1         ', N'Đậu hũ', 30000, N'Kg', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (33, N'2         ', N'Đậu hũ', 30000, N'Kg', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (34, N'3         ', N'Đậu hũ', 30000, N'Kg', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (35, N'1         ', N'Hành, ngò, xả…', 10000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (36, N'2         ', N'Hành, ngò, xả…', 10000, N'Kg ', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (37, N'3         ', N'Hành, ngò, xả…', 10000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (38, N'1         ', N'Nấm', 30000, N'Kg ', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (39, N'2         ', N'Nấm', 30000, N'K', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (40, N'3         ', N'Nấm', 30000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (41, N'1         ', N'Ốc móng tay', 60000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (42, N'1         ', N'Sò huyết', 30000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (43, N'1         ', N'Sò điệp', 30000, N'Kg', 30)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (44, N'1         ', N'Mực ống', 40000, N'Kg', 40)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (45, N'1         ', N'Tôm', 60000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (46, N'1         ', N'Bún', 20000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (47, N'2         ', N'Bún', 20000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (48, N'3         ', N'Bún', 20000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (49, N'1         ', N'Lươn', 100000, N'Kg', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (50, N'1         ', N'Mì', 20000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (51, N'2         ', N'Mì', 20000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (52, N'3         ', N'Mì', 20000, N'Kg', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (53, N'1         ', N'Bia 333', 10000, N'Lon', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (54, N'2         ', N'Bia 333', 10000, N'Lon', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (55, N'3         ', N'Bia 333', 10000, N'Lon', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (56, N'1         ', N'Bia Heniken chai', 12000, N'Chai', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (57, N'2         ', N'Bia Heniken chai', 12000, N'Chai', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (58, N'3         ', N'Bia Heniken chai', 12000, N'Chai', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (59, N'1         ', N'Bia Heniken lon', 14000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (60, N'2         ', N'Bia Heniken lon', 14000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (61, N'3         ', N'Bia Heniken lon', 14000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (62, N'1         ', N'Bia sài gòn đỏ', 7500, N'Lon', 80)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (63, N'2         ', N'Bia sài gòn đỏ', 7500, N'Lon', 80)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (64, N'3         ', N'Bia sài gòn đỏ', 7500, N'Lon', 80)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (65, N'1         ', N'Bia Tiger', 12000, N'Lon', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (66, N'2         ', N'Bia Tiger', 12000, N'Lon', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (67, N'3         ', N'Bia Tiger', 12000, N'Lon', 75)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (68, N'1         ', N'7 UP', 6000, N'Lon', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (69, N'2         ', N'7 UP', 6000, N'Lon', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (70, N'3         ', N'7 UP', 6000, N'Lon', 50)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (71, N'1         ', N'Cam ép', 8000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (72, N'2         ', N'Cam ép', 8000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (73, N'3         ', N'Cam ép', 8000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (74, N'1         ', N'Coca cola', 6000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (75, N'2         ', N'Coca cola', 6000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (76, N'3         ', N'Coca cola', 6000, N'Lon', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (77, N'1         ', N'Nước suối', 3000, N'Chai', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (78, N'2         ', N'Nước suối', 3000, N'Chai', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (79, N'3         ', N'Nước suối', 3000, N'Chai', 100)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (80, N'1         ', N'Sting dau', 8000, N'Chai', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (81, N'2         ', N'Sting dau', 8000, N'Chai', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (82, N'3         ', N'Sting dau', 8000, N'Chai', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (83, N'1         ', N'Thuốc 333', 30000, N'Gói', 200)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (84, N'2         ', N'Thuốc 333', 30000, N'Gói', 200)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (85, N'3         ', N'Thuốc 333', 30000, N'Gói', 200)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (86, N'1         ', N'Thuốc JET', 15000, N'Gói', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (87, N'2         ', N'Thuốc JET', 15000, N'Gói', 150)
INSERT [dbo].[NguyenLieu] ([MaNL], [MaNH], [TenNL], [Gia], [DonVi], [SoLuongTon]) VALUES (88, N'3         ', N'Thuốc JET', 15000, N'Gói', 150)
