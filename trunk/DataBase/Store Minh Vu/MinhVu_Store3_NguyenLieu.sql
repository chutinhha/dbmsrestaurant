


use [QLNhaHang]
go
------------------- Table Nguyen Lieu -----------------------------------------------------------------
--- Lay danh sach nguyen lieu
------------------------------------------------------------------------------------- 
alter proc SelectNguyenLieu 
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
go
--- Them nguyen lieu moi
------------------------------------------------------------------------------------- 
alter proc InsertNguyenLieu 
	@Flag int out,
	@MaNH nchar(10),
	@TenNL nvarchar(50),
	@DonVi nvarchar(20),
	@SoLuongTon int
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level read uncommitted
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
go
--- cap nhat thong tin mot nguyen lieu
------------------------------------------------------------------------------------- 
create proc UpdateNguyenLieu 
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
        waitfor delay '00:00:06'
        update NguyenLieu
        set    MaNH = @MaNH
              ,TenNL = @TenNL
              ,DonVi = @Donvi
              ,SoLuongTon = @SoLuongTon
        where  MaNL = @MaNL
       waitfor delay '00:00:04'
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
go
--- xoa nguyen lieu
------------------------------------------------------------------------------------- 
create proc DeleteNguyenLieu  @Flag int out,@MaNL int,@MaNH nchar(10)
as
begin
    set @Flag = 0
    begin tran
    set transaction isolation level read uncommitted
    if ((select count(*) from   NguyenLieu where  MaNL = @MaNL)=1 )
    begin
        if (( select count(*)from   ChiTietNCC where  MaNL = @MaNL)=1
               or (select count(*) from ChiTietDatHang where  MaNL = @MaNL )=1)
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
go

--- lay danh sach nguyen lieu cua nha cung cap
--- va danh sanh nguyen lieu nha cung cap khong co
-------------------------------------------------------------------------------------
alter proc SelectNguyenLieu_NCC 
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level 
    read uncommitted  
    exec SelectNguyenLieu_In_NCC 
		@MaNCC
        ,@MaNH
    waitfor delay '00:00:05'
    exec SelectNguyenLieu_NotIn_NCC 
		@MaNCC
		,@MaNH
    commit tran
end
go
--- lay danh sach nguyen lieu cua mot nha cung cap
------------------------------------------------------------------------------------- 
alter  proc SelectNguyenLieu_In_NCC @MaNCC int,@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted
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
go

--- lay danh sach nguyen lieu nha cung cap khong co
------------------------------------------------------------------------------------- 
create proc SelectNguyenLieu_NotIn_NCC @MaNCC int ,@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted
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
go
alter proc SelectNguyenLieu_DatHang @MaHoaDon int,@MaNCC int,@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted   
    exec SelectNguyenLieu_NotIn_DatHang @MaHoaDon,@MaNCC,@MaNH
    --waitfor delay '00:00:05'
    exec SelectNguyenLieu_In_DatHang @MaHoaDon,@MaNH
    
    commit tran
end
go
--- lay danh sach nguyen lieu cua mot nha cung cap
------------------------------------------------------------------------------------- 
alter proc SelectNguyenLieu_In_DatHang @MaHoaDon int,@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted
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
go
---lay danh sach nguyen lieu cua nha cung cap
---khong co trong don dat hang voi nha cung cap do
------------------------------------------------------------------------------------- 
alter proc SelectNguyenLieu_NotIn_DatHang 
	@MaHoaDon int,
	@MaNCC int,
	@MaNH nchar(10)
as
begin
    begin tran
    set transaction isolation level read uncommitted
    select nl1.*
          ,ctncc.Gia
    from   NguyenLieu nl1
          ,ChiTietNCC ctncc
    where  nl1.MaNL = ctncc.MaNL
           and nl1.MaNH = @MaNH
           and ctncc.MaNCC = @MaNCC
           and nl1.MaNL not in (select nl.MaNL
                                from   NguyenLieu nl
                                      ,ChiTietDatHang ct
                                where  nl.MaNL = ct.MaNL
                                       and ct.MaHoaDon = @MaHoaDon
                                       and nl.MaNH = @MaNH)
    order by
           nl1.TenNL
    
    commit tran
end

go

