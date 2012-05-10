create proc UpdateNguyenLieu_UnreapeatableRead  @soluong int,@ma int
as
begin
begin tran
update NguyenLieu set soluongton=@soluong where manl=@ma
commit
end

select * from nguyenlieu
exec UpdateNguyenLieu_UnreapeatableRead 100,1
select * from nguyenlieu
--drop proc UpdateNguyenLieu_UnreapeatableRead
