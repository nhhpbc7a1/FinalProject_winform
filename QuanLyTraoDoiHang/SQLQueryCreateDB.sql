
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

--drop table CartItem;
--go

create table CartItem (
	userId int references UserTable(userId),
	productId int references Product(productId),
	primary key(userId, productId),
);
go

--drop table ReceiveInfo;
--go
create table ReceiveInfo(
	receiveId int primary key, 
	userId int references UserTable(userId), 
	name nvarchar(100), 
	phone varchar(20), 
	address nvarchar(200),
);
go
--drop table OrderTable;
--go

create table OrderTable (
	orderId int primary key, 
	buyerId int references UserTable(userId),
	sellerId int references UserTable(userId), 
	receiveId int references ReceiveInfo(receiveId), 
	time datetime,
	note nvarchar(2000), 
	shippingMethod nvarchar(100),
	shippingFee int,
	paymentMethod nvarchar(100), 
	status nvarchar(100)
);
go
--drop table Rating;
--go

create table Rating (
	ratingId int primary key,
	senderUserId int references UserTable(userId),
	receiverUserId int references UserTable(userId),
	orderId int references OrderTable(OrderId),
	productId int references Product(ProductId),
	marks int,
	detail nvarchar(1000),
);


--drop table OrderItem;
--go
create table OrderItem (
	orderId int references OrderTable(orderId),
	productId int references Product(productId),
);

--drop table detailImage
create table DetailImage (
	productId int references Product(productId),
	image varbinary(max),
);