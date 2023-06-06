
exec CuisineGet

exec CuisineGet @All = 1

exec CuisineGet @CuisineType = '' --return no results

exec CuisineGet @CuisineType = 'a'

declare @ID int

select top 1 @ID = c.CuisineID from Cuisine c

exec CuisineGet @CuisineID = @ID

