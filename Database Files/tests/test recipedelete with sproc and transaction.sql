set nocount on
declare @RecipeID int

select top 1 @RecipeID = r.RecipeID
from Recipe r
join RecipeIngredient ri
on r.RecipeID = ri.RecipeID
join RecipeInstruction rn
on rn.RecipeID = r.RecipeID
 join RecipeCookbook rc
on rc.RecipeID = r.RecipeID
order by r.RecipeID

select 'recipe', r.RecipeID, r.RecipeName from Recipe r where r.RecipeID = @RecipeID
union select 'ingredient', ri.IngredientID, i.IngredientName from RecipeIngredient ri  join Ingredient i on i.IngredientID  = ri.IngredientID where ri.RecipeID = @RecipeID
union select 'instruction', rn.RecipeInstructionID, rn.RecipeInstructionDesc from RecipeInstruction rn where rn.RecipeID = @RecipeID
union select 'cookbook', rc.CookbookID , c.CookbookName from RecipeCookbook rc join Cookbook c on c.CookbookID = rc.CookbookID where rc.RecipeID = @RecipeID

exec RecipeDelete @RecipeID = @RecipeID

select 'recipe', r.RecipeID, r.RecipeName from Recipe r where r.RecipeID = @RecipeID
union select 'ingredient', ri.IngredientID, i.IngredientName from RecipeIngredient ri  join Ingredient i on i.IngredientID  = ri.IngredientID where ri.RecipeID = @RecipeID
union select 'instruction', rn.RecipeInstructionID, rn.RecipeInstructionDesc from RecipeInstruction rn where rn.RecipeID = @RecipeID
union select 'cookbook', rc.CookbookID , c.CookbookName from RecipeCookbook rc join Cookbook c on c.CookbookID = rc.CookbookID where rc.RecipeID = @RecipeID
