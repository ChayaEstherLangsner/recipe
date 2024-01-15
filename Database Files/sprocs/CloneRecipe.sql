create or ALTER   procedure [dbo].[CloneRecipe](
	@RecipeId int ,
	@Message varchar(500) = ''  output
)
as
begin
	declare @NewRecipeId int = 0 

	select @RecipeId = isnull(@RecipeId,0)


	if @RecipeId <> 0
	begin
		insert Recipe( UsersID, CuisineID, RecipeName, RecipeCalories, RecipeDateDrafted)
		select UsersID, CuisineID, RecipeName + ' - Clone', RecipeCalories, getdate()
		from Recipe r 
		where RecipeID = @RecipeId

		select @NewRecipeId= scope_Identity()

		insert RecipeIngredient(RecipeID, IngredientID, RecipeIngredientSequence, MeasurementID, RecipeIngredientAmount)
		select @NewRecipeId, IngredientID, RecipeIngredientSequence, MeasurementID, RecipeIngredientAmount
		from RecipeIngredient where RecipeID = @RecipeId

		insert RecipeInstruction (RecipeID, RecipeInstructionNumber, RecipeInstructionDesc)
		select @NewRecipeId, RecipeInstructionNumber, RecipeInstructionDesc
		from RecipeInstruction where RecipeID = @RecipeId
	end
	
	select * from Recipe
	where RecipeID = @NewRecipeId

end