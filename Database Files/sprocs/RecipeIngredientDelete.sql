create or alter procedure dbo.RecipeIngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @IngredientId = isnull(@IngredientId,0)

	delete RecipeIngredient where IngredientId = @IngredientId

	return @return
end
go