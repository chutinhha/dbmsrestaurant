
use [QLNhaHang]
GO
------------------- Table Nguyen Lieu -----------------------------------------------------------------


create proc SelectNguyenLieu_fromNCC @MaNCC int,@MaNH int
as
begin
	select nl.*,ct.Gia
	from NhaCungCap ncc,ChiTietNCC ct,NguyenLieu nl
	where ct.MaNCC = @MaNCC and nl.MaNH = @MaNH 
		  and ct.MaNL = nl.MaNL and ct.MaNCC = ncc.MaNCC
	order by nl.TenNL
end
GO
create proc SelectNguyenLieu_NotIn_ChiTietNCC @MaNCC int ,@MaNH nchar(10) --Select danh sach nguyen lieu khong co trong chi tiet nha cung cap
as
begin
	select * 
	from NguyenLieu nl1
	where nl1.MaNH = @MaNH 
		  and nl1.MaNL not in(select nl.MaNL
							  from NguyenLieu nl,ChiTietNCC ct
							  where ct.MaNCC = @MaNCC and nl.MaNH = @MaNH and nl.MaNL =ct.MaNL)
	order by nl1.TenNL
end
GO
create proc SelectNguyenLieu_NotIn_ChiTietDatHang @MaHoaDon int,@MaNCC int,@MaNH nchar(10)
as
begin
	select nl1.*,ctncc.Gia
	from NguyenLieu nl1 ,ChiTietNCC ctncc
	where nl1.MaNL =ctncc.MaNL 
		  and nl1.MaNH = @MaNH and ctncc.MaNCC = @MaNCC
		  and nl1.MaNL not in(select nl.MaNL
							  from NguyenLieu nl,ChiTietDatHang ct
							  where nl.MaNL =ct.MaNL
								    and ct.MaHoaDon = @MaHoaDon and nl.MaNH = @MaNH )
	order by nl1.TenNL
end

GO

--- Insert Nguyên Liệu 
------------------------------------------------------------------------------------- 
alter proc InsertNguyenLieu @Flag int out,@MaNH nchar(10),@TenNL nvarchar(50),@DonVi nvarchar(20),@SoLuongTon int
as
begin
	set @Flag = 0
	begin tran
		set transaction isolation level read uncommitted
		insert into NguyenLieu values (@MaNH,@TenNL,@DonVi,@SoLuongTon)
		
		waitfor delay '00:00:05'		

		if((select count(*) from NguyenLieu where TenNL = @TenNL and MaNH =@MaNH) = 1 )
		begin
			set @Flag =1
		end
		else
			rollback
	commit
end
GO

create proc UpdateNguyenLieu @Flag int out,@TenNL_old nvarchar(50),@MaNL int,@MaNH nchar(10),@TenNL nvarchar(50),@DonVi nvarchar(20),@SoLuongTon int
as
begin
	if(@TenNL_old = @TenNL or(select count(*) from NguyenLieu where TenNL = @TenNL and MaNH =@MaNH)=0)
	begin
		update NguyenLieu set  MaNH=@MaNH,TenNL=@TenNL,DonVi=@Donvi,SoLuongTon=@SoLuongTon
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
	exec DeleteChiTietNCC_fromNL @MaNL
	exec DeleteChiTietDatHang_fromNL @MaNL
	delete from NguyenLieu where MaNL=@MaNL and MaNH=@MaNH
end
GO

