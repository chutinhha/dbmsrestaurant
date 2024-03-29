use [QLNhaHang]
GO

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
GO


-------------------LOST UPDATE -  CONVERSION DEADLOCK
GO
create proc sp_UpdateSoLuongCTHD_0 @mahd int, @mamon int, @soluong int
as
begin tran
	SET TRAN ISOLATION LEVEL
	READ UNCOMMITTED
	
	declare @soluong_hientai int
	SELECT @soluong_hientai = SoLuong FROM ChiTietHoaDon WHERE MaHD = @mahd AND MaMon = @mamon
	SET @soluong_hientai = @soluong_hientai + @soluong
	
	UPDATE ChiTietHoaDon SET SoLuong = @soluong_hientai WHERE MaHD = @mahd AND MaMon = @mamon

commit tran
GO

create proc sp_UpdateSoLuongCTHD_1 @mahd int, @mamon int, @soluong int
as
begin tran
	SET TRAN ISOLATION LEVEL
	READ UNCOMMITTED
	
		declare @soluong_hientai int
		SELECT @soluong_hientai = SoLuong FROM ChiTietHoaDon WHERE MaHD = @mahd AND MaMon = @mamon
		SET @soluong_hientai = @soluong_hientai + @soluong
		
		waitfor delay '0:0:7'
		UPDATE ChiTietHoaDon SET SoLuong = @soluong_hientai WHERE MaHD = @mahd AND MaMon = @mamon

commit tran

GO		--deadlock
create proc sp_UpdateSoLuongCTHD_2 @mahd int, @mamon int, @soluong int
as
begin tran
	SET TRAN ISOLATION LEVEL
	REPEATABLE READ
	SET LOCK_TIMEOUT 20000
	--conversion deadlock
		declare @soluong_hientai int
		SELECT @soluong_hientai = SoLuong FROM ChiTietHoaDon WHERE MaHD = @mahd AND MaMon = @mamon
		SET @soluong_hientai = @soluong_hientai + @soluong
		
		waitfor delay '0:0:7'
		UPDATE ChiTietHoaDon SET SoLuong = @soluong_hientai WHERE MaHD = @mahd AND MaMon = @mamon

commit tran
GO
create proc sp_UpdateSoLuongCTHD_3 @mahd int, @mamon int, @soluong int
as
begin tran
		declare @soluong_hientai int
		SELECT @soluong_hientai = SoLuong 
			FROM ChiTietHoaDon (UPDLOCK)
			WHERE MaHD = @mahd AND MaMon = @mamon
		SET @soluong_hientai = @soluong_hientai + @soluong
		
		waitfor delay '0:0:7'
		UPDATE ChiTietHoaDon SET SoLuong = @soluong_hientai WHERE MaHD = @mahd AND MaMon = @mamon

commit tran
GO
create proc sp_SelectChiTietHD_0 @mahd int
as
begin
	SELECT MAHD, ma.MaMon, TenMon, Gia, DonViTinh, SoLuong, ThanhTien 
		FROM ChiTietHoaDon cthd INNER JOIN MonAn ma ON cthd.MaMon=ma.MaMon
		WHERE MaHD = @mahd
end
GO
create proc sp_SelectChiTietHD_3 @mahd int
as
begin tran
	SET TRAN ISOLATION LEVEL
	READ COMMITTED
	SELECT MAHD, ma.MaMon, TenMon, Gia, DonViTinh, SoLuong, ThanhTien 
		FROM ChiTietHoaDon cthd INNER JOIN MonAn ma ON cthd.MaMon=ma.MaMon
		WHERE MaHD = @mahd
commit tran

--exec sp_SelectChiTietHD 6




-------------------UNREPEATABLE
GO
create proc sp_insertCTHD_0 @mahd int, @mamon int, @soluong int
as
begin tran
	IF( (select COUNT(*) from MonAn where MaMon = @mamon) = 1 )
		begin
			declare @dongia float
			SET @dongia = 0
			set @dongia = (select Gia from MonAn where MaMon = @mamon)

			INSERT INTO ChiTietHoaDon(MaHD, MaMon, SoLuong, ThanhTien)	VALUES(@mahd, @mamon, @soluong, @dongia * @soluong)
		end
commit tran

GO
create proc sp_insertCTHD_1 @mahd int, @mamon int, @soluong int
as
begin tran
	SET TRAN ISOLATION LEVEL
	READ UNCOMMITTED
	IF( (select COUNT(*) from MonAn where MaMon = @mamon) = 1 )
		begin
			waitfor delay '0:0:10'
			declare @dongia float
			SET @dongia = 0
			set @dongia = (select Gia from MonAn where MaMon = @mamon)

			INSERT INTO ChiTietHoaDon(MaHD, MaMon, SoLuong, ThanhTien)	VALUES(@mahd, @mamon, @soluong, @dongia * @soluong)
		end
commit tran
GO
create proc sp_insertCTHD_3 @mahd int, @mamon int, @soluong int
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



-------------------DIRTY READ
GO
create proc sp_selectBanAn_0 @trangthai int, @manh nchar(10)
as
begin tran
	SET TRAN ISOLATION LEVEL
	READ UNCOMMITTED
	IF (@trangthai = -1)
		SELECT * FROM BanAn WHERE MaNH = @manh
	ELSE
		SELECT * FROM BanAn WHERE TrangThai = @trangthai AND MaNH = @manh
commit tran
-- exec sp_selectBanAn -1,1
GO
create proc sp_selectBanAn_3 @trangthai int, @manh nchar(10)
as
begin tran
	SET TRAN ISOLATION LEVEL
	READ COMMITTED
	IF (@trangthai = -1)
		SELECT * FROM BanAn WHERE MaNH = @manh
	ELSE
		SELECT * FROM BanAn WHERE TrangThai = @trangthai AND MaNH = @manh
commit tran
-- exec sp_selectBanAn -1,1


GO
create proc sp_ChuyenBan_0 @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
as
begin

	begin tran t1
	SET @kq = 1
	SET TRAN ISOLATION LEVEL
	READ UNCOMMITTED
	--cap nhat trang thai 2 ban
	UPDATE BanAn SET TrangThai = 0 WHERE MaBan = @mabanOLD
	
	--co mot T chen vao su dung ban @mabanNEW lam cho Ban nay ko con trangthai = 0
	IF( (SELECT TrangThai FROM BanAn WHERE MaBan = @mabanNEW) = 0)
		begin
			UPDATE BanAn SET TrangThai = 1 WHERE MaBan = @mabanNEW
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
create proc sp_ChuyenBan_1 @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
as
begin

	begin tran t1
	SET @kq = 1
	SET TRAN ISOLATION LEVEL
	READ UNCOMMITTED
	--cap nhat trang thai 2 ban
	UPDATE BanAn SET TrangThai = 0 WHERE MaBan = @mabanOLD
	
	waitfor delay '0:0:10'
	--co mot T chen vao su dung ban @mabanNEW lam cho Ban nay ko con trangthai = 0
	IF( (SELECT TrangThai FROM BanAn WHERE MaBan = @mabanNEW) = 0)
		begin
			UPDATE BanAn SET TrangThai = 1 WHERE MaBan = @mabanNEW
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
create proc sp_ChuyenBan_2 @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
as
begin

	begin tran t1
	SET TRAN ISOLATION LEVEL 
	REPEATABLE READ
	SET @kq = 1
	
	--cap nhat trang thai 2 ban
	UPDATE BanAn SET TrangThai = 0 WHERE MaBan = @mabanOLD
	
	waitfor delay '0:0:10'
	--co mot T chen vao su dung ban @mabanNEW lam cho Ban nay ko con trangthai = 0
	IF( (SELECT TrangThai FROM BanAn WHERE MaBan = @mabanNEW) = 0)
		begin
			UPDATE BanAn SET TrangThai = 1 WHERE MaBan = @mabanNEW
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
create proc sp_ChuyenBan_3 @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
as
begin

	begin tran t1
	SET TRAN ISOLATION LEVEL 
	READ COMMITTED
	SET @kq = 1
	
	--cap nhat trang thai 2 ban
	UPDATE BanAn SET TrangThai = 0 WHERE MaBan = @mabanOLD
	
	waitfor delay '0:0:10'
	--co mot T chen vao su dung ban @mabanNEW lam cho Ban nay ko con trangthai = 0
	IF( (SELECT TrangThai FROM BanAn WHERE MaBan = @mabanNEW) = 0)
		begin
			UPDATE BanAn SET TrangThai = 1 WHERE MaBan = @mabanNEW
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



