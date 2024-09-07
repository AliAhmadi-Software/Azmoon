USE [DBAzmoon]
GO
/****** Object:  StoredProcedure [dbo].[CheckQuestionNum]    Script Date: 2/26/2020 1:53:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[CheckQuestionNum]
@groupid int,
@questionnum int,
@result int output
AS
declare @totalquestion int
select  @totalquestion = COUNT (*) from TblQuestion where GroupID=@groupid
if (@questionnum > @totalquestion)
set @result = 0
else
begin
set @result = 1
select TOP(@questionnum) * from TblQuestion where GroupID=@groupid
order by NEWID()
end
