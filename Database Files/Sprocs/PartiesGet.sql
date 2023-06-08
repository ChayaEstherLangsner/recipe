create or alter procedure PartiesGet(@PartyID int = 0, @All bit = 0, @PartyName varchar (50) = '')
as 
begin
select @PartyName = nullif(@PartyName, '')
select p.PartyName, p.YearPartyStarted from Party p
where p.PartyID = @PartyID
or @All = 1
or p.PartyName like '%' + @PartyName + '%'
end
go


/*
exec PartiesGet

exec PartiesGet @All = 1

exec PartiesGet @PartyName = '' --return no results

exec PartiesGet @PartyName = 'a'

declare @ID int

select top 1 @ID = p.PartyID from Party P


exec PartiesGet @PartyID = @ID
*/

