--AF Nice work!  Please format the function by indenting as I recommended in other places
create or alter function dbo.RecipeInfo(@RecipeID int)
returns varchar (120)
as
begin
declare @Value varchar(120) = ''

;with ingredientamounts as(
select NumOfIngredients = count(ri.IngredientID), ri.RecipeID
from RecipeIngredient ri
group by ri.RecipeID
),
stepamounts as( 
select NumOfSteps = count(rn.RecipeInstructionID), rn.RecipeID
from RecipeInstruction rn
group by rn.RecipeID
)

--AF What you did above works, but can be shortened.  It would be neater to drop the ctes.  You can just select the distinct count of recipeingredientid here, same for recipe steps
select @Value = concat( r.RecipeName, ' (', c.CuisineType ,') has ', ia.NumOfIngredients, ' ingredients and ', sa.NumOfSteps, ' steps.')
from Recipe r 
join Cuisine c
on c.CuisineID = r.CuisineID
join RecipeIngredient ri
on ri.RecipeID = r.RecipeID
join ingredientamounts ia
on ia.RecipeID = r.RecipeID
join stepamounts sa
on sa.RecipeID = r.RecipeID
where r.RecipeID = @RecipeID
--AF PLease remove the extra line breaks below, one line break is enough




return @Value 
end
go

select RecipeInfo = dbo.RecipeInfo(r.RecipeID)
from Recipe r 


