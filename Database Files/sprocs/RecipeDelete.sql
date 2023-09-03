create or alter procedure dbo.RecipeDelete
(
	@RecipeID int,
	@Message varchar (500) = '' output
)
as 
begin
declare @return int = 0

	if exists(select * from recipe r where r.RecipeID = @RecipeID and( r.RecipeStatus = 'Published' or (r.RecipeStatus = 'Archived' and  datediff(DAY,r.RecipeDateArchived, getdate()) <= 30)))
	begin 
	select @return = 1, @Message = 'Cannot delete recipe that is currently published or archived for less than or equal to 30 days'
	goto finished 
	end
	select * from recipe
	begin try
		begin tran
	delete RecipeIngredient where RecipeID = @RecipeID
	delete RecipeInstruction where RecipeID = @RecipeID
	delete Recipe where RecipeID = @RecipeID
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch

	finished:
	return @return
end 
go 