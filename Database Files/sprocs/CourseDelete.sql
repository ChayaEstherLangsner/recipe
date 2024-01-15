create or alter procedure dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CourseId = isnull(@CourseId,0)


		begin try
		begin tran

	delete rmc
	from RecipeMealCourse rmc 
	join MealCourse mc 
	on rmc.MealCourseID = mc.MealCourseID
	where CourseID = @CourseId

	delete MealCourse where CourseID = @CourseId
	delete MealCourse where CourseID = @CourseId

	delete Course where CourseID = @CourseId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch


	return @return
end
go