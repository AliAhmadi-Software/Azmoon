create proc EditGroup
@groupid int,
@groupname nvarchar(50)
AS
update TblGroup set GroupName=@groupname where GroupID=@groupid
go