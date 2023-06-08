USE [RecipeDB]
GO
/****** Object:  StoredProcedure [dbo].[CuisineGet]    Script Date: 6/7/2023 9:19:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--AS Nice work! 100% Please see comments, no need to resubmit.
--AS Name your sproc the table name plus get, therefore call it CuisineGet in singular. 
--AS Put the column names first before the @All param.

ALTER   procedure [dbo].[CuisineGet](@CuisineID int = 0, @CuisineType varchar (50) = '', @All bit = 0)
as 
begin
	select @CuisineType = nullif(@CuisineType, '')
--AS Put the from clause on the next line.
	select c.CuisineID, c.CuisineType 
	from Cuisine c 
	where c.CuisineID = @CuisineID
	or @All = 1
	or c.CuisineID like '%' + @CuisineType + '%'
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
