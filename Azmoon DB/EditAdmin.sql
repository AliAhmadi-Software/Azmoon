create proc EditAdmin
@username nvarchar(50),
@pasword nvarchar(50)
AS
update TblAdmin set Pasword=@pasword where UserName=@username
Go