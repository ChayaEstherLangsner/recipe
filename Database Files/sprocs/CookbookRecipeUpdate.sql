create or ALTER   procedure [dbo].[CookbookRecipeUpdate](
	@RecipeCookbookId int  output,
	@CookbookId int ,
	@RecipeId int ,
	@RecipeCookbookSequence int, 
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeCookbookId = isnull(@RecipeCookbookId,0)
	
	if @RecipeCookbookId = 0
	begin
		insert RecipeCookbook(CookbookID, RecipeID, RecipeCookbookSequence)
		values(@CookbookId, @RecipeId, @RecipeCookbookSequence)

		select @RecipeCookbookId= scope_Identity()
	end
	else
	begin
		update RecipeCookbook
		set
			CookbookID = @CookbookId, 
			RecipeID = @RecipeId, 
			RecipeCookbookSequence = @RecipeCookbookSequence
		where RecipeCookbookId = @RecipeCookbookId
	end

	return @return
end

