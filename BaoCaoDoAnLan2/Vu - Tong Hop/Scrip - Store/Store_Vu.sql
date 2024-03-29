USE [QLNhaHang]
GO
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNhaCungCap]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateNguyenLieu]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectDatHang_TinhTrang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_InsertNguyenLieu]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_InsertNguyenLieu]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateNhaCungCap]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteChiTietNCC_fromNCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteChiTietDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_DeadLock_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteNguyenLieu]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu_In_NCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_InsertDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_UpdateTinhTrangDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu_NotIn_NCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectChiTietDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_InsertNhaCungCap]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_In_NCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_In_DatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_UpdateChiTietNCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNhaCungCap_fromNH]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NotIn_NCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NotIn_DatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_NCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_SelectNguyenLieu_DatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_FIX_SelectNguyenLieu_NCC]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteNhaCungCap]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_DeleteDatHang]    Script Date: 05/20/2012 20:48:25 ******/
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
/****** Object:  StoredProcedure [dbo].[SPoV_Delay_SelectNguyenLieu_NCC]    Script Date: 05/20/2012 20:48:25 ******/
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
