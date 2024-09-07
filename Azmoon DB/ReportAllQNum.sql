create proc ReportAllQNum
AS
Select GroupName,COUNT(TblQuestion.GroupID) QuestionNum from TblQuestion INNER JOIN TblGroup
ON TblQuestion.GroupID = TblGroup.GroupID Group By GroupName
Go  