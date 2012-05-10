create proc ReadNguyenLieu_UnrepeatableRead
as
begin
begin tran
select MaNL,TenNL,SoLuongTon from nguyenlieu
waitfor delay '0:0:5'
select MaNL,TenNL,SoLuongTon from nguyenlieu
commit 
end



exec ReadNguyenLieu_UnrepeatableRead
--drop proc ReadNguyenLieu_UnrepeatableRead