create or alter procedure MedalistsGet(@MedalistID int = 0, @All bit = 0, @LastName varchar (50) = '')
as 
begin
select @LastName = nullif(@LastName, '')
select m.OlympicYear, m.Season, m.OlympicLocation, m.Sport, m.SportSubcategory, m.Country, m.FirstName, m.LastName from Medalist m
where m.MedalistId = @MedalistID
or @All = 1
or m.LastName like '%' + @LastName + '%'
order by m.OlympicYear, m.Season, m.Sport, m.SportSubcategory, m.Country, m.LastName
end
go


/*
exec MedalistsGet

exec MedalistsGet @All = 1

exec MedalistsGet @LastName = '' --return no results

exec MedalistsGet @LastName = 'a'

declare @ID int

select top 1 @ID = m.MedalistId from Medalist m


exec MedalistsGet @MedalistID = @ID
*/

