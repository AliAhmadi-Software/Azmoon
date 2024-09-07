create proc DeleteQuestion
@questionid int
AS
delete from TblQuestion where QuestionID=@questionid
Go