create or ALTER   procedure [dbo].[AutoCreateCookbook](
	@UserId int ,
	@Message varchar(500) = ''  output
)
as
begin
	declare @NewCookbookId int = 0 

	select @UserId = isnull(@UserId,0)


	if @UserId <> 0
	begin

		insert Cookbook(UsersID, CookbookName, CookbookPrice, IsActive, CookbookDateInserted)
		select @UserId, concat('Recipes by ', UserFirstName, ' ', UserLastName), count(*) * 1.33, 1, getdate()
		from Users u 
		join Recipe r
		on u.UsersID = r.UsersID
		where u.UsersID = @UserId
		group by u.UsersID, u.UserFirstName, u.UserLastName

		
		select @NewCookbookId= scope_Identity()

		insert RecipeCookbook (RecipeID, CookbookID, RecipeCookbookSequence)
		select r.RecipeID, @NewCookbookId, ROW_NUMBER() over(order by recipename)
		from Users u 
		 join Recipe r 
		 on u.UsersID = r.UsersID
		 where u.UsersID = @UserId
		 order by r.RecipeName



	end
	
	select * from Cookbook
	where CookbookID = @NewCookbookId

end