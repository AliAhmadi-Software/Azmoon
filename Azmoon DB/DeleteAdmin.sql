create proc DeleteAdmin
@username nvarchar(50)
AS
delete  from TblAdmin where UserName=@username
Go