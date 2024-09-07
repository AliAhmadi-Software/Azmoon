create proc SelectFilterQuestion
@listquestion varchar(500)
AS
declare @myquestion varchar(500)
set @myquestion ='select * from TblQuestion where QuestionID IN (' + @listquestion + ')'
exec(@myquestion)
go