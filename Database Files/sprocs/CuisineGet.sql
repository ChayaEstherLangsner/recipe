USE [RecipeDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create or ALTER   procedure [dbo].[CuisineGet](@CuisineID int = 0, @CuisineType varchar (50) = '', @All bit = 0)
as 
begin
	select @CuisineType = nullif(@CuisineType, '')
	select c.CuisineID, c.CuisineType 
	from Cuisine c 
	where c.CuisineID = @CuisineID
	or @All = 1
	or c.CuisineType like '%' + @CuisineType + '%'
end 
/*

exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineType = '' --return no results

exec CuisineGet @CuisineType = 'a'

declare @ID int

select top 1 @ID = c.CuisineID from Cuisine c

exec CuisineGet @CuisineID = @ID
*/
