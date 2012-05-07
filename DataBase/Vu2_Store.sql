	--drop database QLNhaHang
	--create database QLNhaHang

use [QLNhaHang]
GO
------------------- Table Nguyen Lieu -----------------------------------
create proc SelectNguyenLieu @MaNH nchar(10)
as
begin
	select *
	from NguyenLieu nl
	where nl.MaNH = @MaNH
	order by nl.TenNL
end
GO
create proc SelectNguyenLieu_fromNCC @MaNCC int,@MaNH int
as
begin
	select nl.*
	from NhaCungCap ncc,ChiTietNCC ct,NguyenLieu nl
	where ct.MaNCC = @MaNCC and nl.MaNH = @MaNH and ct.MaNL = nl.MaNL and ct.MaNCC = ncc.MaNCC
	order by nl.TenNL
end
GO
create proc SelectNguyenLieu_Free @MaNCC int ,@MaNH nchar(10) --Select danh sach nguyen lieu khong co trong chi tiet nha cung cap
as
begin
	select * 
	from NguyenLieu nl1
	where nl1.MaNH = @MaNH and
		nl1.MaNL not in
		(
			select nl.MaNL
			from NguyenLieu nl,ChiTietNCC ct
			where ct.MaNCC = @MaNCC and nl.MaNH = @MaNH and nl.MaNL =ct.MaNL
		)
	order by nl1.TenNL
end
GO
create  proc InsertNguyenLieu @Flag int out,@MaNH nchar(10),@TenNL nvarchar(50),@Gia float,@DonVi nvarchar(20),@SoLuongTon int
as
begin
	if((select count(*) from NguyenLieu where TenNL = @TenNL and MaNH =@MaNH)=0)
	begin
		insert into NguyenLieu values (@MaNH,@TenNL,@Gia,@DonVi,@SoLuongTon)
		set @Flag =1
	end
	else
		set @Flag =0
end
GO
create proc UpdateNguyenLieu @Flag int out,@TenNL_old nvarchar(50),@MaNL int,@MaNH nchar(10),@TenNL nvarchar(50),@Gia float,@DonVi nvarchar(20),@SoLuongTon int
as
begin
	if(@TenNL_old = @TenNL or(select count(*) from NguyenLieu where TenNL = @TenNL and MaNH =@MaNH)=0)
	begin
		update NguyenLieu set  MaNH=@MaNH,TenNL=@TenNL,Gia=@Gia,DonVi=@Donvi,SoLuongTon=@SoLuongTon
			where MaNL=@MaNL
		set @Flag = 1
	end
	else
		set @Flag= 0
end
GO
create proc DeleteNguyenLieu  @MaNL int,@MaNH nchar(10)
as
begin
delete from NguyenLieu where MaNL=@MaNL and MaNH=@MaNH
end

------------- table NhaCungCap --------------------------------------------
GO
create proc SelectNhaCungCap
as
begin
	select * 
	from NhaCungCap
end
GO
alter proc InsertNhaCungCap @MaNCC int out,@TenNCC nvarchar(50),@sdt nvarchar(50),@DiaChi nvarchar(50),@DiemUuTien int
as
begin
	if((select count(*) from NhaCungCap where TenNCC = @TenNCC)=0)
	begin
		insert into NhaCungCap values(@TenNCC,@sdt,@DiaChi,@DiemUuTien)
		set @MaNCC = (select MaNCC from NhaCungCap where TenNCC = @TenNCC)
	end
	else
		set @MaNCC = 0
end
--GO
--create proc UpdateNhaCungCap @MaNCC int,@TenNCC nvarchar(50),@sdt nvarchar(50),@DiaChi nvarchar(50),@DiemUuTien int
--as
--begin
--	update NhaCungCap set TenNCC=@TenNCC,sdt=@sdt,DiaChi=@DiaChi,DiemUuTien=@DiemUuTien
--	where MaNCC=@MaNCC
--end
--GO
--create proc DeleteNhaCungCap @MaNCC int
--as
--begin
--	delete NhaCungCap
--	where MaNCC=@MaNCC
--end
--------------- table ChiTietNCC -----------------------------
--GO
--create proc SelectChiTietNCC @MaNH int 
--as
--begin
--	select ct.MaNL,ct.MaNCC,nl.TenNL,ncc.TenNCC
--	from NhaCungCap ncc,ChiTietNCC ct,NguyenLieu nl
--	where nl.MaNH = @MaNH and ct.MaNL = nl.MaNL and ct.MaNCC = ncc.MaNCC
--	order by nl.TenNL
--end
--GO
--create proc SelectChiTietNCC_MaNL @MaNL int
--as
--begin
--	select ct.MaNL,ct.MaNCC,ncc.TenNCC
--	from NhaCungCap ncc,ChiTietNCC ct,NguyenLieu nl
--	where ct.MaNL = @MaNL and ct.MaNCC = ncc.MaNCC
--	order by ncc.TenNCC
--end
GO
create proc InsertChiTietNCC @MaNL int,@MaNCC int
as
begin
	insert into ChiTietNCC values(@MaNL,@MaNCC)
end
--------------- table DatHang --------------------------------
--GO
--create proc SelectDatHang
--as
--begin
--	select *
--	from DatHang
--end
--GO
--create proc InsertDatHang  @ThanhTien float,@ThoiGianDat datetime,@ThoiGianGiao nvarchar(10),@MaNH nchar(10)
--as
--begin
--	insert into DatHang values(@ThanhTien,@ThoiGianDat,@ThoiGianGiao,@MaNH)
--end
--GO
--create proc UpdateDatHang @MaHoaDonDat int,@ThanhTien float,@ThoiGianDat datetime,@ThoiGianGiao nvarchar(10),@MaNH nchar(10)
--as
--begin 
--	update DatHang set ThanhTien=@ThanhTien,ThoiGianDat=@ThoiGianDat,ThoiGianGiao=@ThoiGianGiao,MaNH=@MaNH
--	where MaHoaDonDat=@MaHoaDonDat
--end
--GO
--create proc DeleteDatHang @MaHoaDonDat int
--as
--begin
--	delete DatHang
--	where MaHoaDonDat=@MaHoaDonDat
--end
--------------- table ChiTietDatHang -------------------------
--GO
--create proc SelectChiTietDatHang
--as
--begin
--	select *
--	from ChiTietDatHang
--end
--GO
--create proc InsertChiTietDatHang @MaHoaDonDat int,@MaNCC int,@MaNguyenLieu int,@SoLuong int,@Gia float
--as
--begin
--	insert into ChiTietDatHang values(@MaHoaDonDat,@MaNCC,@MaNguyenLIeu,@SoLuong,@Gia)
--end
--GO
--create proc UpdateChiTietDatHang  @MaHoaDonDat int,@MaNCC int,@MaNguyenLieu int,@SoLuong int,@Gia float
--as
--begin
--	update ChiTietDatHang set SoLuong=@SoLuong,Gia=@Gia
--	where MaHoaDonDat=@MaHoaDonDat and MaNCC=@MaNCC and MaNguyenLieu=@MaNguyenLIeu
--end
--GO
--create proc DeleteChiTietDatHang  @MaHoaDonDat int,@MaNCC int,@MaNguyenLieu int
--as
--begin
--	delete ChiTietDatHang
--	where MaHoaDonDat=@MaHoaDonDat and MaNCC=@MaNCC and MaNguyenLieu=@MaNguyenLIeu
--end
--
--GO
--------------- table ChiTietNCC ---------
--create proc SelectChiTietNCC
--as
--begin
--	select *
--	from ChiTietNCC
--end
--GO
--create proc InsertChiTietNCC @MaNL int,@MaNCC int
--as
--begin
--	insert into ChiTietNCC values (@MaNL,@MaNCC)
--end
--GO
--create proc UpdateChiTietNCC @MaNL_old int,@MaNCC_old int,@MaNL int,@MaNCC int
--as
--begin
--	update ChiTietNCC set MaNL =@MaNL,MaNCC =@MaNCC
--	where MaNL =@MaNL_old and MaNCC=@MaNCC_old
--end
--GO
--create proc DeleteChiTietNCC @MaNL int,@MaNCC int
--as
--begin
--	delete ChiTietNCC
--	where MaNL =@MaNL and MaNCC=@MaNCC
--end