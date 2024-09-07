create proc MyBackup
@path nvarchar(500)
AS
backup Database DBAzmoon to disk = @path with Init
go