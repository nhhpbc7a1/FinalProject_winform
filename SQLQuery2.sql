create table CancelProduct
(
	orderId int references OrderTable(orderId),
	productId int references Product(productId),
	reasonCancel nvarchar(1000)
);