create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @CuisineId = isnull(@CuisineId,0)
	


		begin try
		begin tran

	delete rc 
	from RecipeCookbook rc 
	join Recipe r 
	on rc.RecipeID = r.RecipeID
	join Cuisine c 
	on c.CuisineID = r.CuisineID
	where c.CuisineID = @CuisineId
	
	delete rmc 
	from RecipeMealCourse rmc
	join Recipe r 
	on rmc.RecipeID = r.RecipeID
	join Cuisine c 
	on c.CuisineID = r.CuisineID
	where c.CuisineID = @CuisineId


	delete ri 
	from RecipeIngredient ri 
	join Recipe r 
	on ri.RecipeID = r.RecipeID
	where r.CuisineID = @CuisineId

	delete ri
	from RecipeInstruction ri 
	join Recipe r 
	on ri.RecipeID = r.RecipeID
	where r.CuisineID = @CuisineId

	delete Recipe where CuisineID = @CuisineId

	delete Cuisine where CuisineID = @CuisineId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch

	return @return
end
go