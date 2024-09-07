create proc AddGroup
@groupname nvarchar(50)
AS
insert into TblGroup (GroupName) values (@groupname)
go