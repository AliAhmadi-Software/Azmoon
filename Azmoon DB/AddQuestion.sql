create proc AddQuestion
@groupid int,
@questiontext nvarchar(max),
@case1 nvarchar(max),
@case2 nvarchar(max),
@case3 nvarchar(max),
@case4 nvarchar(max),
@answer nvarchar(max)
AS
insert into TblQuestion(GroupID,QuestionText,Case1,Case2,Case3,Case4,Answer) values(@groupid,@questiontext,@case1,@case2,@case3,@case4,@answer)
Go
