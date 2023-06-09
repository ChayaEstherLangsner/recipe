USE [RecipeDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create or ALTER   procedure [dbo].[UsersGet](@UsersID int = 0, @UserName varchar (50) = '', @All bit = 0)
as 
begin
	select @UserName = nullif(@UserName, '')
	select u.UsersID, u.UserFirstName, u.UserLastName, u.UserName 
	from Users u 
	where u.UsersID = @UsersID
or @All = 1
	or u.UserName like '%' + @UserName + '%'
end
/*

exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UserName = '' --return no results

exec UsersGet @UserName = 'a'

declare @ID int

select top 1 @ID = u.UsersID from Users u

exec UsersGet @UsersID = @ID
*/
