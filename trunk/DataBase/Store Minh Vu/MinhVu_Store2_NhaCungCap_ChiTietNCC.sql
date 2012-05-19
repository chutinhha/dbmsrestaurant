

use [QLNhaHang]
go
create type TableType_ChiTietNCC as table
(MaNL int ,MaNCC int ,Gia float);
go
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
alter proc UpdateChiTietNCC @Flag int out,@MaNL int,@MaNCC int ,@Gia float
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level read uncommitted
    if((select count(*)
        from   ChiTietNCC
        where  MaNL = @MaNL
               and MaNCC = @MaNCC)=0)
    begin
        rollback tran
        return
    end
    
    waitfor delay '00:00:06'
    update ChiTietNCC
    set    Gia = @Gia
    where  MaNL = @MaNL
           and MaNCC = @MaNCC
    
    waitfor delay '00:00:03'
    if (@@error<>0)
    begin
        rollback tran
        return
    end
    else
        set @Flag = 1
    
    commit tran
end
--declare @a int 
--exec UpdateChiTietNCC @a out,53,11,12
--print @a
--select * from ChiTietNCC where MaNL = 53 and MaNCC = 11
go
create proc DeleteChiTietNCC_fromNCC @MaNCC int
as
begin
    begin tran
	set transaction isolation level read uncommitted
		delete ChiTietNCC
		where  MaNCC = @MaNCC
			   
		if(@@error<>0)
        begin
            rollback
            return
        end 
	commit tran
end
go
--create proc DeleteChiTietNCC_fromNL @MaNL int
--as
--begin
--    begin tran
--	set transaction isolation level read uncommitted
--		  delete ChiTietNCC
--    where  MaNL = @MaNL
			   
--		if(@@error<>0)
--        begin
--            rollback
--            return
--        end 
--	commit tran
--end
--go
--create proc DeleteChiTietNCC @MaNL int,@MaNCC int
--as
--begin
--	begin tran
--	set transaction isolation level read uncommitted
--		delete ChiTietNCC
--		where  MaNL = @MaNL
--			   and MaNCC = @MaNCC
			   
--		if(@@error<>0)
--        begin
--            rollback
--            return
--        end 
--	commit tran
--end
go
------------- table NhaCungCap -----------------------------------------------------------
-- lay danh sach nha cung cap
-------------------------------------------------------------------------
create proc SelectNhaCungCap
as
begin
    begin tran
    set transaction isolation level read uncommitted
    select *
    from   NhaCungCap
    commit tran
end
go

-- them nha cung cap moi dong thoi them chi tiet nha cung cap
---------------------------------------------------------------------------------------
alter proc InsertNhaCungCap 
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
    set transaction isolation level read uncommitted
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
        waitfor delay '00:00:05'
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
go
create proc UpdateNhaCungCap 
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
create proc DeleteNhaCungCap 
	@Flag int out,
	@MaNCC int
as
begin
	set @Flag = 0
	begin tran
	set transaction isolation level read uncommitted
		exec DeleteChiTietNCC_fromNCC @MaNCC
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

go
-- Select nhung nha cung cap , co cung cap nguyen lieu cho nha hang dang xet
create proc SelectNhaCungCap_fromNH @MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted
		select distinct ncc.*
		from   NhaCungCap ncc
			  ,ChiTietNCC ct
			  ,NguyenLieu nl
		where  ncc.MaNCC = ct.MaNCC
			   and nl.MaNL = ct.MaNL
			   and NL.MANH = @MaNH
    
    commit tran
end

go