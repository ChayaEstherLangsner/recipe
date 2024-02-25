USE [RecipeDB]
GO

create or ALTER   proc [dbo].[MealSummaryGet] 
 (@Message varchar (500) = '' output) 

 as

 select m.MealName,UserName = concat(u.UserFirstName, ' ', u.UserLastName),
 NumCalories = sum(r.RecipeCalories), NumCourses = count(mc.CourseID), NumRecipes = count(r.RecipeID)
 from Meal m 
 join Users u 
  on u.UsersID = m.UsersID
  join MealCourse mc 
  on mc.MealID = m.MealID
  join RecipeMealCourse rmc 
  on rmc.MealCourseID = mc.MealCourseID
  join Recipe r 
  on r.RecipeID = rmc.RecipeID
  group by m.MealName,u.UserFirstName,u.UserLastName
  order by m.mealname

