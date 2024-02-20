create or alter procedure dbo.RecipeDelete
(
	@RecipeId int,
	@Message varchar (500) = '' output
)
as 
begin
declare @return int = 0

	begin try
		begin tran
		delete RecipeMealCourse where RecipeId = @RecipeId
			delete RecipeCookbook where RecipeId = @RecipeId
	delete RecipeIngredient where RecipeId = @RecipeId
	delete RecipeInstruction where RecipeId = @RecipeId
	delete Recipe where RecipeId = @RecipeId
		commit
	end try
	begin catch 
		rollback;
		throw
	end catch
	return @return
end 
go 