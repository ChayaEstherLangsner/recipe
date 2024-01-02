create or alter proc CookbookSummaryGet 
 (@Message varchar (500) = '' output) 

 as
select c.CookbookName, Author = concat(u.UserFirstName, ' ', u.UserLastName), NumRecipes = count(r.RecipeId) ,c.CookbookPrice 
from Cookbook c
join Users u 
on c.UsersId = u.UsersId
join RecipeCookbook r
on c.CookbookId = r.CookbookId
group by c.CookbookName, UserFirstName, u.UserLastName,c.CookbookPrice 
 go 
 exec CookbookSummaryGet
