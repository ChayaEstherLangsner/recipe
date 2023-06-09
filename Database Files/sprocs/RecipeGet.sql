USE [RecipeDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create or ALTER   procedure [dbo].[RecipeGet](@RecipeID int = 0, @RecipeName varchar (50) = '', @All bit = 0)
as 
begin
	select @RecipeName = nullif(@RecipeName, '')
	select r.RecipeID, r.UsersID, r.CuisineID,  r.RecipeName, r.RecipeCalories, RecipeDateDrafted, r.RecipeDatePublished, r.RecipeDateArchived,r.RecipeStatus, r.RecipePicture 
	from Recipe r 
	where r.RecipeID = @RecipeID
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
end
/*

exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = '' --return no results

exec RecipeGet @RecipeName = 'a'

declare @ID int

select top 1 @ID = r.RecipeID from Recipe r

exec RecipeGet @RecipeID = @ID
*/