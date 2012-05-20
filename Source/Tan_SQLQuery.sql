use [QLNhaHang]
--=============	 CAC CAU TRUY VAN CAN CO THEM DIEU KIEN LOC THEO MA NHA HANG CUA TAI KHOAN HIEN TAI

-----------Thu Ngân: 1.QL Bàn ăn, 2.Tính tiền, 3.Chuyển bàn gép bàn

/*---	1.1 Thêm hoá đơn		--- chức năng của Tiếp tân (xếp bàn)
GO
create proc sp_insertHoaDon @thoiGianLap datetime, @manv int, @maban int
as
begin 
	UPDATE BanAn SET TrangThai = 1 WHERE MaBan = @maban		--0:còn trống , 1:đang dùng
	
	INSERT INTO HoaDon(ThoiGianLap, MaNV, MaBan, TongTien) VALUES(@thoiGianLap, @manv, @maban, 0)
end
--exec sp_insertHoaDon '1/4/2012 19:30:00', 1, 1
*/

----1.2 thêm chi tiết hoá đơn
GO
create  proc sp_insertCTHD @mahd int, @mamon int, @soluong int
as
begin tran
	SET TRAN ISOLATION LEVEL
	--READ COMMITTED
	REPEATABLE READ

	IF( (select COUNT(*) from MonAn where MaMon = @mamon) = 1 )
		begin
			waitfor delay '0:0:10'
			declare @dongia float
			SET @dongia = 0
			set @dongia = (select Gia from MonAn where MaMon = @mamon)

			INSERT INTO ChiTietHoaDon(MaHD, MaMon, SoLuong, ThanhTien)	VALUES(@mahd, @mamon, @soluong, @dongia * @soluong)
		end
commit tran
-- exec sp_insertCTHD 6, 1, 2
-- exec sp_insertCTHD 2, 18, 1

----1.3 chon ban an theo trang thai
GO
create proc sp_selectBanAn @trangthai int, @manh nchar(10)
as
begin tran
	--SET TRAN ISOLATION LEVEL
	--REPEATABLE READ
	IF (@trangthai = -1)
		SELECT * FROM BanAn WHERE MaNH = @manh
	ELSE
		SELECT * FROM BanAn WHERE TrangThai = @trangthai AND MaNH = @manh
commit tran
-- exec sp_selectBanAn -1,1
GO

---- 1.4 xem chi tiet hoa don cua ban dang su dung co chi tiet mon
create proc sp_SelectChiTietHD @mahd int
as
begin
	SELECT MAHD, ma.MaMon, TenMon, Gia, DonViTinh, SoLuong, ThanhTien 
		FROM ChiTietHoaDon cthd INNER JOIN MonAn ma ON cthd.MaMon=ma.MaMon
		WHERE MaHD = @mahd
end
--exec sp_SelectChiTietHD 6

GO
----1.5 tim ma hoa don cua ban dang su dung
create proc sp_SelectMaHoaDonTheoBan @maban int
as
begin
	SELECT MaHD FROM HoaDon WHERE MaBan = @maban AND TongTien = 0
end
--	exec sp_SelectMaHoaDonTheoBan 5

GO

----1.6 lay loai mon an
create proc sp_SelectLoaiMonAn
as
begin
	SELECT * FROM LoaiMonAn
end

----1.7 lay mon an theo loai
GO
create proc sp_SelectMonAnTheoLoai @maloai nchar(10), @manh nchar(10)
as
begin
	SELECT * FROM MonAn WHERE LoaiMon = @maloai AND (MaNH = @manh OR MaNH is null)
end
--	exec sp_SelectMonAnTheoLoai "Bia       ", NULL

---- 1.8 xoa chi tiet hoa don
GO
create proc sp_DeleteCTHD @mahd int, @mamon int
as
begin
	DELETE FROM ChiTietHoaDon WHERE MaHD = @mahd AND MaMon = @mamon
end
-- exec sp_DeleteCTHD 6,34

---- 1.9 tang so luong mon an cua chi tiet hoa don
GO
create  proc sp_UpdateSoLuongCTHD @mahd int, @mamon int, @soluong int
as
begin tran
	SET TRAN ISOLATION LEVEL
	REPEATABLE READ
	SET LOCK_TIMEOUT 20000
	--conversion deadlock
	IF( (SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaHD = @mahd AND MaMon = @mamon) = 1 )
		begin
			waitfor delay '0:0:7'
			UPDATE ChiTietHoaDon SET SoLuong = @soluong WHERE MaHD = @mahd AND MaMon = @mamon
		end
commit tran
--exec sp_UpdateSoLuongCTHD 6,57,5		--chay dong thoi
--exec sp_UpdateSoLuongCTHD 6,57,3



---- 2.1 ket thuc su dung ban an
GO
create proc sp_UpdateKetThucHoaDon @mahd int, @tongtien float, @tgKetThuc datetime
as
begin
	UPDATE HoaDon SET TongTien = @tongtien, ThoiGianKetThuc = @tgKetThuc WHERE MaHD = @mahd
end
--	exec sp_UpdateKetThucHoaDon 6, 50000, '1/4/2012 19:30:00'

---- 2.2 cap nhat trang thai sau khi ket thuc su dung ban an
GO
create proc sp_UpdateTrangThaiBanAn @maban int, @trangthai int
as
begin
	UPDATE BanAn SET TrangThai = @trangthai WHERE MaBan = @maban
end
--	exec sp_UpdateTrangThaiBanAn 1,0



---- 3.1 cap nhat maban trong bang HoaDon:	chuyen ban
GO
create proc sp_UpdateMaBan @mahd int, @mabannew int
as
begin
	UPDATE HoaDon SET MaBan = @mabannew WHERE MaHD = @mahd
end
-- exec sp_UpdateMaBan 7,6

---- 3.2 lay thong tin ban trong
GO
create proc sp_SelectHoaDonTrong
as
begin
	SELECT MaBan,ThoiGianLap, MaHD FROM HoaDon WHERE TongTien = 0 ORDER BY MaBan
end

---- 3.2 sp_SelectTableCTHD
GO
create proc sp_SelectTableCTHD @mahd int
as
begin
	SELECT * FROM ChiTietHoaDon WHERE MaHD = @mahd
end
-- exec sp_SelectTableCTHD 9

---- 3.3 xoa chi tiet hoa don theo ma hoa don
GO
create proc sp_DeleteCTHDtheoMaHD @mahd int
as
begin
	DELETE FROM ChiTietHoaDon WHERE MaHD =  @mahd
end
--	sp_DeleteCTHDtheoMaHD 7	
---- 3.4 3.4 xoa hoa don theo ma hoa don
GO
create proc sp_DeleteHoaDon @mahd int
as 
begin
	DELETE FROM HoaDon WHERE MaHD = @mahd
end



------------ STORE PROCEDURE FOR TRANSACTION WITH CONCURRENCY CONFLICT-------------
GO
create proc sp_ChuyenBan @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
as
begin

	begin tran t1
	--SET TRAN ISOLATION LEVEL 
	--REPEATABLE READ
	SET @kq = 1
	
	--cap nhat trang thai 2 ban
	UPDATE BanAn SET TrangThai = 0 WHERE MaBan = @mabanOLD
	
	waitfor delay '0:0:10'
	--co mot T chen vao su dung ban @mabanNEW lam cho Ban nay ko con trangthai = 0
	IF( (SELECT TrangThai FROM BanAn WHERE MaBan = @mabanNEW) = 0)
		begin
			EXEC dbo.sp_UpdateTrangThaiBanAn @mabanNEW, 1
			--cap nhat hoa don
			UPDATE HoaDon SET MaBan = @mabanNEW WHERE MaHD = @mahd
			commit tran t1
		end
	ELSE
		begin
			SET @kq = 0
			rollback tran t1		--cac chuc nang xem va su dung Ban co trangthai = 0 da bi dirty read tai ban co maban=@mabanOLD
		end
end

GO
-- EXEC dbo.sp_ChuyenBan 1,6,3
/*CAI DAT TRONG HOADON DAO
	Tinh huong: user1 chuyen tu ban1 sang ban2
				trangthai cua ban1 da duoc cap nhat = 0 VA BI MOT TRANSACTION KHAC DOC LEN (vd ghep ban)
				trong khi cho doi thi ban2 lai duoc dua vao su dung (trangthai tu 0 chuyen sang 1) boi 1 TRAN khac (vd: sap ban, ghep ban, su dung ban)
				cau lenh IF bi sai va TRAN bi rollback
	Thuc hien: goi chuc nang chuyen ban (chay tren tieu trinh moi), thuc hien chuyen ban dang dung vao 1 ban trong
				-- trong vong 10 giay
					goi 1 chuc nang ghep ban (de co load DS ban trong	=> DS bi DIRTY READ  vi doc ra ban1 ) (1)
					sap ban de su dung ban trong 
				-- end 10 giay
				=> vay chuc nang (1) bi dirty read
	Khac phuc: yeu cau cap shared-lock khi doc danh sach BanAn: sp_selectBanAn REPEATABLE READ
*/

--======= quan ly nguoi dung - dang nhap
create proc sp_SelectUser @username nvarchar(50), @pass nvarchar(50), @kq int out
as
begin
	SET @kq = (SELECT COUNT(*) FROM QLNguoiDung WHERE UserName = @username AND Pass = @pass)
end
/*declare @kq int
exec sp_SelectUser 'trungtan', '123654', @kq out
print @kq + 3*/
GO
create proc sp_SelectNhanVien @username nvarchar(50)
as
begin
	SELECT * FROM NhanVien WHERE Username = @username
end