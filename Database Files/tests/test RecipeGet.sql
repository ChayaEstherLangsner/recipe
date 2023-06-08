
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = '' --return no results

exec RecipeGet @RecipeName = 'a'

declare @ID int

select top 1 @ID = r.RecipeID from Recipe r


exec RecipeGet @RecipeID = @ID


