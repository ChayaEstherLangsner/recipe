create or alter procedure dbo.CookbookDelete
(
	@CookbookId int,
	@Message varchar (500) = '' output
)
as 
begin
	begin try
		begin tran
	delete RecipeCookbook where CookbookID  = @CookbookId
	delete Cookbook where CookbookID = @CookbookId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch

end 
go 