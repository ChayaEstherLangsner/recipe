--AF All good! 100%
--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.

delete rc  
from RecipeCookbook rc 
join Cookbook c 
on rc.CookbookID = c.CookbookID 
join Users u 
on u.UsersID = c.UsersID
where u.UserName = 'John S.' 

delete c
from Cookbook c 
join users u 
on c.UsersID = u.UsersID
where u.UserName = 'John S.'

delete rmc
from RecipeMealCourse rmc
join MealCourse mc 
on mc.MealCourseID = rmc.MealCourseID 
join Meal m 
on m.MealID = mc.MealID 
join Users u 
on u.UsersID = m.UsersID
where u.UserName = 'John S.'

delete mc 
from MealCourse mc 
join Meal m 
on m.MealID = mc.MealID
join Users u 
on u.UsersID = m.UsersID
where u.UserName = 'John S.'

delete m 
from Meal m 
join Users u 
on m.UsersID = u.UsersID 
where u.UserName = 'John S.'

delete rc 
from RecipeCookbook rc 
join Recipe r 
on r.RecipeID = rc.RecipeID 
join Users u 
on u.UsersID = r.UsersID
where u.UserName = 'John S.'

delete ri 
from RecipeIngredient ri
join Recipe r 
on ri.RecipeID = r.RecipeID 
join Users u 
on u.UsersID = r.UsersID 
where u.UserName = 'John S.'

delete rn 
from RecipeInstruction rn
join Recipe r 
on rn.RecipeID = r.RecipeID 
join Users u 
on u.UsersID = r.UsersID
where u.UserName = 'John S.'

delete rmc
from RecipeMealCourse rmc
join Recipe r 
on r.RecipeID =rmc.RecipeID
join Users u 
on u.UsersID = r.UsersID
where u.UserName = 'John S.'

delete r 
from Recipe r 
join Users u 
on r.UsersID = u.UsersID 
where u.UserName = 'John S.'

delete u 
from Users u 
where u.UserName = 'John S.'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.

insert Recipe(UsersID, CuisineID, RecipeName, RecipeCalories, RecipeDatePublished, RecipeDateArchived)
select r.UsersID, r.CuisineID, concat(RecipeName, ' - clone'), r.RecipeCalories, null, null 
from Recipe r 
where r.RecipeName = 'Cheese Bread'

insert RecipeInstruction(RecipeID, RecipeInstructionNumber, RecipeInstructionDesc) 
select (select r.RecipeID from Recipe r where r.RecipeName = 'Cheese Bread - clone'), rn.RecipeInstructionNumber, rn.RecipeInstructionDesc
from Recipe r 
join RecipeInstruction rn 
on rn.RecipeID = r.RecipeID
where r.RecipeName = 'Cheese Bread'

insert RecipeIngredient(RecipeID, IngredientID, RecipeIngredientSequence, MeasurementID, RecipeIngredientAmount) 
select (select r.RecipeID from Recipe r where r.RecipeName = 'Cheese Bread - clone'), ri.IngredientID, ri.RecipeIngredientSequence, ri.MeasurementID, ri.RecipeIngredientAmount
from RecipeIngredient ri 
join Recipe r 
on r.RecipeID = ri.RecipeID
where r.RecipeName = 'Cheese Bread'



/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
;
with x as 
(
	select NumOfRecipes = count(r.RecipeID), u.UserName
	from Recipe r 
	join Users u 
	on r.UsersID = u.UsersID
	where u.UserName = 'Daniel J.'
	group by u.UserName
)
insert Cookbook(UsersID, CookbookName, CookbookPrice, IsActive)
select UsersID = u.UsersID, CookbookName = concat('Recipes by ', u.UserFirstName, ' ', u.UserLastName), CookbookPrice = x.NumOfRecipes * 1.33, IsActive = 1
from x 
join Users u 
on x.UserName = u.UserName
where u.UserName = 'Daniel J.' 

insert RecipeCookbook(RecipeID, CookbookID, RecipeCookbookSequence)
select RecipeID = r.RecipeID, CookbookID = c.CookbookID, RecipeCookbookSequence = (ROW_NUMBER() over (order by r.RecipeName))
from Recipe r 
join Users u 
on r.UsersID = u.UsersID
join Cookbook c 
on c.UsersID = u.UsersID
where c.CookbookName = 'Recipes by Daniel Jacob'
and u.UserName = 'Daniel J.'


/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/

update r 
set RecipeCalories = case when m.MeasurementType = 'Tsp' then r.RecipeCalories + 2 * ri.RecipeIngredientAmount
			when m.MeasurementType = 'cup' then r.RecipeCalories + 50 * ri.RecipeIngredientAmount
			else r.RecipeCalories
			end
from recipe r 
join RecipeIngredient ri 
on ri.RecipeID = r.RecipeID
join Ingredient i 
on ri.IngredientID = i.IngredientID
join Measurement m 
on m.MeasurementID = ri.MeasurementID
where i.IngredientName = 'Sugar'
select * from Recipe


/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as 
(
	select AvgHoursFromDraftedToPublished = avg(datediff(hour, r.RecipeDateDrafted, r.RecipeDatePublished))
	from Recipe r 
	where r.RecipeDatePublished is not null
),

y as 
(
	select HoursFromDraftedToPublished = datediff(hour, r.RecipeDateDrafted, r.RecipeDatePublished), r.RecipeName, HoursFromDraftedToCurrentDate = datediff(hour, r.RecipeDateDrafted, getdate())
	from Recipe r

)

select u.UserFirstName, u.UserLastName, EmailAddress = lower(concat(left(u.UserFirstName, 1), u.UserLastName, '@heartyhearth.com')), 
		Alert = concat('Your recipe ', r.RecipeName, ' is sitting in draft for ', y.HoursFromDraftedToCurrentDate + 1, ' hours. That is ', y.HoursFromDraftedToCurrentDate - x.AvgHoursFromDraftedToPublished, ' hours more than the average ',AvgHoursFromDraftedToPublished, ' hours all other recipes took to be published.')
from x 
cross join Recipe r 
join y 
on y.RecipeName = r.RecipeName
join Users u 
on u.UsersID = r.UsersID
where r.RecipeDatePublished is null and r.RecipeDateArchived is null 
and x.AvgHoursFromDraftedToPublished < y.HoursFromDraftedToCurrentDate




/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and recieve a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
with x as 
(
	select NumOfCookbooks = count(c.CookbookID), AvgPrice = avg(c.CookbookPrice), SumPrice = sum(c.CookbookPrice)
	from Cookbook c 
)

select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(c.CookbookID),' books for sale, average price is ',avg(c.CookbookPrice),'. You can order them all and recieve a 25% discount, for a total of ',sum(c.CookbookPrice) * .75,'.
Click <a href = "www.heartyhearth.com/order/',newid(),'">here</a> to order.')
from Cookbook c 

