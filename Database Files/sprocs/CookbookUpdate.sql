create or alter proc dbo.CookbookUpdate
(
@CookbookId int  output,
@UsersId int,
@CookbookName varchar(50),
@CookbookPrice decimal(6,2),
@IsActive bit output,
@CookbookDateInserted datetime = '' output 
)
as
begin 

	select @CookbookId = isnull(@CookbookId, 0)

	if (@CookbookId = 0)
		begin
			 insert Cookbook(CookbookName,UsersId , CookbookPrice, IsActive, CookbookDateInserted)
			 values (@CookbookName, @UsersId, @CookbookPrice, @IsActive, GETDATE())

			 select @CookbookId = SCOPE_IdENTITY()
		end
	else 
		begin
			update Cookbook 
			set CookbookName = @CookbookName,
			UsersId = @UsersId, 
			CookbookPrice = @CookbookPrice, 
			IsActive = @IsActive,
			CookbookDateInserted = GETDATE()
			where CookbookID = @CookbookId
		end

	select @CookbookDateInserted = CookbookDateInserted
	from Cookbook
	where CookbookID = @CookbookId

end 
go
