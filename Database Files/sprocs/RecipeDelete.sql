create or alter procedure dbo.RecipeDelete
(
	@RecipeId int,
	@Message varchar (500) = '' output
)
as 
begin
declare @return int = 0

	if exists(select * from recipe r where r.RecipeId = @RecipeId and( r.RecipeStatus = 'Published' or (r.RecipeStatus = 'Archived' and  datediff(DAY,r.RecipeDateArchived, getdate()) <= 30)))
	begin 
	select @return = 1, @Message = 'Cannot delete recipe that is currently published or archived for less than or equal to 30 days'
	goto finished 
	end
	select * from recipe
	begin try
		begin tran
	delete RecipeIngredient where RecipeId = @RecipeId
	delete RecipeInstruction where RecipeId = @RecipeId
	delete Recipe where RecipeId = @RecipeId
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