USE [RecipeDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IdENTIFIER ON
GO
create or ALTER   procedure [dbo].[RecipeGet](@RecipeId int = 0, @RecipeName varchar (50) = '', @All bit = 0)
as 
begin
	select @RecipeName = nullif(@RecipeName, '')
	select r.RecipeId as RecipeId, r.UsersId, r.CuisineId,  r.RecipeName, r.RecipeCalories, RecipeDateDrafted, r.RecipeDatePublished, r.RecipeDateArchived,r.RecipeStatus, r.RecipePicture 
	from Recipe r 
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
end
/*

select * from recipe
exec RecipeGet

exec RecipeGet @All = 1

exec RecipeGet @RecipeName = '' --return no results

exec RecipeGet @RecipeName = 'a'

declare @Id int

select top 1 @Id = r.RecipeId from Recipe r

exec RecipeGet @RecipeId = @Id
*/