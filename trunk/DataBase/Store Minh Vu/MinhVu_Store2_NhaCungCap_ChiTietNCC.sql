
use [QLNhaHang]
GO
--------------- table ChiTietNCC ---------------------------------------------------------
-- Lấy danh sách nguyên liệu của nhà cung cấp
-------------------------------------------------------------------------
create proc InsertChiTietNCC @MaNL int,@MaNCC int ,@Gia float
as
begin
	insert into ChiTietNCC values(@MaNL,@MaNCC,@Gia)
end
GO
-- Cập nhật giá nguyên liệu của nhà cung cấp
-------------------------------------------------------------------------
alter proc UpdateChiTietNCC @Flag int out,@MaNL int,@MaNCC int ,@Gia float
as
begin
	set @Flag = 0
	begin tran
		set transaction isolation level read uncommitted
		if((select count(*) from ChiTietNCC where MaNL = @MaNL and MaNCC = @MaNCC)=0)
		begin
			rollback tran
			return
		end

		waitfor delay '00:00:05'
		update ChiTietNCC set Gia = @Gia
		where MaNL = @MaNL and MaNCC = @MaNCC
		if(@@error <> 0)
		begin
			rollback tran
			return
		end
		set @Flag =1					
	commit tran
end
declare @a int 
exec UpdateChiTietNCC @a out,53,11,11100
print @a
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
create proc DeleteChiTietNCC @MaNL int,@MaNCC int
as
begin
	delete ChiTietNCC where MaNL = @MaNL and MaNCC = @MaNCC
end
GO
------------- table NhaCungCap -----------------------------------------------------------
-- Lấy danh sách nhà cung cấp
-------------------------------------------------------------------------
create proc SelectNhaCungCap
as
begin
	begin tran
		set transaction isolation level read uncommitted
		select * 
		from NhaCungCap
	commit tran
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
-- Select nhung nha cung cap , co cung cap nguyen lieu cho nha hang dang xet
create proc SelectNhaCungCap_fromNH @MaNH nchar(10)
as
begin
	begin tran
	select distinct ncc.*
	from NhaCungCap ncc,ChiTietNCC ct,NguyenLieu nl
	where ncc.MaNCC = ct.MaNCC and nl.MaNL = ct.MaNL and NL.MANH = @MaNH
	commit tran
end
GO