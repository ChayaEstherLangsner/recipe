use RecipeDB
go 
delete RecipeMealCourse
delete MealCourse
delete Meal 
delete Course 
delete RecipeInstruction
delete RecipeIngredient
delete RecipeCookbook
delete Cookbook
delete Recipe 
delete Ingredient 
delete Cuisine
delete Measurement 
delete Users

insert Users(UserFirstName, UserLastName, UserName)
select 'John', 'Smith', 'John S.'
union select 'Mike', 'Adams', 'Mike A.'
union select 'Daniel', 'Jacob', 'Daniel J.'

insert Measurement(MeasurementType)
select 'Cup'
union select 'Tsp' 
union select 'Unit' 
union select 'Tbsp' 
union select 'Oz'
union select 'Clove' 
union select 'Pinch' 
union select 'Club' 
union select 'Stick'

insert Cuisine (CuisineType)
select 'American'
union select 'French'
union select 'English' 

insert Ingredient (IngredientName)
select 'sugar'
union select 'oil'
union select 'Egg'
union select 'Flour'
union select 'Vanilla sugar'
union select 'Baking powder'
union select 'Baking soda'
union select 'Chocolate chips'
union select 'Granny smith apple'
union select 'Vanilla yogurt'
union select 'Sugar'
union select 'Orange juice'
union select 'Honey'
union select 'Ice cube'
union select 'Bread'
union select 'Butter'
union select 'Shredded cheese'
union select 'Garlic (crushed)'
union select 'Black pepper'
union select 'Salt'

;
with x as 
(
    select UserName = 'John S.', CuisineType = 'American', RecipeName = 'Chocolate Chip Cookies', RecipeCalories = 800, RecipeDatePublished = null, RecipeDateArchived = null 
    union select 'John S.', 'French', 'Apple Yogurt Smoothie', 600,'12/10/2024' , null
    union select 'Daniel J.', 'English', 'Cheese Bread', 950, '12/11/2024', '12/13/2024' 
)
insert Recipe (UsersID, CuisineID, RecipeName, RecipeCalories, RecipeDatePublished, RecipeDateArchived)
select u.UsersID, c.CuisineID, x.RecipeName, x.RecipeCalories, x.RecipeDatePublished, x.RecipeDateArchived
from x 
join Users u
on x.UserName = u.UserName
join Cuisine c
on x.CuisineType = c.CuisineType
;
with x as 
(
    select UserName = 'Mike A.', CookbookName = 'Treats for two', CookbookPrice = 30, IsActive = 1
    union select 'Mike A.', 'Tasty Meals', '45', 1
    union select 'John S.', 'Easy Meals', 35, 1
)
insert Cookbook (UsersID, CookbookName, CookbookPrice, IsActive)
select u.UsersID, x.CookbookName, x.CookbookPrice, x.IsActive
from x 
join Users u 
on x.UserName = u.UserName

;
with x as 
(
    select RecipeName = 'Chocolate Chip Cookies', CookbookName = 'Treats for two', RecipeCookbookSequence = 1
    union select 'Chocolate Chip Cookies', 'Tasty Meals', 1
    union select 'Apple Yogurt Smoothie', 'Tasty Meals', 2
    union select 'Apple Yogurt Smoothie', 'Easy Meals', 1
    union select 'Cheese Bread', 'Treats for two', 2
    union select 'Cheese Bread', 'Tasty Meals', 3
    union select 'Cheese Bread', 'Easy Meals', 2
)
insert RecipeCookbook (RecipeID, CookbookID, RecipeCookbookSequence)
select r.RecipeID, c.CookbookID, x.RecipeCookbookSequence
from x 
join Recipe r 
on x.RecipeName = r.RecipeName
join Cookbook c 
on x.CookbookName = c.CookbookName

;
with x as 
(
    select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'Sugar', RecipeIngredientSequence = 1, MeasurementType = 'Cup', RecipeIngredientAmount = 1
    union select 'Chocolate Chip Cookies', 'Oil', 2, 'Cup', .5
    union select 'Chocolate Chip Cookies', 'Egg', 3, 'Unit', 3
    union select 'Chocolate Chip Cookies', 'Flour', 4, 'Cup', 2
    union select 'Chocolate Chip Cookies', 'Vanilla sugar', 5, 'Tsp', 1
    union select 'Chocolate Chip Cookies', 'Baking powder', 6, 'Tsp', 2
    union select 'Chocolate Chip Cookies', 'Baking soda', 7, 'Tsp', .5
    union select 'Chocolate Chip Cookies', 'chocolate chips', 8, 'Cup', 1
    union select 'Apple Yogurt Smoothie', 'Granny smith apple', 1, 'Unit', 3
    union select 'Apple Yogurt Smoothie', 'Vanilla yogurt', 2, 'Cup', 2
    union select 'Apple Yogurt Smoothie', 'Sugar', 3, 'Tsp', 2
    union select 'Apple Yogurt Smoothie', 'Orange juice', 4, 'Cup', .5
    union select 'Apple Yogurt Smoothie', 'Honey', 5, 'Tbsp', 2
    union select 'Apple Yogurt Smoothie', 'Ice cube', 6, 'Unit', 5
    union select 'Cheese Bread', 'Bread', 1, 'Club', 1
    union select 'Cheese Bread', 'Butter', 2, 'Oz', 4
    union select 'Cheese Bread', 'shredded cheese', 3, 'Oz', 8
    union select 'Cheese Bread', 'Garlic (crushed)', 4, 'Clove', 2
    union select 'Cheese Bread', 'Black pepper', 5, 'Tsp', .25
    union select 'Cheese Bread', 'Salt', 6, 'Pinch', 1
)
insert RecipeIngredient (RecipeID, IngredientID, RecipeIngredientSequence, MeasurementID, RecipeIngredientAmount)
select r.RecipeID, i.IngredientID, x.RecipeIngredientSequence, m.MeasurementID, x.RecipeIngredientAmount
from x 
join Recipe r 
on x.RecipeName = r.RecipeName 
join Ingredient i 
on x.IngredientName = i.IngredientName
join Measurement m 
on m.MeasurementType = x.MeasurementType
;
with x as 
(
    select RecipeName = 'Chocolate Chip Cookies', RecipeInstructionNumber = 1, RecipeInstructionDesc = 'First combine sugar, oil and eggs in a bowl'
    union select 'Chocolate Chip Cookies', 2, 'mix well'
    union select 'Chocolate Chip Cookies', 3, 'add flour, vanilla sugar, baking powder and baking soda'
    union select 'Chocolate Chip Cookies', 4, 'beat for 5 minutes'
    union select 'Chocolate Chip Cookies', 5, 'add chocolate chips'
    union select 'Chocolate Chip Cookies', 6, 'freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies', 7, 'roll into balls and place spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies', 8, 'bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'pour into glasses.'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'wrap bread into a foil and bake for 30 minutes.'
)
insert RecipeInstruction (RecipeID, RecipeInstructionNumber, RecipeInstructionDesc)
select r.RecipeID, x.RecipeInstructionNumber, x.RecipeInstructionDesc 
from x 
join Recipe r 
on x.RecipeName = r.RecipeName

insert Course (CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Main course', 2
union select 'Dessert', 3

;
with x as 
(
    select UserName = 'John S.', MealName = 'Breakfast Bash', IsActive = 1
    union select 'Mike A.', 'Fancy Lunch', 1
    union select 'Mike A.', 'Amazing Supper', 1
)
insert Meal (UsersID, MealName, IsActive)
select u.UsersID,  x.MealName, x.IsActive
from x 
join Users u 
on x.UserName = u.UserName

;
with x as 
(
    select MealName =  'Breakfast Bash', CourseName = 'Appetizer'
    union select 'Breakfast Bash', 'Main course'
    union select 'Fancy Lunch', 'Main course'
    union select 'Fancy Lunch', 'Dessert'
    union select 'Amazing Supper', 'Appetizer'
    union select 'Amazing Supper', 'Main course'
    union select 'Amazing Supper', 'Dessert'
)
insert MealCourse (MealID, CourseID)
select m.MealID, c.CourseID
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName

;
with x as 
(
    select MealName =  'Breakfast Bash', CourseName = 'Appetizer', RecipeName = 'Apple Yogurt Smoothie', IsMainDish = 1
    union select 'Breakfast Bash', 'Main course', 'Cheese Bread', 1
    union select 'Fancy Lunch', 'Main course', 'Apple Yogurt Smoothie', 0
    union select 'Fancy Lunch', 'Main course', 'Cheese Bread', 1
    union select 'Fancy Lunch', 'Dessert', 'Chocolate Chip Cookies', 1
    union select 'Amazing Supper', 'Appetizer', 'Chocolate Chip Cookies', 1
    union select 'Amazing Supper', 'Main course', 'Cheese Bread', 1
    union select 'Amazing Supper', 'Dessert', 'Apple Yogurt Smoothie', 1
)
insert RecipeMealCourse (MealCourseID, RecipeID, IsMainDish)
select mc.MealCourseID, r.RecipeID, x.IsMainDish
from x 
join Meal m 
on x.MealName = m.MealName
join Course c 
on x.CourseName = c.CourseName
join MealCourse mc 
on m.MealID = mc.MealID
and c.CourseID = mc.CourseID 
join Recipe r 
on x.RecipeName = r.RecipeName

