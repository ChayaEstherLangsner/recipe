create or alter procedure dbo.CookbookRecipeDelete(
	@RecipeCookbookId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeCookbookId = isnull(@RecipeCookbookId,0)

	delete RecipeCookbook where RecipeCookbookID = @RecipeCookbookId

	return @return
end
go