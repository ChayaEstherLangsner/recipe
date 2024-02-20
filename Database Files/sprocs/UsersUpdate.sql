create or alter procedure dbo.UsersUpdate(
	@UsersId int  output,
	@UserFirstName varchar (100),
	@UserLastName varchar (100),
	@UserName varchar (100),
	@Message varchar(500) = ''  output
	)
as
begin
	declare @return int = 0

	select @UsersId = isnull(@UsersId,0)

	if @UsersId = 0
	begin
		insert Users(UserFirstName, UserLastName, UserName)
		values(@UserFirstName, @UserLastName,@UserName)

		select @UsersId= scope_identity()
	end
	else
	begin
		update Users
		set
		UserFirstName = @UserFirstName, 
		UserLastName = @UserLastName,
			UserName = @UserName
		where UsersId = @UsersId
	end

	return @return
end
go
