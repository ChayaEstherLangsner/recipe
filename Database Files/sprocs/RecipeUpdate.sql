--AF Nice job!  See how I formatted the indentation, indenting makes the sproc much easier to read and easier to understand the structure with the 'if else' statement
create or alter proc dbo.RecipeUpdate
(
@RecipeID int  output,
@UsersID int,
@CuisineID int,
@RecipeName varchar(50),
@RecipeCalories int
)
as
begin 
    select @RecipeID = isnull(@RecipeID, 0)
    if (@RecipeID = 0)
    begin
        insert Recipe(RecipeName,UsersID , CuisineID, RecipeCalories)
        values (@RecipeName, @UsersID, @CuisineID, @RecipeCalories)
        select @RecipeID = SCOPE_IDENTITY()
    end
    else 
    begin
        update Recipe 
        set 
        RecipeName = @RecipeName,
        UsersID = @UsersID, 
        CuisineID = @CuisineID, 
        RecipeCalories = @RecipeCalories
    where RecipeID = @RecipeID
    end
end 
go