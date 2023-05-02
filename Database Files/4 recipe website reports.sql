--AF Perfect! 100%
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.

Home Page
    One resultset with number of recipes, meals, and cookbooks
*/

select NumOfCookbooks = count( distinct c.CookbookID), NumOfMeals = count( distinct m.MealID), NumOfRecipes = count(distinct r.RecipeID)
from Cookbook c
cross join Meal m
cross join Recipe r

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived (blank if not archived), user, number of calories and number of ingredients.
*/
;
with x as 
(
    select NumOfIngredients = count(IngredientID), RecipeID
    from RecipeIngredient ri 
    group by ri.RecipeID
)

select r.RecipeName, r.RecipePicture, RecipeStatus =
    case r.RecipeStatus
    when 'Archived' then concat ('<span style="color:gray">',r.RecipeName, '</span>')
    else r.RecipeStatus
    end,
    r.RecipeDatePublished, RecipeDateArchived = isnull(convert(varchar,r.RecipeDateArchived),''), r.UsersID, r.RecipeCalories, x.NumOfIngredients
from x 
join Recipe r 
on x.RecipeID = r.RecipeID
join RecipeIngredient ri 
on r.RecipeID = ri.RecipeID
where r.RecipeDatePublished is not null 
or r.RecipeDateArchived is not null 
order by r.RecipeStatus desc

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
;
with x as 
(
    select NumOfIngredients = count(rit.RecipeIngredientID), rit.RecipeID
    from RecipeIngredient rit 
    group by rit.RecipeID
), 
y as 
(
    select NumOfInstuctions = count(rin.RecipeInstructionID), rin.RecipeID
    from RecipeInstruction rin 
    group by rin.RecipeID
)

select r.RecipeName, r.RecipePicture, r.RecipeCalories, x.NumOfIngredients, y.NumOfInstuctions
from x 
join Recipe r 
on x.RecipeID = r.RecipeID 
join y 
on y.RecipeID = r.RecipeID 
where r.RecipeName = 'Cheese Bread'


select ri.RecipeIngredientSequence, ListOfIngredients = concat(ri.RecipeIngredientAmount, ' ', m.MeasurementType, ' ',i.IngredientName), i.IngredientPicture
from Ingredient i 
join RecipeIngredient ri 
on ri.IngredientID = i.IngredientID
join Measurement m 
on m.MeasurementID = ri.MeasurementID
join Recipe r 
on r.RecipeID = ri.RecipeID
where r.RecipeName = 'Cheese Bread'
order by ri.RecipeIngredientSequence

select r.RecipeName, r.RecipePicture, ri.RecipeInstructionNumber, ri.RecipeInstructionDesc
from recipe r 
join RecipeInstruction ri
on r.RecipeID = ri.RecipeID
where r.RecipeName = 'Cheese Bread'
order by ri.RecipeInstructionNumber

/*
Meal list page:
    All active meals, meal name, user that created meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
;
with x as 
(
    select m.MealName, NumOfCalories = sum(r.RecipeCalories), NumOfCourse = count(mc.CourseID), NumOfRecipes =  count(rmc.RecipeID)
    from meal m 
    join MealCourse mc 
    on m.MealID = mc.MealID 
    join RecipeMealCourse rmc 
    on rmc.MealCourseID = mc.MealCourseID 
    join Recipe r 
    on r.RecipeID = rmc.RecipeID
    group by m.MealName
)

select m.MealName, m.MealPicture,u.UserName, x.NumOfCalories, x.NumOfCourse, x.NumOfRecipes
from x 
join Meal m 
on x.MealName = m.MealName
join Users u 
on u.UsersID = m.MealID
where m.IsActive = 1
order by m.MealName


/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes. 
            Display in one column the course type, recipe, and for the main course show which dish is the main and which are side. 
			In this format "Course Type: Main\Side dish - Recipe Name. Then main dishes should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
select m.MealName, m.MealPicture, u.UserName, m.MealDateInserted
from Meal m 
join Users u
on u.UsersID = m.UsersID
where m.MealName = 'Breakfast Bash'



    select r.RecipeName, RecipeDesc = case 
                        when rmc.IsMainDish = 1 and c.CourseName = 'Main course' then concat('<b>',c.CourseName,': Main dish - ', r.RecipeName, '</b>')
                        when rmc.IsMainDish = 0 and c.CourseName = 'Main course' then concat(c.CourseName,': Side dish - ', r.RecipeName) 
                        else concat(c.CourseName,': ', r.RecipeName) end 
    from RecipeMealCourse rmc 
    join Recipe r 
    on r.RecipeID = rmc.RecipeID
    join MealCourse mc 
    on mc.MealCourseID = rmc.MealCourseID
    join Course c 
    on mc.CourseID = c.CourseID
    join Meal m 
    on m.MealID = mc.MealID
    and m.MealName = 'Breakfast bash'


/*

Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select c.CookbookName, c.CookbookPicture, u.UserName, NumOfRecipes = count(rc.RecipeID)
from Cookbook c
join RecipeCookbook rc 
on rc.CookbookID = c.CookbookID
join Users u 
on u.UsersID = c.UsersID
where c.IsActive = 1 
group by c.CookbookName, u.UserName, c.CookbookPicture
order by c.CookbookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  Note: User will click on recipe to see all ingredients and steps.
*/

select c.CookbookName, c.CookbookPicture ,u.UserName, c.CookbookDateInserted, c.CookbookPrice, NumOfRecipes =  count(rc.RecipeID)
from Cookbook c 
join Users u 
on c.UsersID = u.UsersID
join RecipeCookbook rc 
on rc.CookbookID = c.CookbookID 
where c.CookbookName = 'Easy Meals'
group by c.CookbookName, u.UserName, c.CookbookDateInserted, c.CookbookPrice, c.CookbookPicture

;
with x as 
(
    select NumOfIngredients = count(ri.IngredientID), ri.RecipeID
    from RecipeIngredient ri
    group by ri.RecipeID
),
y as 
(
    select NumOfInstructions = count(rn.RecipeInstructionID), rn.RecipeID
    from RecipeInstruction rn 
    group by rn.RecipeID
)

select c.CookbookName, c.CookbookPicture, rc.RecipeCookbookSequence, r.RecipeName, r.RecipePicture, cu.CuisineType, x.NumOfIngredients, y.NumOfInstructions
from x 
join Recipe r 
on x.RecipeID = r.RecipeID
join y 
on y.RecipeID = r.RecipeID 
join RecipeCookbook rc 
on r.RecipeID = rc.RecipeID 
join Cookbook c 
on c.CookbookID = rc.CookbookID 
join Cuisine cu 
on cu.CuisineID = r.CuisineID 
where c.CookbookName = 'Easy Meals'
order by rc.RecipeCookbookSequence



/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name proper cased. There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
    b) When the user clicks on a specific recipe they should see a list of the first ingredient of each recipe in the system, 
       and a list of the last step in each recipe in the system

*/
select distinct ReversedRecipeName = concat(upper(substring(reverse(r.RecipeName), 1, 1)), lower(substring(reverse(r.RecipeName), 2, 50))), 
                ReversedRecipePicture = concat ('recipe-', replace (concat(upper(substring(reverse(r.RecipeName), 1, 1)), lower(substring(reverse(r.RecipeName), 2, 50))), ' ', '-'), '.jpg')
from Recipe r 
join RecipeCookbook rc 
on rc.RecipeID = r.RecipeID
join Cookbook c 
on rc.CookbookID = c.CookbookID

;
with x as 
(
    select FirstIngredient = min(ri.RecipeIngredientSequence), r.RecipeName
    from RecipeIngredient ri 
    join Recipe r 
    on r.RecipeID = ri.RecipeID
    group by r.RecipeName
)
select ri.RecipeIngredientSequence, i.IngredientName
from recipe r 
join RecipeIngredient ri 
on ri.RecipeID = r.RecipeID
join Ingredient i 
on i.IngredientID = ri.IngredientID
join x 
on x.RecipeName = r.RecipeName 
and x.FirstIngredient = ri.RecipeIngredientSequence
;
with x as 
(

    select LastInstruction = max(rn.RecipeInstructionNumber), r.RecipeName
    from Recipe r 
    join RecipeInstruction rn 
    on rn.RecipeID = r.RecipeID
    group by r.RecipeName
)
select ri.RecipeInstructionNumber, ri.RecipeInstructionDesc
from Recipe r 
join RecipeInstruction ri 
on ri.RecipeID = r.RecipeID
join x 
on x.LastInstruction = ri.RecipeInstructionNumber
and r.RecipeName = x.RecipeName

 
/*
For site administration page:
--5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if none
	b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) List of how many meals each user created and whether they're active or inactive. Show 0 if none
    d) List of how many cookbooks each user created and whether they're active or inactive. Show 0 if none
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
select NumOfRecipes = count(r.RecipeID), u.UserName, r.RecipeStatus
from Users u 
left join Recipe r 
on u.UsersID = r.UsersID
group by u.UserName, r.RecipeStatus

select NumOfRecipes = count(r.RecipeID), u.UserName, AvgDaysTillPublished = avg(datediff(dd,convert(date, r.RecipeDateDrafted), convert(date,r.RecipeDatePublished)))
from Users u 
left join Recipe r 
on u.UsersID = r.UsersID
group by u.UserName

select NumOfMeals =  count(m.MealID), u.UserName, IsActive = case m.IsActive when 1 then 'Active' when 0 then 'Inactive' end
from Users u 
left join Meal m 
on m.UsersID = u.UsersID
group by u.UserName, m.IsActive

select NumOfCookbooks = count(c.CookbookID), u.UserName, IsActive = case c.IsActive when 1 then 'Active' when 0 then 'Inactive' end
from Users u 
left join Cookbook c 
on c.UsersID = u.UsersID
group by u.UserName, c.IsActive

select r.RecipeName, r.RecipePicture, DaysFromDraftedToArchived = datediff(dd,convert(date, r.RecipeDateDrafted), convert(date,r.RecipeDateArchived))
from Recipe r 
where r.RecipeDateArchived is not null and r.RecipeDatePublished is null  
/*
For user dashboard page:
    a) Show number of the user's recipes, meals and cookbooks. 
    b) List of their recipes, display the status and the number of hours between the status it's in and the one before that. Show null if recipe has the status drafted.
    c) Count of their recipes per cuisine. Show 0 for none.
*/
;
with y as 
(
select NumOfMeals = count(m.MealID), u.UserName
from Users u 
left join meal m 
on m.UsersID = u.UsersID
group by UserName 
),
z as 
(
    select NumOfCookbooks = count(c.CookbookID), u.UserName
    from Users u 
    left join Cookbook c 
    on c.UsersID = u.UsersID
   group by UserName 
)
select u.UserName, NumOfRecipes = count(r.RecipeID), y.NumOfMeals, z.NumOfCookbooks
from Users u 
left join Recipe r 
on r.UsersID = u.UsersID
join y 
on u.UserName = y.UserName 
join z 
on z.UserName = y.UserName
group by u.UserName, y.NumOfMeals, z.NumOfCookbooks 

select u.UserName, r.RecipeName, r.RecipePicture, r.RecipeStatus, HoursFromPreviousStatus = case 
    when r.RecipeStatus ='Drafted' then null 
    when r.RecipeStatus = 'Published' then datediff(hour,convert(date, r.RecipeDateDrafted), convert(date,r.RecipeDatePublished))
    when r.RecipeStatus ='Archived' and r.RecipeDatePublished is null then datediff(hour,convert(date, r.RecipeDateDrafted), convert(date,r.RecipeDateArchived))
    else datediff(hour,convert(date, r.RecipeDatePublished), convert(date,r.RecipeDateArchived))
    end 
from Users u 
join Recipe r 
on u.UsersID = r.UsersID

select NumOfRecipes = count(r.RecipeID), c.CuisineType, u.UserName
from Users u
left join Recipe r 
on r.UsersID = u.UsersID
left join Cuisine c
on r.CuisineID = c.CuisineID
group by c.CuisineType, u.UserName


