
use [QLNhaHang]
GO
--------------- table ChiTietNCC ---------------------------------------------------------

create proc InsertChiTietNCC @MaNL int,@MaNCC int ,@Gia float
as
begin
	insert into ChiTietNCC values(@MaNL,@MaNCC,@Gia)
end
GO
create proc UpdateChiTietNCC @MaNL int,@MaNCC int ,@Gia float
as
begin
	update ChiTietNCC set Gia = @Gia
	where MaNL = @MaNL and MaNCC = @MaNCC
end
GO
create proc DeleteChiTietNCC_fromNCC @MaNCC int
as
begin
	delete ChiTietNCC where MaNCC = @MaNCC
end
GO
create proc DeleteChiTietNCC_fromNL @MaNL int
as
begin
	delete ChiTietNCC where MaNL = @MaNL
end
GO
------------- table NhaCungCap -----------------------------------------------------------

create proc SelectNhaCungCap
as
begin
	select * 
	from NhaCungCap
end
GO
-- Select nhung nha cung cap , co cung cap nguyen lieu cho nha hang dang xet
create proc SelectNhaCungCap_fromNH @MaNH nchar(10)
as
begin
	select distinct ncc.*
	from NhaCungCap ncc,ChiTietNCC ct,NguyenLieu nl
	where ncc.MaNCC = ct.MaNCC and nl.MaNL = ct.MaNL and NL.MANH = @MaNH
end
GO
create proc InsertNhaCungCap @MaNCC int out,@TenNCC nvarchar(50),@sdt nvarchar(50),@DiaChi nvarchar(50),@DiemUuTien int
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
GO
create proc UpdateNhaCungCap @Flag int out,@TenNCC_old nvarchar(50),@MaNCC int,@TenNCC nvarchar(50),@sdt nvarchar(50),@DiaChi nvarchar(50),@DiemUuTien int
as
begin
	if(@TenNCC_old =@TenNCC or (select count(*) from NhaCungCap where TenNCC = @TenNCC)=0)
	begin
		update NhaCungCap set TenNCC=@TenNCC,sdt=@sdt,DiaChi=@DiaChi,DiemUuTien=@DiemUuTien
		where MaNCC=@MaNCC
		set @Flag = 1
	end
	else
		set @Flag =0
end
GO
create proc DeleteNhaCungCap @MaNCC int
as
begin
	exec DeleteChiTietNCC_fromNCC @MaNCC
	delete NhaCungCap
	where MaNCC=@MaNCC
end
GO
