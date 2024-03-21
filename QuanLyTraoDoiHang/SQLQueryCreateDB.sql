
--drop table UserTable;
--go
create table UserTable (
	userId int primary key,
	personalId varchar(100),
	name nvarchar(100), 
	birthday date, 
	email nvarchar(100), 
	phone nvarchar(100), 
	gender int, 
	address nvarchar(100), 
	image varbinary(max),
	dateJoined date,
);
go
--drop table Product ;
--go

create table Product (
	productId int primary key, 
	sellerId int references UserTable(userId), 
	category nvarchar(100), 
	name nvarchar(100), 
	price int, 
	image varbinary(max),
	originalPrice int, 
	condition nvarchar(100), 
	warrantyPolicy nvarchar(100), 
	dateBought date, 
	Brand nvarchar(100), 
	Origin nvarchar(100), 
	Description nvarchar(2000),
);
go


--drop table Account;
--go
create table Account (
	userId int references UserTable(userId) unique, 
	username nvarchar(100) primary key, 
	password nvarchar(100)
);
go