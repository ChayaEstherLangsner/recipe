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
