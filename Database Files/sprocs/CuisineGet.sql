USE [RecipeDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IdENTIFIER ON
GO
create or ALTER   procedure [dbo].[CuisineGet](@CuisineId int = 0, @CuisineType varchar (50) = '', @All bit = 0)
as 
begin
	select @CuisineType = nullif(@CuisineType, '')
	select c.CuisineId, c.CuisineType 
	from Cuisine c 
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineType like '%' + @CuisineType + '%'
end 
/*

exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineType = '' --return no results

exec CuisineGet @CuisineType = 'a'

declare @Id int

select top 1 @Id = c.CuisineId from Cuisine c

exec CuisineGet @CuisineId = @Id
*/
