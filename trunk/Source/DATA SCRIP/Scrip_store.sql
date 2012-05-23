USE [QLNhaHang]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectUser]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SelectUser] @username nvarchar(50), @pass nvarchar(50), @kq int out
as
begin
	SET @kq = (SELECT COUNT(*) FROM QLNguoiDung WHERE UserName = @username AND Pass = @pass)
end
/*declare @kq int
exec sp_SelectUser 'trungtan', '123654', @kq out
print @kq + 3*/
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectLoaiMonAn]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----1.6 lay loai mon an
CREATE proc [dbo].[sp_SelectLoaiMonAn]
as
begin
	SELECT * FROM LoaiMonAn
end

----1.7 lay mon an theo loai
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNhaCungCap]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------- table NhaCungCap -----------------------------------------------------------
-- lay danh sach nha cung cap
-------------------------------------------------------------------------
create proc [dbo].[SPoV_SelectNhaCungCap]
as
begin
    begin tran
    set transaction isolation level read uncommitted
    select *
    from   NhaCungCap
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateNguyenLieu]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- cap nhat thong tin mot nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_UpdateNguyenLieu] 
	@Flag int out,
	@MaNL int,
	@MaNH nchar(10),
	@TenNL nvarchar(50),
	@DonVi nvarchar(20),
	@SoLuongTon int
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    if ( (select count(*)
          from   NguyenLieu
          where  MaNL = @MaNL)=1)
    begin
        --waitfor delay '00:00:06'
        update NguyenLieu
        set    MaNH = @MaNH
              ,TenNL = @TenNL
              ,DonVi = @Donvi
              ,SoLuongTon = @SoLuongTon
        where  MaNL = @MaNL
      -- waitfor delay '00:00:04'
       if ((select count(*)
            from   NguyenLieu
            where  TenNL = @TenNL
                   and DonVi = @DonVi
                   and MaNH = @MaNH)<>1)
        begin
            rollback tran
            return
        end
    end
    if (@@error<>0)
    begin
        rollback tran
        return
    end  
    set @Flag = 1 
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatMonAn_Fix]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---Ban FIX loi Lost Update



create proc [dbo].[sp_CapNhatMonAn_Fix] @TenMon nvarchar(50),@gia money ,@DVTinh nvarchar(10),@MaMon int
as 
	begin
		set tran isolation level repeatable read
		begin tran
			if((select count(*) from MonAn with(updlock) where MaMon=@MaMon)=1)
			begin
				waitfor delay '00:00:05'
				update MonAn  set TenMon=@TenMon,Gia=@gia,DonViTinh=@DVTinh where MaMon=@MaMon
				waitfor delay '00:00:05'
				if((select count(*) from MonAn where TenMon=@TenMon)<>1)
				begin
					rollback tran
					return
				end
			end
			if(@@error <> 0)
			begin
				rollback tran
				return
			end
			
		commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatMonAn]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----- Truong hop LostUpdate

create proc [dbo].[sp_CapNhatMonAn] @TenMon nvarchar(50),@gia money ,@DVTinh nvarchar(10),@MaMon int
as 
	begin
		set tran isolation level read uncommitted
		begin tran
			if((select count(*) from MonAn where MaMon=@MaMon)=1)
			begin
				waitfor delay '00:00:06'
				update MonAn with(xlock) set TenMon=@TenMon,Gia=@gia,DonViTinh=@DVTinh where MaMon=@MaMon
				waitfor delay '00:00:04'
				if((select count(*) from MonAn where TenMon=@TenMon)<>1)
				begin
					rollback tran
					return
				end
			end
			if(@@error <> 0)
			begin
				rollback tran
				return
			end
			
		commit tran
end

--exec sp_CapNhatMonAn 'ca chien',2000,'con',10
--exec sp_DocMonAn '1'
GO
/****** Object:  StoredProcedure [dbo].[sp_DocMonAn_Fix]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------FIX loi dirty Read
create proc [dbo].[sp_DocMonAn_Fix] @MaNH varchar(5)
as
	begin
	set tran isolation level read committed
	begin tran
	select MaMon,TenMon,TenLoai,Gia,DonViTinh,TenNH
            from MonAn m,LoaiMonAn lm,NhaHang nh
            where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =@MaNH
			--where m.LoaiMon=lm.MaLoai and m.MaNH=@MaNH or m.MaNH is null
	commit
	end

--exec sp_DocMonAn_Fix '1'

--------------------truong hop unrepeatable read
--xoa 1 Mon an
GO
/****** Object:  StoredProcedure [dbo].[sp_DocMonAn]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- truong hop dirty read

create proc [dbo].[sp_DocMonAn] @MaNH varchar(5)
as
	begin
	set tran isolation level read uncommitted
	begin tran
	select MaMon,TenMon,TenLoai,Gia,DonViTinh
            from MonAn m,LoaiMonAn lm,NhaHang nh
            where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =@MaNH
			--where m.LoaiMon=lm.MaLoai and m.MaNH=@MaNH or m.MaNH is null
	commit
	end

exec sp_DocMonAn '1'
GO
/****** Object:  StoredProcedure [dbo].[SPoV_InsertNguyenLieu]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- Them nguyen lieu moi
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_InsertNguyenLieu] 
	@Flag int out,
	@MaNH nchar(10),
	@TenNL nvarchar(50),
	@DonVi nvarchar(20),
	@SoLuongTon int
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    insert into NguyenLieu
    values
      (
        @MaNH
       ,@TenNL
       ,@DonVi
       ,@SoLuongTon
      )
    --waitfor delay '00:00:05'		
    if ((select count(*)
         from   NguyenLieu
         where  TenNL = @TenNL
				and DonVi = @DonVi
                and MaNH = @MaNH)<>1)
    begin
        rollback tran
        return
    end
    
    if (@@error<>0)
    begin
        rollback tran
        return
    end
    
    set @Flag = 1
    commit
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------- Table Nguyen Lieu -----------------------------------------------------------------
--- Lay danh sach nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu] 
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select *
    from   NguyenLieu nl
    where  nl.MaNH = @MaNH
    order by
           nl.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectDatHang_TinhTrang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_SelectDatHang_TinhTrang]  
	@MaNH nchar(10),
	@TinhTrang nvarchar(50)
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	select dh.*
	      ,ncc.TenNCC
	from   DatHang dh
	      ,NhaCungCap ncc
	where  MaNH = @MaNH
	       and dh.MaNCC = ncc.MaNCC
	       and dh.TinhTrang = @TinhTrang
	       
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectDatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--GO
--------------- table DatHang -------------------------------------------------------------------------

-- Slect đơn đặt hàng theo Mã Nhà Hàng
----------------------------------------------------------------
create proc [dbo].[SPoV_SelectDatHang]  
	@MaNH nchar(10)
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	select dh.*,ncc.TenNCC from DatHang dh,NhaCungCap ncc 
	where MaNH = @MaNH and dh.MaNCC = ncc.MaNCC
		
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------- Table Nguyen Lieu -----------------------------------------------------------------
--- Lay danh sach nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_FIX_SelectNguyenLieu] 
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read committed
    select *
    from   NguyenLieu nl
    where  nl.MaNH = @MaNH
    order by
           nl.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[sp_TimTheoLoai_FixP]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----Ban FIX loi Phantom
create proc [dbo].[sp_TimTheoLoai_FixP] @maLoai varchar(5),@maNH varchar(5),@dem int out
as
	begin
		set tran isolation level serializable
		begin tran
			
			select @dem=count(*) from MonAn m,LoaiMonAn lm,NhaHang nh
			where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =@maNH and lm.MaLoai=@maLoai
			
			waitfor delay '00:00:05'

			select MaMon,TenMon,TenLoai,Gia,DonViTinh
            from MonAn m,LoaiMonAn lm,NhaHang nh
            where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =@maNH and lm.MaLoai=@maLoai
			
			commit
	end

-------------truong hop phantom
--alter proc sp_TimTheoLoai @maLoai varchar(5),@maNH varchar(5)
--as
--	begin
--		begin tran
--			select MaMon,TenMon,TenLoai,Gia,DonViTinh
--            from MonAn m,LoaiMonAn lm,NhaHang nh
--            where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =@maNH and lm.MaLoai=@maLoai
--				
--			waitfor delay '00:00:05'
--			commit
--	end
--
--exec sp_TimTheoLoai 'KV','2'


----------Truong hop LostUpdate
GO
/****** Object:  StoredProcedure [dbo].[sp_TimTheoLoai_Fix]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--declare @dem int
--exec sp_TimTheoLoai 'NgheuSo','1',@dem out
--select @dem

-----Ban FIX loi Unrepeatable read

create proc [dbo].[sp_TimTheoLoai_Fix] @maLoai varchar(5),@maNH varchar(5),@dem int out
as
	begin
		set tran isolation level serializable
		begin tran
			
			select @dem=count(*) from MonAn m,LoaiMonAn lm,NhaHang nh
			where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =@maNH and lm.MaLoai=@maLoai
			
			waitfor delay '00:00:05'

			select MaMon,TenMon,TenLoai,Gia,DonViTinh
            from MonAn m,LoaiMonAn lm,NhaHang nh
            where m.LoaiMon=lm.MaLoai and m.MaNH=nh.MaNH and  nh.MaNH =@maNH and lm.MaLoai=@maLoai
			
			commit
	end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMonAn_Fix]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----Ban FIX loi Phantom

create proc [dbo].[sp_ThemMonAn_Fix] @TenMon nvarchar(50),@LoaiMon nchar(20),@Gia int,@DonViTinh nvarchar(20),@MaNH varchar(5)
as
begin
	set tran isolation level read committed 
	begin tran
	insert into MonAn(TenMon,LoaiMon,Gia,DonViTinh,MaNH) values (@TenMon,@LoaiMon,@Gia,@DonViTinh,@MaNH)
	
	if ((select count(*) from MonAn where TenMon=@TenMon)<>1)
	begin
		waitfor delay '00:00:05'
		rollback tran
	end
	
	if(@@error<>0)
		begin
		rollback tran
		commit
		end
	else
		commit
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemMonAn]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec sp_XoaMonAn 84
--exec sp_CapNhatMonAn 'dfd',10000,'chaid',69

--------------truong hop phantom
create proc [dbo].[sp_ThemMonAn] @TenMon nvarchar(50),@LoaiMon nchar(20),@Gia int,@DonViTinh nvarchar(20),@MaNH varchar(5)
as
begin
	begin tran
	insert into MonAn(TenMon,LoaiMon,Gia,DonViTinh,MaNH) values (@TenMon,@LoaiMon,@Gia,@DonViTinh,@MaNH)
	
	--if @TenMon=''or @LoaiMon=''or @Gia=0 or @DonViTinh=''or @MaNH=''
	if ((select count(*) from MonAn where TenMon=@TenMon)<>1)
	begin
		waitfor delay '00:00:05'
		rollback tran
	end
	
	if(@@error<>0)
		begin
		rollback tran
		commit
		end
	else
		commit
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectNhanVien]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SelectNhanVien] @username nvarchar(50)
as
begin
	SELECT * FROM NhanVien WHERE Username = @username
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMonAnTheoLoai]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SelectMonAnTheoLoai] @maloai nchar(10), @manh nchar(10)
as
begin
	SELECT * FROM MonAn WHERE LoaiMon = @maloai AND (MaNH = @manh OR MaNH is null)
end
--	exec sp_SelectMonAnTheoLoai "Bia       ", NULL

---- 1.8 xoa chi tiet hoa don
GO
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_InsertNguyenLieu]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- Them nguyen lieu moi
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_Delay_InsertNguyenLieu]
	@Flag int out,
	@MaNH nchar(10),
	@TenNL nvarchar(50),
	@DonVi nvarchar(20),
	@SoLuongTon int
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    insert into NguyenLieu
    values
      (
        @MaNH
       ,@TenNL
       ,@DonVi
       ,@SoLuongTon
      )
    waitfor delay '00:00:05'		
    if ((select count(*)
         from   NguyenLieu
         where  TenNL = @TenNL
				and DonVi = @DonVi
                and MaNH = @MaNH)<>1)
    begin
        rollback tran
        return
    end
    
    if (@@error<>0)
    begin
        rollback tran
        return
    end
    
    set @Flag = 1
    commit
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeadLock_UpdateTinhTrangDatHang]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeadLock_UpdateTinhTrangDatHang]
	@Flag int out,
	@MaHoaDon int,
	@TinhTrang nvarchar(50)
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	repeatable read
	
	if(@TinhTrang <> N'Đã Giao')
	begin
	    update DatHang 
	    set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
			
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end         
	end
	else
	begin
		update DatHang 
		set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end  			
		--Cap nhat so luong nguyen lieu ton
		declare @soluongton int,
				@soluongthem int,
				@MaNL int
		declare @cur cursor
		set @cur =  cursor for 
		select MaNL
		from   ChiTietDatHang ctdh
		where  ctdh.MaHoaDon = @MaHoaDon
		
		open @cur 
		fetch next from @cur into @MaNL
		while @@FETCH_STATUS = 0
		begin
			set @soluongthem = (
		        select ctdh.SoLuong
		        from   ChiTietDatHang ctdh
		        where ctdh.MaHoaDon = @MaHoaDon
		               and MaNL = @MaNL)
			set @soluongton =
				 (select SoLuongTon
                  from   NguyenLieu
                  where  MaNL = @MaNL)
			waitfor delay '00:00:06'                  
			update NguyenLieu
			set	SoLuongTon=@soluongthem+@soluongton
			where MaNL = @MaNL
			
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end  
			fetch next from @cur into @MaNL
		end
	end
	set @Flag = 1	
	commit tran 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTrangThaiBanAn]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateTrangThaiBanAn] @maban int, @trangthai int
as
begin
	UPDATE BanAn SET TrangThai = @trangthai WHERE MaBan = @maban
end
--	exec sp_UpdateTrangThaiBanAn 1,0


---- 3.1 cap nhat maban trong bang HoaDon:	chuyen ban
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteChiTietNCC_fromNCC]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeleteChiTietNCC_fromNCC] 
	@MaNCC int
as
begin
    begin tran
	set transaction isolation level 
	read uncommitted
	
	delete ChiTietNCC
	where  MaNCC = @MaNCC
		   
	if(@@error<>0)
    begin
        rollback
        return
    end 
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteChiTietDatHang]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Delete chi tiết đặt hàng theo Mã Hóa Đơn
-----------------------------------------------------------------
create proc [dbo].[SPoV_DeleteChiTietDatHang]  
	@MaHoaDon int
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	delete ChiTietDatHang
	where MaHoaDon=@MaHoaDon
	
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_UpdateTinhTrangDatHang]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_Delay_UpdateTinhTrangDatHang]
	@Flag int out,
	@MaHoaDon int,
	@TinhTrang nvarchar(50)
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	read uncommitted
	if(@TinhTrang <> N'Đã Giao')
	begin
	    update DatHang 
	    set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
			
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end         
	end
	else
	begin
		update DatHang 
		set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end  			
		--Cap nhat so luong nguyen lieu ton
		declare @soluongton int,
				@soluongthem int,
				@MaNL int
		declare @cur cursor
		set @cur =  cursor for 
		select MaNL
		from   ChiTietDatHang ctdh
		where  ctdh.MaHoaDon = @MaHoaDon
		
		open @cur 
		fetch next from @cur into @MaNL
		while @@FETCH_STATUS = 0
		begin
			set @soluongthem = (
		        select ctdh.SoLuong
		        from   ChiTietDatHang ctdh
		        where ctdh.MaHoaDon = @MaHoaDon
		               and MaNL = @MaNL)
			set @soluongton =
				 (select SoLuongTon
                  from   NguyenLieu
                  where  MaNL = @MaNL)
			waitfor delay '00:00:06'                  
			update NguyenLieu
			set	SoLuongTon=@soluongthem+@soluongton
			where MaNL = @MaNL
			
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end  
			fetch next from @cur into @MaNL
		end
	end
	set @Flag = 1	
	commit tran 
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteNguyenLieu]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- xoa nguyen lieu
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_DeleteNguyenLieu]  
	@Flag int out,
	@MaNL int,
	@MaNH nchar(10)
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    if ((select count(*)
         from   NguyenLieu
         where  MaNL = @MaNL)=1 )
    begin
        if (( select count(*)
              from   ChiTietNCC
              where  MaNL = @MaNL)=1
              or ( select count(*)
                   from   ChiTietDatHang
                   where  MaNL = @MaNL )=1)
        begin
            set @Flag = -1
            rollback tran
            return
        end
        
        delete 
        from   NguyenLieu
        where  MaNL = @MaNL
               and MaNH = @MaNH
    end
    
    if (@@ERROR<>0)
    begin
        rollback tran
        return
    end
    
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectChiTietDatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------- table ChiTietDatHang --------------------------------------------------------------------

-- Select chi tiết đặt hàng theo Mã Hóa Đơn
---------------------------------------------------------------
create proc [dbo].[SPoV_SelectChiTietDatHang] 
	@MaHoaDon int
as
begin
	begin tran
	set transaction isolation level 
	read uncommitted
	
	select ct.*,nl.TenNL,nl.DonVi
	from ChiTietDatHang ct,NguyenLieu nl
	where MaHoaDon = @MaHoaDon and ct.MaNL = nl.MaNL
	
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_InsertNhaCungCap]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- them nha cung cap moi dong thoi them chi tiet nha cung cap
---------------------------------------------------------------------------------------
create proc [dbo].[SPoV_InsertNhaCungCap] 
	@MaNCC int out,
	@TenNCC nvarchar(50),
	@sdt nvarchar(50),
	@DiaChi nvarchar(50),
	@DiemUuTien int,
	@ChiTiet TableType_ChiTietNCC readonly
as
begin
    set @MaNCC = -1
    begin tran
    set transaction isolation level 
    read uncommitted

    --Insert Nha Cung Cap
    insert into NhaCungCap
    values
      (
        @TenNCC
       ,@sdt
       ,@DiaChi
       ,@DiemUuTien
      )
    set @MaNCC = (select scope_identity())
    --waitfor delay '00:00:05'
	if ((select count(*)from NhaCungCap
		 where TenNCC = @TenNCC)<>1)
	begin
		set @MaNCC = -1
		rollback tran
		return
	end
    
    if (@@ERROR<>0)
    begin
        set @MaNCC = -1
        rollback
        return
    end
    
    --Insert Chi Tiet NCC
    insert into ChiTietNCC
    select MaNL
          ,MaNCC = @MaNCC
          ,Gia
    from   @ChiTiet
    
    if (@@ERROR<>0)
    begin
        set @MaNCC = -1
        rollback
        return
    end
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_InsertDatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_InsertDatHang]  
	@MaHoaDon int out,
	@MaNCC int,
	@MaNH nchar(10),
	@TongTien float,
	@ThoiGianDat datetime,
	@ThoiGianGiao datetime,
	@TinhTrang nvarchar(50),
	@ChiTiet TableType_ChiTietDatHang readonly
as
begin
	set @MaHoaDon = -1
    begin tran
    set transaction isolation level 
    read uncommitted
    --Insert Nha Cung Cap
    insert into DatHang
    values
      (
        @MaNCC
       ,@MaNH
       ,@TongTien
       ,@ThoiGianDat
       ,@ThoiGianGiao
       ,@TinhTrang
      )
    	
    set @MaHoaDon = (select scope_identity())
    --waitfor delay '00:00:05'
    
    if (@@ERROR<>0)
    begin
        set @MaHoaDon = -1
        rollback
        return
    end
    
    --Insert Chi Tiet NCC
    insert into ChiTietDatHang
    select MaHoaDon = @MaHoaDon
          ,MaNL
          ,SoLuong
          ,ThanhTien
    from   @ChiTiet
    
    if (@@ERROR<>0)
    begin
        set @MaHoaDon= -1
        rollback
        return
    end
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_UpdateTinhTrangDatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SPoV_FIX_UpdateTinhTrangDatHang]
	@Flag int out,
	@MaHoaDon int,
	@TinhTrang nvarchar(50)
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	repeatable read
	if(@TinhTrang <> N'Đã Giao')
	begin
	    update DatHang 
	    set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
			
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end         
	end
	else
	begin
		update DatHang 
		set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end  			
		--Cap nhat so luong nguyen lieu ton
		declare @soluongton int,
				@soluongthem int,
				@MaNL int
		declare @cur cursor
		set @cur =  cursor for 
		select MaNL
		from   ChiTietDatHang ctdh
		where  ctdh.MaHoaDon = @MaHoaDon
		
		open @cur 
		fetch next from @cur into @MaNL
		while @@FETCH_STATUS = 0
		begin
			set @soluongthem = (
		        select ctdh.SoLuong
		        from   ChiTietDatHang ctdh with(updlock)
		        where ctdh.MaHoaDon = @MaHoaDon
		               and MaNL = @MaNL)
			set @soluongton =
				 (select SoLuongTon 
                  from   NguyenLieu with(updlock)
                  where  MaNL = @MaNL)
			waitfor delay '00:00:06'                  
			update NguyenLieu
			set	SoLuongTon=@soluongthem+@soluongton
			where MaNL = @MaNL
			
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end  
			fetch next from @cur into @MaNL
		end
	end
	set @Flag = 1	
	commit tran 
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu_NotIn_NCC]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu nha cung cap khong co
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_FIX_SelectNguyenLieu_NotIn_NCC] 
	@MaNCC int ,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    serializable
    select *
    from   NguyenLieu nl1
    where  nl1.MaNH = @MaNH
           and nl1.MaNL not in 
           (select nl.MaNL
            from   NguyenLieu nl
                  ,ChiTietNCC ct
            where  ct.MaNCC = @MaNCC
                   and nl.MaNH = @MaNH
                   and nl.MaNL = ct.MaNL)
    order by nl1.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[sp_selectBanAn_3]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_selectBanAn_3] @trangthai int, @manh nchar(10)
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
/****** Object:  StoredProcedure [dbo].[sp_selectBanAn_0]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_selectBanAn_0] @trangthai int, @manh nchar(10)
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
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu_In_NCC]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua mot nha cung cap
------------------------------------------------------------------------------------- 
create  proc [dbo].[SPoV_FIX_SelectNguyenLieu_In_NCC] 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    serializable
    select nl.*
          ,ct.Gia
    from   NhaCungCap ncc
          ,ChiTietNCC ct
          ,NguyenLieu nl
    where  ct.MaNCC = @MaNCC
           and nl.MaNH = @MaNH
           and ct.MaNL = nl.MaNL
           and ct.MaNCC = ncc.MaNCC
    order by nl.TenNL
    --SET  @Count = @@ROWCOUNT
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateTinhTrangDatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_UpdateTinhTrangDatHang]
	@Flag int out,
	@MaHoaDon int,
	@TinhTrang nvarchar(50)
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	read uncommitted
	if(@TinhTrang <> N'Đã Giao')
	begin
	    update DatHang 
	    set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
			
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end         
	end
	else
	begin
		update DatHang 
		set TinhTrang = @TinhTrang 
		where MaHoaDon = @MaHoaDon
		if(@@ERROR<>0)
		begin
			set @Flag = 0
			rollback
			return
		end  			
		--Cap nhat so luong nguyen lieu ton
		declare @soluongton int,
				@soluongthem int,
				@MaNL int
		declare @cur cursor
		set @cur =  cursor for 
		select MaNL
		from   ChiTietDatHang ctdh
		where  ctdh.MaHoaDon = @MaHoaDon
		
		open @cur 
		fetch next from @cur into @MaNL
		while @@FETCH_STATUS = 0
		begin
			set @soluongthem = (
		        select ctdh.SoLuong
		        from   ChiTietDatHang ctdh
		        where ctdh.MaHoaDon = @MaHoaDon
		               and MaNL = @MaNL)
			set @soluongton =
				 (select SoLuongTon
                  from   NguyenLieu
                  where  MaNL = @MaNL)
			--waitfor delay '00:00:06'                  
			update NguyenLieu
			set	SoLuongTon=@soluongthem+@soluongton
			where MaNL = @MaNL
			
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end  
			fetch next from @cur into @MaNL
		end
	end
	set @Flag = 1	
	commit tran 
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateNhaCungCap]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_UpdateNhaCungCap] 
	@Flag int out,
	@MaNCC int,
	@TenNCC nvarchar(50),
	@sdt nvarchar(50),
	@DiaChi nvarchar(50),
	@DiemUuTien int,
	@ChiTiet TableType_ChiTietNCC readonly
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    
    if(( select count(*) from  NhaCungCap 
         where  MaNCC = @MaNCC )<>0)
    begin
    	-- waitfor delay '00:00:06'
        update NhaCungCap
        set    TenNCC = @TenNCC
              ,sdt = @sdt
              ,DiaChi = @DiaChi
              ,DiemUuTien = @DiemUuTien
        where  MaNCC = @MaNCC
         --waitfor delay '00:00:04'
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end
        
        --Xoa nguyen lieu da bi mat trong danh sach
        delete ChiTietNCC
        where  MaNCC = @MaNCC
               and MaNL in 
              (select ctn.MaNL
               from   ChiTietNCC ctn
               where  ctn.MaNCC = @MaNCC
                      and ctn.MaNL not in 
                      (select MaNL
                       from   @ChiTiet))
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end                                           
        --Them cac nguyen lieu moi cap nhat
        insert into ChiTietNCC
        select ct.MaNL
              ,ct.MaNCC
              ,ct.Gia
        from   @ChiTiet ct
        where  ct.MaNL not in 
			  (select ctn.MaNL
			   from   ChiTietNCC ctn
			   where  ctn.MaNCC = @MaNCC)
                            
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end                      
    end
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateDatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_UpdateDatHang] 
	@Flag int out,
	@MaHoaDon int,
	@MaNCC int,
	@MaNH nchar(10),
	@TongTien float,
	@ThoiGianDat datetime,
	@ThoiGianGiao datetime,
	@TinhTrang nvarchar(50),
	@ChiTiet TableType_ChiTietDatHang readonly
as
begin 
	set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    
    if(( select count(*)
         from   DatHang
         where  MaHoaDon = @MaHoaDon )<>0)
    begin
    	--waitfor delay '00:00:06'
        update DatHang
        set    MaNCC         = @MaNCC
              ,MaNH          = @MaNH
              ,TongTien      = @TongTien
              ,ThoiGianDat   = @ThoiGianDat
              ,ThoiGianGiao  = @ThoiGianGiao
              ,TinhTrang     = @TinhTrang
        where  MaHoaDon      = @MaHoaDon
        -- waitfor delay '00:00:04'
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end
        
        --Xoa nguyen lieu da bi mat trong danh sach
        delete ChiTietDatHang
        where  MaHoaDon = @MaHoaDon
               and MaNL in (
               select ct.MaNL
               from   ChiTietDatHang ct
               where  ct.MaHoaDon = @MaHoaDon
                      and ct.MaNL not in (
                      	select MaNL
                        from   @ChiTiet))
        if(@@ERROR<>0)
        begin
            set @Flag = 0
            rollback
            return
        end      
        --cap nhat so luong va thanh tien cho nguyen lieu
        --dong thoi them nguyen lieu vua cap nhat trong don dat hang
        declare @manl int,
				@soluong int,
				@thanhtien int
		declare @cur cursor 
		set @cur =  cursor for 
		select MaNL
		      ,SoLuong
		      ,ThanhTien
		from   @ChiTiet
		
		open @cur
		fetch next from @cur into @manl,@soluong,@thanhtien
		while @@FETCH_STATUS=0
		begin
			if(exists(select * from ChiTietDatHang 
					  where MaHoaDon = @MaHoaDon 
					  and MaNL = @manl))
			begin
				update ChiTietDatHang set 
					SoLuong = @soluong,
					ThanhTien = @thanhtien 
				where MaNL = @manl 
				and MaHoaDon = @MaHoaDon
			end
			else
				insert into ChiTietDatHang
				values
				  (
				    @MaHoaDon
				   ,@manl
				   ,@soluong
				   ,@thanhtien
				  ) 
				
			if(@@ERROR<>0)
			begin
				set @Flag = 0
				rollback
				return
			end               
			fetch next from @cur into @manl,@soluong,@thanhtien
		end                     
    end
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateChiTietNCC]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------- table ChiTietNCC ---------------------------------------------------------

-------------------------------------------------------------------------
--create proc InsertChiTietNCC @MaNL int,@MaNCC int ,@Gia float
--as
--begin
--    insert into ChiTietNCC
--    values
--      (
--        @MaNL
--       ,@MaNCC
--       ,@Gia
--      )
--end
--go
-- cap nhat gia nguyen nguyen lieu cua nha cung cap
-------------------------------------------------------------------------
create proc [dbo].[SPoV_UpdateChiTietNCC] 
	@Flag int out,
	@MaNL int,
	@MaNCC int ,
	@Gia float
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level 
    read uncommitted
    if((select count(*)
        from   ChiTietNCC
        where  MaNL = @MaNL
               and MaNCC = @MaNCC)=0)
    begin
        rollback tran
        return
    end
    
    --waitfor delay '00:00:06'
    update ChiTietNCC
    set    Gia = @Gia
    where  MaNL = @MaNL
           and MaNCC = @MaNCC
    
    --waitfor delay '00:00:03'
    if (@@error<>0)
    begin
        rollback tran
        return
    end
    set @Flag = 1
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNhaCungCap_fromNH]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Select nhung nha cung cap , co cung cap nguyen lieu cho nha hang dang xet
create proc [dbo].[SPoV_SelectNhaCungCap_fromNH] 
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted

	select distinct ncc.*
	from   NhaCungCap ncc
		  ,ChiTietNCC ct
		  ,NguyenLieu nl
	where  ncc.MaNCC = ct.MaNCC
		   and nl.MaNL = ct.MaNL
		   and NL.MANH = @MaNH
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_In_NCC]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua mot nha cung cap
------------------------------------------------------------------------------------- 
create  proc [dbo].[SPoV_SelectNguyenLieu_In_NCC] 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select nl.*
          ,ct.Gia
    from   NhaCungCap ncc
          ,ChiTietNCC ct
          ,NguyenLieu nl
    where  ct.MaNCC = @MaNCC
           and nl.MaNH = @MaNH
           and ct.MaNL = nl.MaNL
           and ct.MaNCC = ncc.MaNCC
    order by nl.TenNL
    --SET  @Count = @@ROWCOUNT
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_In_DatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua mot nha cung cap
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu_In_DatHang] 
	@MaHoaDon int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select nl.*
          ,ct.SoLuong
          ,ct.ThanhTien
    from   DatHang dh
          ,ChiTietDatHang ct
          ,NguyenLieu nl
    where  ct.MaHoaDon = @MaHoaDon
           and nl.MaNH = @MaNH
           and ct.MaNL = nl.MaNL
           and ct.MaHoaDon = dh.MaHoaDon
    order by
           nl.TenNL
    --SET  @Count = @@ROWCOUNT
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NotIn_NCC]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu nha cung cap khong co
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu_NotIn_NCC] 
	@MaNCC int ,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select *
    from   NguyenLieu nl1
    where  nl1.MaNH = @MaNH
           and nl1.MaNL not in 
           (select nl.MaNL
            from   NguyenLieu nl
                  ,ChiTietNCC ct
            where  ct.MaNCC = @MaNCC
                   and nl.MaNH = @MaNH
                   and nl.MaNL = ct.MaNL)
    order by nl1.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NotIn_DatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---lay danh sach nguyen lieu cua nha cung cap
---khong co trong don dat hang voi nha cung cap do
------------------------------------------------------------------------------------- 
create proc [dbo].[SPoV_SelectNguyenLieu_NotIn_DatHang] 
	@MaHoaDon int,
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted
    select nl1.*
          ,ctncc.Gia
    from   NguyenLieu nl1
          ,ChiTietNCC ctncc
    where  nl1.MaNL = ctncc.MaNL
           and nl1.MaNH = @MaNH
           and ctncc.MaNCC = @MaNCC
           and nl1.MaNL not in 
           (select nl.MaNL
            from   NguyenLieu nl
                  ,ChiTietDatHang ct
            where  nl.MaNL = ct.MaNL
                   and ct.MaHoaDon = @MaHoaDon
                   and nl.MaNH = @MaNH)
    order by
           nl1.TenNL
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NCC]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua nha cung cap
--- va danh sanh nguyen lieu nha cung cap khong co
-------------------------------------------------------------------------------------
create proc [dbo].[SPoV_SelectNguyenLieu_NCC] 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted  
    exec SPoV_SelectNguyenLieu_In_NCC 
		@MaNCC
        ,@MaNH
    --waitfor delay '00:00:05'
    exec SPoV_SelectNguyenLieu_NotIn_NCC 
		@MaNCC
		,@MaNH
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_DatHang]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_SelectNguyenLieu_DatHang] 
	@MaHoaDon int,
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted   
    exec SPoV_SelectNguyenLieu_NotIn_DatHang 
		@MaHoaDon,@MaNCC,
		@MaNH
    --waitfor delay '00:00:05'
    exec SPoV_SelectNguyenLieu_In_DatHang 
		@MaHoaDon,
		@MaNH
    
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[sp_ChuyenBan_3]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChuyenBan_3] @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
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
GO
/****** Object:  StoredProcedure [dbo].[sp_ChuyenBan_2]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChuyenBan_2] @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
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
/****** Object:  StoredProcedure [dbo].[sp_ChuyenBan_1]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChuyenBan_1] @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
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
/****** Object:  StoredProcedure [dbo].[sp_ChuyenBan_0]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ChuyenBan_0] @kq int out, @mabanOLD int, @mabanNEW int, @mahd int
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteHoaDon]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DeleteHoaDon] @mahd int
as 
begin
	DELETE FROM HoaDon WHERE MaHD = @mahd
end



-------------------CONVERSION DEADLOCK
GO
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu_NCC]    Script Date: 05/23/2012 19:00:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SPoV_FIX_SelectNguyenLieu_NCC] 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    serializable
    exec SPoV_FIX_SelectNguyenLieu_In_NCC 
		@MaNCC
        ,@MaNH
    waitfor delay '00:00:05'
    exec SPoV_FIX_SelectNguyenLieu_NotIn_NCC 
		@MaNCC
		,@MaNH
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteNhaCungCap]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeleteNhaCungCap] 
	@Flag int out,
	@MaNCC int
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level 
	read uncommitted
	
	exec SPoV_DeleteChiTietNCC_fromNCC @MaNCC
	if(@@ERROR<>0)
    begin
        rollback
        return
    end 
    
	delete NhaCungCap
	where  MaNCC = @MaNCC
	
	if(@@ERROR<>0)
    begin
        rollback
        return
    end 
    set @Flag = 1  
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteDatHang]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SPoV_DeleteDatHang] 
	@Flag int out,
	@MaHoaDon int
as
begin	
	set @Flag = 0
	begin tran
	set transaction isolation level 
	read uncommitted

	exec SPoV_DeleteChiTietDatHang 
		@MaHoaDon
	if(@@ERROR<>0)
    begin
        rollback
        return
    end 
    
	delete DatHang
	where MaHoaDon=@MaHoaDon
	
	if(@@ERROR<>0)
    begin
        rollback
        return
    end 
    set @Flag = 1  
	commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_SelectNguyenLieu_NCC]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- lay danh sach nguyen lieu cua nha cung cap
--- va danh sanh nguyen lieu nha cung cap khong co
-------------------------------------------------------------------------------------
create proc [dbo].[SPoV_Delay_SelectNguyenLieu_NCC] 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted  
    exec SPoV_SelectNguyenLieu_In_NCC 
		@MaNCC
        ,@MaNH
    waitfor delay '00:00:05'
    exec SPoV_SelectNguyenLieu_NotIn_NCC 
		@MaNCC
		,@MaNH
    commit tran
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectMaHoaDonTheoBan]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----1.5 tim ma hoa don cua ban dang su dung
CREATE proc [dbo].[sp_SelectMaHoaDonTheoBan] @maban int
as
begin
	SELECT MaHD FROM HoaDon WHERE MaBan = @maban AND TongTien = 0
end
--	exec sp_SelectMaHoaDonTheoBan 5
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectHoaDonTrong]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SelectHoaDonTrong]
as
begin
	SELECT MaBan,ThoiGianLap, MaHD FROM HoaDon WHERE TongTien = 0 ORDER BY MaBan
end

---- 3.2 sp_SelectTableCTHD
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateMaBan]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateMaBan] @mahd int, @mabannew int
as
begin
	UPDATE HoaDon SET MaBan = @mabannew WHERE MaHD = @mahd
end
-- exec sp_UpdateMaBan 7,6

---- 3.2 lay thong tin ban trong
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateKetThucHoaDon]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateKetThucHoaDon] @mahd int, @tongtien float, @tgKetThuc datetime
as
begin
	UPDATE HoaDon SET TongTien = @tongtien, ThoiGianKetThuc = @tgKetThuc WHERE MaHD = @mahd
end
--	exec sp_UpdateKetThucHoaDon 6, 50000, '1/4/2012 19:30:00'

---- 2.2 cap nhat trang thai sau khi ket thuc su dung ban an
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateSoLuongCTHD_2]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateSoLuongCTHD_2] @mahd int, @mamon int, @soluong int
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


-------------------UNREPEATABLE
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateSoLuongCTHD_0]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateSoLuongCTHD_0] @mahd int, @mamon int, @soluong int
as
begin tran
	SET TRAN ISOLATION LEVEL
	READ UNCOMMITTED
	IF( (SELECT COUNT(*) FROM ChiTietHoaDon WHERE MaHD = @mahd AND MaMon = @mamon) = 1 )
		begin
			UPDATE ChiTietHoaDon SET SoLuong = @soluong WHERE MaHD = @mahd AND MaMon = @mamon
		end
commit tran
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectTableCTHD]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SelectTableCTHD] @mahd int
as
begin
	SELECT * FROM ChiTietHoaDon WHERE MaHD = @mahd
end
-- exec sp_SelectTableCTHD 9

---- 3.3 xoa chi tiet hoa don theo ma hoa don
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectChiTietHD]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_SelectChiTietHD] @mahd int
as
begin
	SELECT MAHD, ma.MaMon, TenMon, Gia, DonViTinh, SoLuong, ThanhTien 
		FROM ChiTietHoaDon cthd INNER JOIN MonAn ma ON cthd.MaMon=ma.MaMon
		WHERE MaHD = @mahd
end
--exec sp_SelectChiTietHD 6
GO
/****** Object:  StoredProcedure [dbo].[sp_insertCTHD_3]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertCTHD_3] @mahd int, @mamon int, @soluong int
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
/****** Object:  StoredProcedure [dbo].[sp_insertCTHD_1]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertCTHD_1] @mahd int, @mamon int, @soluong int
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
/****** Object:  StoredProcedure [dbo].[sp_insertCTHD_0]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertCTHD_0] @mahd int, @mamon int, @soluong int
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
/****** Object:  StoredProcedure [dbo].[sp_DeleteCTHDtheoMaHD]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DeleteCTHDtheoMaHD] @mahd int
as
begin
	DELETE FROM ChiTietHoaDon WHERE MaHD =  @mahd
end
--	sp_DeleteCTHDtheoMaHD 7	
---- 3.4 3.4 xoa hoa don theo ma hoa don
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCTHD]    Script Date: 05/23/2012 19:00:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_DeleteCTHD] @mahd int, @mamon int
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
