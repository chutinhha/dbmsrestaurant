use QLNhaHang
GO
alter table DatBan add Sdt int
GO
alter table DatBan drop constraint PK__DatBan__1367E606
GO
alter table DatBan alter column  TrangThai int not null
GO
alter table DatBan add constraint PK_DatBan_PrimaryKey primary key (MaNH,MaBan,TrangThai,ThoiGianDen)