create table Product (
	productId int primary key, 
	sellerId int, 
	type char(100), 
	name char(100), 
	price int, 
	image varbinary(max),
);

create table ProductDetail ( 
	productId int references Product(productId) unique, 
	originalPrice int, 
	condition char(100), 
	warrantyPolicy char(100), 
	dateBought date, 
	Brand char(100), 
	Origin char(100), 
	Description char(1000),
);