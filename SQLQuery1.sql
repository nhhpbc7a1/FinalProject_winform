drop table OrderTable;
go

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
	status nvarchar(100),
	totalprice int
);
go
drop table OrderItem;
go
create table OrderItem (
	orderId int references OrderTable(orderId),
	productId int references Product(productId),
);
drop table CancelProduct;
go
create table CancelProduct
(
	orderId int references OrderTable(orderId),
	productId int references Product(productId),
	reasonCancel nvarchar(1000)
);
drop table Rating;
go

create table Rating (
	ratingId int primary key,
	senderUserId int references UserTable(userId),
	receiverUserId int references UserTable(userId),
	orderId int references OrderTable(OrderId),
	productId int references Product(ProductId),
	marks int,
	detail nvarchar(1000),
);
