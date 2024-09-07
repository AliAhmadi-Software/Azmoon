create proc ReportOneGroupQnum
@groupid int
AS
Select GroupName,COUNT(TblQuestion.GroupID) QuestionNum from TblQuestion INNER JOIN TblGroup
ON TblQuestion.GroupID = TblGroup.GroupID  where TblQuestion.GroupID = @groupid
 Group By GroupName
 go