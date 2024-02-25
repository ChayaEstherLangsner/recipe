create or alter procedure dbo.UsersDelete(
	@UsersId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId,0)


		begin try
		begin tran

		delete rmc
		from RecipeMealCourse rmc 
		join MealCourse mc 
		on rmc.MealCourseID = mc.MealCourseID 
		join Meal m 
		on mc.MealID = m.MealID
		where UsersID = @UsersId

		delete mc
		from MealCourse mc
		join Meal m 
		on mc.MealID = m.MealID
		where UsersID = @UsersId

	delete Meal where UsersID = @UsersId

	delete rc 
	from RecipeCookbook rc 
	join Cookbook c 
	on rc.CookbookID = c.CookbookID
	where c.UsersID = @UsersId
	
	delete Cookbook where UsersID = @UsersId

			delete rmc
		from RecipeMealCourse rmc 
		join Recipe r
		on r.RecipeID = rmc.RecipeID 
		where UsersID = @UsersId

	delete rc 
	from RecipeCookbook rc 
	join Recipe r
	on rc.RecipeID = r.RecipeID
	where r.UsersID = @UsersId 

	delete ri 
	from RecipeIngredient ri 
	join Recipe r 
	on ri.RecipeID = r.RecipeID
	where r.UsersID = @UsersId

	delete ri
	from RecipeInstruction ri 
	join Recipe r 
	on ri.RecipeID = r.RecipeID
	where r.UsersID = @UsersId

	delete Recipe where UsersID = @UsersId

	delete Users where UsersID = @UsersId

		commit
	end try
	begin catch 
		rollback;
		throw
	end catch

	return @return
end
go
