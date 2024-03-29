USE [RecipeDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IdENTIFIER ON
GO
create or ALTER   procedure [dbo].[UsersGet](@UsersId int = 0, @UserName varchar (50) = '', @All bit = 0)
as 
begin
	select @UserName = nullif(@UserName, '')
	select u.UsersId, u.UserFirstName, u.UserLastName, u.UserName 
	from Users u 
	where u.UsersId = @UsersId
or @All = 1
	or u.UserName like '%' + @UserName + '%'
end
/*

exec UsersGet

exec UsersGet @All = 1

exec UsersGet @UserName = '' --return no results

exec UsersGet @UserName = 'a'

declare @Id int

select top 1 @Id = u.UsersId from Users u

exec UsersGet @UsersId = @Id
*/
