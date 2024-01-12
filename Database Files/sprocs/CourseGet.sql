USE [RecipeDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IdENTIFIER ON
GO
create or ALTER   procedure [dbo].[CourseGet](@CourseId int = 0, @CourseName varchar (50) = '', @All bit = 0)
as 
begin
	select @CourseName = nullif(@CourseName, '')
	select c.CourseId, c.CourseName, c.CourseSequence
	from Course c 
	where c.CourseID = @CourseId
	or @All = 1
	or c.CourseName like '%' + @CourseName + '%'
end 