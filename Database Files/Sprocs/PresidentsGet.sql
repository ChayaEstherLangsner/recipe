create or alter procedure PresidentsGet(@PresidentID int = 0, @All bit = 0, @LastName varchar (50) = '')
as 
begin
select @LastName = nullif(@LastName, '')
select p.PresidentId, p.PartyID, p.Num, p.FirstName, p.LastName, p.DateBorn, p.DateDied, p.TermStart, p.TermEnd, p.AgeAtDeath, p.YearsServed, p.NumFullTermsServed from president p
where p.PresidentId = @PresidentID
or @All = 1
or p.LastName like '%' + @LastName + '%'
end
go


/*
exec PresidentsGet
select * from president
exec PresidentsGet @All = 1

exec PresidentsGet @LastName = '' --return no results

exec PresidentsGet @LastName = 'a'

declare @ID int

select top 1 @ID = p.PresidentId from President p


exec PresidentsGet @PresidentID = @ID
*/

