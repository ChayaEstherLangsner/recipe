--AS Amazing job, 100% Please see comments, no need to resubmit.
--AS Name your sproc the table name plus get, therefore call it RecipeGet in singular. 
--AS Put the column names first before the @All param.
create or alter procedure RecipeGet(@RecipeID int = 0, @RecipeName varchar (50) = '', @All bit = 0)
as 
begin
--AS Indent the select statement so it is neater and easier to read.
	select @RecipeName = nullif(@RecipeName, '')
--AS Put your from clause on the next line.
	select r.RecipeID, r.UsersID, r.CuisineID,  r.RecipeName, r.RecipeCalories, RecipeDateDrafted, r.RecipeDatePublished, r.RecipeStatus, r.RecipePicture 
	from Recipe r 
	where r.RecipeID = @RecipeID
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
end
go


/*
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = '' --return no results

exec RecipeGet @RecipeName = 'a'

declare @ID int

select top 1 @ID = r.RecipeID from Recipe r


exec RecipeGet @RecipeID = @ID
*/

