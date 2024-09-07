create proc EditQuestion
@questionid int,
@groupid int,
@questiontext nvarchar(max),
@case1 nvarchar(max),
@case2 nvarchar(max),
@case3 nvarchar(max),
@case4 nvarchar(max),
@answer int
AS
update TblQuestion set GroupID=@groupid,QuestionText=@questiontext,Case1=@case1,Case2=@case2,Case3=@case3,Case4=@case4,Answer=@answer where QuestionID=@questionid
Go 