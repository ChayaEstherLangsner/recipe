create or alter procedure dbo.CookbookRecipeGet(
	@RecipeCookbookId int = 0,
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeCookbookId = isnull(@RecipeCookbookId,0), @CookbookId = isnull(@CookbookId, 0)

select rc.RecipeCookbookId, rc.CookbookId, rc.RecipeCookbookSequence, rc.RecipeId
from RecipeCookbook rc
where RecipeCookbookId = @RecipeCookbookId
	or @All = 1
	or rc.CookbookID = @CookbookId

	return @return
end
go