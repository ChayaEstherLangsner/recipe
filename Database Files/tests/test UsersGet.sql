exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UserName = '' --return no results

exec UsersGet @UserName = 'a'

declare @ID int

select top 1 @ID = u.UsersID from Users u

exec UsersGet @UsersID = @ID