create proc SearchForLogin
@username nvarchar(50),
@password nvarchar(50)
AS
select * from TblAdmin where UserName=@username AND Pasword=@password
Go 