create or alter proc RecipeSummaryGet 
 (@Message varchar (500) = '' output) 

 as
select r.RecipeId, RecipeName, RecipeStatus, UserName = concat(UserFirstName, ' ', UserLastName), RecipeCalories, NumIngredients = count(ri.RecipeIngredientId)
from Users u 
left join Recipe r  
on r.UsersId = u.UsersId
left join RecipeIngredient ri 
on ri.RecipeId = r.RecipeId
where RecipeName is not null
group by r.RecipeId, RecipeName, RecipeStatus, UserFirstName, UserLastName, RecipeCalories
order by RecipeStatus desc
 go 
 exec RecipeSummaryGet

