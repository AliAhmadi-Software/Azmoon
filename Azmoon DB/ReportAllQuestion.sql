create proc ReportAllQuestion
AS
select GroupName,TblQuestion.GroupID,QuestionText,Case1,Case2,Case3,Case4,
Answer from TblQuestion INNER JOIN TblGroup ON TblQuestion.GroupID = TblGroup.GroupID
go