create or alter procedure CurrentRecipeStatusUpdate 
(@RecipeId int, 
@Status varchar(20),
@RecipeDateDrafted datetime = '' output , 
@RecipeDatePublished datetime = '' output, 
@RecipeDateArchived datetime = '' output)
as
if @Status = 'Drafted'
begin 
update Recipe
set RecipeDateDrafted = GETDATE(),
RecipeDatePublished = null,
RecipeDateArchived = null
where RecipeID = @RecipeId
end
else if @Status = 'Published'
begin
update Recipe
set RecipeDatePublished = getdate(),
RecipeDateArchived = null
where RecipeID = @RecipeId
end
if @Status = 'Archived'
begin
declare @CurrentStatus varchar(20)
select @CurrentStatus = RecipeStatus from Recipe
where RecipeID = @RecipeId
if @CurrentStatus = 'Drafted'
begin
update Recipe
set RecipeDatePublished = GETDATE() ,
RecipeDateArchived = GETDATE()
where RecipeID = @RecipeId
end
if @CurrentStatus = 'Published'
begin
update Recipe
set RecipeDateArchived = GETDATE()
where RecipeID = @RecipeId
end


select
@RecipeDateDrafted = RecipeDateDrafted, 
@RecipeDatePublished = RecipeDatePublished,
@RecipeDateArchived = RecipeDateArchived
from Recipe
where RecipeID = @RecipeId

end

