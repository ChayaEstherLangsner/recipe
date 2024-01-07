create or ALTER   procedure [dbo].[RecipeIngredientUpdate](
	@RecipeIngredientId int  output,
	@RecipeId int ,
	@IngredientId int ,
	@RecipeIngredientSequence int, 
	@MeasurementId int, 
	@RecipeIngredientAmount decimal (6, 2),
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId, IngredientId, RecipeIngredientSequence, MeasurementId, RecipeIngredientAmount)
		values(@RecipeId, @IngredientId, @RecipeIngredientSequence, @MeasurementId, @RecipeIngredientAmount)

		select @RecipeIngredientId= scope_Identity()
	end
	else
	begin
		update RecipeIngredient
		set
			RecipeId = @RecipeId, 
			IngredientId = @IngredientId, 
			RecipeIngredientSequence = @RecipeIngredientSequence, 
			MeasurementId = @MeasurementId, 
			RecipeIngredientAmount = @RecipeIngredientAmount
		where RecipeIngredientId = @RecipeIngredientId
	end

	return @return
end


