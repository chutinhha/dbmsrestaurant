use QLNhaHanga
GO
--insert Loai Nhan Vien
insert into LoaiNV values('TN','Thu Ngan',3000000)
insert into LoaiNV values('PV','Phuc Vu',2000000)
insert into LoaiNV values('QLKho','Quan Ly Kho',3000000)
insert into LoaiNV values('QLNhaHang','Thu Ngan',5000000)
insert into LoaiNV values('TQL','Tong Quan Ly',8000000)
--......
--insert bang NhanVien
GO
select * from LoaiNV

insert into NhanVien(TenNV,MaNH,MaLoai) values('Nguyen Ba Ngoc',NULL,'QLKho')
GO
--insert NhaHang
insert into NhaHang values('NHA','Nha Hang A','123 - dau do',12345678,1)
insert into NhaHang values('NHB','Nha Hang B','le duong ',12345678,1)
GO
select * from NhaHang
select * from NhanVien
update NhanVien set MaNH='NHA' where MaNV=1
GO
--insert HoaDon

--insert ChiTietHoaDon
GO
--insert Khu Vuc
insert into KhuVuc(TenKhuVuc,Vitri,MaNH) values('San Thuong','tang 3','NHA')
insert into KhuVuc(TenKhuVuc,Vitri,MaNH) values('San Thuong','tang 4','NHB')
GO
--insert LoaiBan
insert into LoaiBan values('VIP',10)
insert into LoaiBan values('nho',5)
insert into LoaiBan values('to',20)
GO
--insert BanAn
select * from LoaiBan
insert into BanAn(TenBan,MaKhuVuc,LoaiBan) values(N'Bàn 1',1,'VIP')
insert into BanAn(TenBan,MaKhuVuc,LoaiBan) values(N'Bàn 2',2,'VIP')
GO
--insert LoaiMonAn
insert into LoaiMonAn values ('N','Nuoc Uong')
insert into LoaiMonAn values ('HS','Hai San')
GO
--insert MonAn
select * from LoaiMonAn
insert into MonAn(TenMon,LoaiMon,Gia,DonViTinh,MaNH) values('bia 333','N',12000,'lon','NHA')
insert into MonAn(TenMon,LoaiMon,Gia,DonViTinh,MaNH) values('tom hap bia','HS',80000,'dia','NHA')
GO
--insert NhaCungCap
insert into NhaCungCap(TenNCC,sdt,DiaChi,DiemUuTien) values('Hai San PT',123456,'phan thiet',2)
GO
--insert NguyenLieu(kho)
select * from NhaCungCap
insert into NguyenLieu(TenNL,Gia,DonVi,SoLuongTon,MaNH,MaNCC,SucChua) 
			values('Tom',100000,'kg',5,'NHA',1,100)

insert into NguyenLieu(TenNL,Gia,DonVi,SoLuongTon,MaNH,MaNCC,SucChua) 
			values('bia 333',8000,'lon',55,'NHA',1,100)
GO
--insert ChiTietMonAN
select * from MonAn
select * from NguyenLieu
insert into ChiTietMonAn values(2,1,10)
insert into ChiTietMonAn values(2,2,1)
GO
--insert KhachHang
insert into KhachHang values(12345,'cu teo',2345678,'VIP')

--insert DatBan
GO


--insert DatHang

--insert ChiTietDatHang

--insert QLNguoiDung

--


