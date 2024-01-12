create or ALTER   procedure [dbo].[CookbookGet](@CookbookId int = 0, @CookbookName varchar (50) = '', @All bit = 0)
as 
begin
	select @CookbookName = nullif(@CookbookName, '')
	select c.CookbookId, c.CookbookName, c.CookbookPrice, c.IsActive, c.UsersId, c.CookbookDateInserted
	from Cookbook c
	where c.CookbookID = @CookbookId
	or @All = 1
	or c.CookbookName like '%' + @CookbookName + '%'
end