--AS Great job! 98% Please see comments and resubmit.
--AS Put the column names first before the @All param.
create or alter procedure UsersGet(@UsersID int = 0, @UserName varchar (50) = '', @All bit = 0)
as 
begin
	select @UserName = nullif(@UserName, '')
	select u.UsersID, u.UserFirstName, u.UserLastName, u.UserName 
	from Users u 
	where u.UsersID = @UsersID
	or @All = 1
--AS -2 The UserName should not allow blanks all together.
	or u.UserName like '%' + @UserName + '%'
end
go


/*
exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UserName = '' --return no results

exec UsersGet @UserName = 'a'

declare @ID int

select top 1 @ID = u.UsersID from Users u

exec UsersGet @UsersID = @ID
*/
