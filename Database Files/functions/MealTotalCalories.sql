--AF Great job!  Please see how I added indentation, I recommend indenting all the code inside the function, it makes it easier to see what's part of the function
create or alter function dbo.MealTotalCalories(@MealID int)
returns int
as
begin
    
    declare @Value int

    select @Value = sum(r.RecipeCalories) 
    from Recipe r 
    join RecipeMealCourse rmc
    on r.RecipeID = rmc.RecipeID 
    join MealCourse mc
    on mc.MealCourseID = rmc.MealCourseID
    where mc.MealID  = @MealID
    group by mc.MealID 

return @Value 
end
go

select MealCalories = dbo.MealTotalCalories(m.MealID), *
from Meal m

  