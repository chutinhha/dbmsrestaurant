
use [QLNhaHang]
GO
------------------- Table Nguyen Lieu -----------------------------------------------------------------
--- lấy danh danh sách Nguyên Liệu 
------------------------------------------------------------------------------------- 
create proc SelectNguyenLieu @MaNH nchar(10)
as
begin
	begin tran
		set transaction isolation level read uncommitted
		select *
		from NguyenLieu nl
		where nl.MaNH = @MaNH
		order by nl.TenNL
	commit tran
end
GO
--- thêm nguyên liệu
------------------------------------------------------------------------------------- 
create proc InsertNguyenLieu @Flag int out,@MaNH nchar(10),@TenNL nvarchar(50),@DonVi nvarchar(20),@SoLuongTon int
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
--- cập nhật thông tin 1 nguyên liệu 
------------------------------------------------------------------------------------- 
create proc UpdateNguyenLieu @Flag int out,@TenNL_old nvarchar(50),@MaNL int,@MaNH nchar(10),@TenNL nvarchar(50),@DonVi nvarchar(20),@SoLuongTon int
as
begin
	set @Flag = 0
	begin tran
		set transaction isolation level read uncommitted
		if((select count(*) from NguyenLieu where MaNL = @MaNL)=1)
		begin
			waitfor delay '00:00:05'
			update NguyenLieu set  MaNH=@MaNH,TenNL=@TenNL,DonVi=@Donvi,SoLuongTon=@SoLuongTon where MaNL=@MaNL
			if((select count(*) from NguyenLieu where TenNL = @TenNL and MaNH =@MaNH) = 1 )
			begin
				set @Flag =1
			end
			else
				rollback
		end
	commit tran
end

GO
--- xóa 1 nguyên liệu
------------------------------------------------------------------------------------- 
create proc DeleteNguyenLieu  @Flag int out,@MaNL int,@MaNH nchar(10)
as
begin
	set @Flag = 0
	begin tran
		set transaction isolation level read uncommitted
		if((select count(*) from NguyenLieu where MaNL = @MaNL)=1)
		begin
			if((select count(*) from ChiTietNCC where MaNL = @MaNL)=1 or
			   (select count(*) from ChiTietDatHang where MaNL = @MaNL)=1)
			begin
				set @Flag = -1
				return
			end
			delete from NguyenLieu where MaNL=@MaNL and MaNH=@MaNH
			set @Flag = 1		
		end
	commit tran
end
GO
--- lấy danh sách nguyên liệu của một nhà cung cấp
------------------------------------------------------------------------------------- 
create proc SelectNguyenLieu_fromNCC @MaNCC int,@MaNH int
as
begin
	begin tran
		set transaction isolation level read uncommitted
		select nl.*,ct.Gia
		from NhaCungCap ncc,ChiTietNCC ct,NguyenLieu nl
		where ct.MaNCC = @MaNCC and nl.MaNH = @MaNH 
			  and ct.MaNL = nl.MaNL and ct.MaNCC = ncc.MaNCC
		order by nl.TenNL
	commit tran
end
GO
--- lấy danh sách nguyên liệu nhà cung cấp không cung cấp
------------------------------------------------------------------------------------- 
create proc SelectNguyenLieu_NotIn_ChiTietNCC @MaNCC int ,@MaNH nchar(10) --Select danh sach nguyen lieu khong co trong chi tiet nha cung cap
as
begin
	begin tran
	set transaction isolation level read uncommitted
	select * 
	from NguyenLieu nl1
	where nl1.MaNH = @MaNH 
		  and nl1.MaNL not in(select nl.MaNL
							  from NguyenLieu nl,ChiTietNCC ct
							  where ct.MaNCC = @MaNCC and nl.MaNH = @MaNH and nl.MaNL =ct.MaNL)
	order by nl1.TenNL
	commit tran
end
GO
--- lấy danh sách nguyên liệu của nhà cung cấp, không có trong chi tiết đặt hàng với nhà cung cấp đó
------------------------------------------------------------------------------------- 
create proc SelectNguyenLieu_NotIn_ChiTietDatHang @MaHoaDon int,@MaNCC int,@MaNH nchar(10)
as
begin
	begin tran
	set transaction isolation level read uncommitted
	select nl1.*,ctncc.Gia
	from NguyenLieu nl1 ,ChiTietNCC ctncc
	where nl1.MaNL =ctncc.MaNL 
		  and nl1.MaNH = @MaNH and ctncc.MaNCC = @MaNCC
		  and nl1.MaNL not in(select nl.MaNL
							  from NguyenLieu nl,ChiTietDatHang ct
							  where nl.MaNL =ct.MaNL
								    and ct.MaHoaDon = @MaHoaDon and nl.MaNH = @MaNH )
	order by nl1.TenNL
	commit tran
end

GO

