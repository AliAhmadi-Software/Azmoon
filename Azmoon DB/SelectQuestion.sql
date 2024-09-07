create proc SelectAllQuestionByGroup
@groupid int
AS
Select * from TblQuestion where GroupID=@groupid
Go