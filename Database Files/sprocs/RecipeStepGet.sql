create or alter procedure dbo.RecipeStepGet(
	@RecipeStepId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeStepId = isnull(@RecipeStepId,0), @RecipeId = isnull(@RecipeId, 0)

select RecipeInstructionID as RecipeStepId,RecipeId, RecipeInstructionDesc as RecipeStepDesc, RecipeInstructionNumber as RecipeStepSequence
from RecipeInstruction ri 
where ri.RecipeInstructionID = @RecipeStepId
	or @All = 1
	or ri.RecipeId = @RecipeId

	return @return
end
go