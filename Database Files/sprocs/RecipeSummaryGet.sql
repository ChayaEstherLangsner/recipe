create or alter proc RecipeSummaryGet 
 (@Message varchar (500) = '' output) 

 as
select r.RecipeID, RecipeName, RecipeStatus, UserName = concat(UserFirstName, ' ', UserLastName), RecipeCalories, numIngredients = count(ri.RecipeIngredientID)
from Users u 
left join Recipe r  
on r.UsersID = u.UsersID
left join RecipeIngredient ri 
on ri.RecipeID = r.RecipeID
group by r.RecipeID, RecipeName, RecipeStatus, UserFirstName, UserLastName, RecipeCalories
order by RecipeStatus desc
 go 
 exec RecipeSummaryGet

