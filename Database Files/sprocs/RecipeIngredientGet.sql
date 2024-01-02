create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@RecipeId, 0)

select RecipeIngredientId,  RecipeId, i.IngredientId, m.MeasurementId, ri.RecipeIngredientAmount, ri.RecipeIngredientSequence
from Ingredient i 
join RecipeIngredient ri 
on i.IngredientId = ri.IngredientId
join Measurement m 
on m.MeasurementId = ri.MeasurementId
where ri.RecipeIngredientId = @RecipeIngredientId
	or @All = 1
	or ri.RecipeId = @RecipeId

	return @return
end
go