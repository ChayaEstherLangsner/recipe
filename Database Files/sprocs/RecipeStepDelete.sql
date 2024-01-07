create or alter procedure dbo.RecipeStepDelete(
	@StepId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @StepId = isnull(@StepId,0)

	delete RecipeInstruction where RecipeInstructionID = @StepId

	return @return
end
go