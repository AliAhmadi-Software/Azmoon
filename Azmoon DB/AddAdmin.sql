create proc AddAdmin
@username nvarchar(50),
@pasword nvarchar(50),
@result int output
AS
if(EXISTS(select * from TblAdmin where UserName=@username))
set @result=1
else
begin
set @result=0
insert into TblAdmin(UserName,Pasword) values (@username,@pasword)
end
Go