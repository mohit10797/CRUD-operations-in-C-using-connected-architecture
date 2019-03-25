alter proc insert_address @id int, @fname varchar(50), @lname varchar(50), @email varchar(50), @phone char(10)
as begin
insert into Address_Book (Address_id, First_Name, Last_Name, Email, Phone) values (@id, @fname, @lname, @email, @phone)
return 1
end

alter proc update_email @id int, @email varchar(50)
as begin
update Address_Book set Email = @email where Address_id = @id
return 1
end

create proc delete_address @id int
as begin
delete Address_Book where Address_id = @id
end 
