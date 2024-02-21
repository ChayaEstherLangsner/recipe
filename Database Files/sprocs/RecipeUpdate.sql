create or alter proc dbo.RecipeUpdate
(
@RecipeId int  output,
@UsersId int,
@CuisineId int,
@RecipeName varchar(50),
@RecipeCalories int,
@RecipeStatus varchar(20) = '' output
)
as
begin 

	select @RecipeId = isnull(@RecipeId, 0)

	if (@RecipeId = 0)
	begin
		insert Recipe(RecipeName,UsersId , CuisineId, RecipeCalories)
		values (@RecipeName, @UsersId, @CuisineId, @RecipeCalories)

		select @RecipeId = SCOPE_IdENTITY()
	end

	else 
	begin
		update Recipe 
		set RecipeName = @RecipeName,
		UsersId = @UsersId, 
		CuisineId = @CuisineId, 
		RecipeCalories = @RecipeCalories
		where RecipeId = @RecipeId
	end

end 
 go
