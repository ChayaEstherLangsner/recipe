create or ALTER   procedure [dbo].[RecipeStepUpdate](
	@RecipeStepId int  output,
	@RecipeId int ,
	@RecipeStepDesc varchar(250) ,
	@RecipeStepSequence int, 
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeStepId = isnull(@RecipeStepId,0)

	if @RecipeStepId = 0
	begin
		insert RecipeInstruction(RecipeId, RecipeInstructionDesc, RecipeInstructionNumber)
		values(@RecipeId, @RecipeStepDesc, @RecipeStepSequence)

		select @RecipeStepId= scope_Identity()
	end
	else
	begin
		update RecipeInstruction
		set
			RecipeId = @RecipeId, 
			RecipeInstructionDesc = @RecipeStepDesc, 
			RecipeInstructionNumber = @RecipeStepSequence
		where RecipeInstructionID = @RecipeStepId
	end

	return @return
end
