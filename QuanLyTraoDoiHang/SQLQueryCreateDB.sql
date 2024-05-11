
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

INSERT INTO [dbo].[UserTable] ([userId], [personalId], [name], [birthday], [email], [phone], [gender], [address], [image], [dateJoined]) VALUES (1, N'087204009570', N'Nhhuy', N'1990-01-30', N'skill0sp1@gmail.com', N'0783701185', 1, N'Binh Duong', null, N'0001-01-01')
INSERT INTO [dbo].[UserTable] ([userId], [personalId], [name], [birthday], [email], [phone], [gender], [address], [image], [dateJoined]) VALUES (2, N'123123', N'Thu Huong', N'2003-11-10', N'22110040@student.vn', N'123123', 0, N'Dong Nai', null, N'0001-01-01')
INSERT INTO [dbo].[UserTable] ([userId], [personalId], [name], [birthday], [email], [phone], [gender], [address], [image], [dateJoined]) VALUES (3, N'123456789010', N'khanh', N'2000-10-19', N'khanh@gmail.com', N'0987654321', 0, N'', null, N'2024-05-02')
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
	PostedDate datetime,
	SearchCounter int,
);
go

INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (1, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:44:31', 78)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (2, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 1', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:04', 78)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (3, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 2', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:09', 467)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (4, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 3', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:14', 229)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (5, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 4', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:20', 229)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (6, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 5', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:25', 467)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (7, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 6', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:31', 467)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (8, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 7', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:36', 466)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (9, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 8', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:41', 466)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (10, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 9', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:46', 469)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (11, 1, N'Electronic Devices', N'Điện Thoại Samsung Galaxy A14 5G (4GB + 128GB) - Hàng chính hãng 10', 3490000,null, 5190000, N'99%, fullbox, không trầy xướt', N'2 years', N'2024-04-10', N'Samsung', N'Viet Nam', N'Thông số kỹ thuật

Pin: 5000 mAH

Bộ nhớ: 4GB/128GB - Hỗ trợ thẻ nhớ ngoài: MicroSD (Hỗ trợ tối đa 1TB)

Camera Sau: 50.0 MP + 2.0 MP + 2.0MP

Camera trước: 13.0 MP

Hiển thị: Kích thước 6.6"

Bộ vi xử lý: Mediatek 700 - Octa-core 2.2 GHz', N'2024-04-21 21:46:51', 84)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (20, 2, N'Electronic Devices', N'Điện thoại Apple iPhone 15 Pro 128GB', 26090000,null, 28990000, N'new 100% full box, không trầy xước', N'2 years', N'2024-05-02', N'Apple', N'USA', N'Thông số kỹ thuật:

- 6.1″

- Màn hình Super Retina XDR

- Màn hình Luôn Bật

- Công nghệ ProMotion

- Titan với mặt sau bằng kính nhám

- Nút Tác Vụ

- Dynamic Island

- Chip A17 Pro với GPU 6 lõi

- SOS Khẩn Cấp 

- Phát Hiện Va Chạm

- Pin: Thời gian xem video lên đến 29 giờ

- USB‑C: Hỗ trợ USB 3 cho tốc độ truyền tải nhanh hơn đến 20x', N'2024-05-02 12:19:15', 22)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (21, 2, N'Smart Phone', N'Điện thoại Apple iPhone 14 Pro 128GB', 17090000,null, 24990000, N'new 100% full box, không trầy xước', N'2 years', N'2024-05-02', N'Apple', N'USA', N'Thông số kỹ thuật:

- 6.1″

- Màn hình Super Retina XDR

- Màn hình Luôn Bật

- Công nghệ ProMotion

- Titan với mặt sau bằng kính nhám

- Nút Tác Vụ

- Dynamic Island

- Chip A17 Pro với GPU 6 lõi

- SOS Khẩn Cấp 

- Phát Hiện Va Chạm

- Pin: Thời gian xem video lên đến 29 giờ

- USB‑C: Hỗ trợ USB 3 cho tốc độ truyền tải nhanh hơn đến 20x', N'2024-05-02 12:22:20', 290)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (22, 2, N'Smart Phone', N'Điện thoại Apple iPhone 13 Pro 128GB', 13090000,null, 24990000, N'new 100% full box, không trầy xước', N'2 years', N'2024-05-02', N'Apple', N'USA', N'Thông số kỹ thuật:

Màn hình: OLED6.1"Super Retina XDR

Hệ điều hành: iOS 15

Camera sau: 2 camera 12 MP

Camera trước: 12 MP

Chip: Apple A15 Bionic

RAM: 4 GB

Bộ nhớ trong: 128 GB

SIM: 1 Nano SIM & 1 eSIMHỗ trợ 5G

Pin, Sạc: 20 W', N'2024-05-02 12:25:15', 290)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (23, 2, N'Mini Models', N'Mô Hình Tiểu Cảnh, Đèn Ngủ Trang Trí Totoro
', 100000,null, 150000, N'- 60%, Have some scratch on the surface of the glass. Just have been used for 1 month
', N'2 year', N'2024-05-02', N'no brand', N'japan', N'Đặc Điểm Nổi Bật : + Có thể dùng để trang trí nhà cửa và làm đèn ngủ + Bóng đèn có độ sáng vừa phải giúp bạn có một giấc ngủ thoải mái + Thiết kế nhỏ gọn và xinh xắn có thể đặt ở bàn hoặc kệ sách + Khiến căn phòng bạn trở nên dễ thương hơn với thiết kế mô phỏng giống hệt hai nhân vật nổi tiếng No Face CHÍNH SÁCH CỦA SHOP : + Luôn luôn đồng hành , hỗ trợ khách hàng trong suốt quá trình mua hàng và sử dụng sản phẩm + Đổi trả hàng trong vòng 7 ngày nếu sản phẩm bị looicx do nhà sản xuất + Tặng quà cho những khách hàng mua lại lần sau
', N'2024-05-02 13:25:12', 281)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (24, 2, N'Mini Models', N'JIASHI Đèn ngủ nhỏ trang trí bàn trang trí bóng thủy tinh quà tặng sinh nhật', 190000,null, 210000, N'80%, There is no sign of damage. Just have been used once', N'2 year', N'2024-05-02', N'no brand', N'japan', N'Chào mừng đến với cửa hàng của chúng tôi:
- Nếu quan tâm đến giá sỉ, bạn có thể chat riêng với chúng tôi.
- Khi nhận được hàng vui lòng nhấn chấp nhận.
-Đánh giá 5 sao rất đáng khích lệ cho cửa hàng của chúng tôi.
- Nếu khách hàng không hài lòng về hệ thống giao hàng. Vui lòng tách dịch vụ khỏi cửa hàng và công ty vận tải. vì cửa hàng thực sự không thể kiểm soát việc vận chuyển
- Nếu sản phẩm có vấn đề hoặc trong quá trình vận chuyển. Xin vui lòng liên hệ với cửa hàng của chúng tôi để được giúp đỡ và sửa chữa.
- Sản phẩm của chúng tôi có chất lượng cao và giá rẻ. Vì vậy, bạn không phải lo lắng rằng sản phẩm sẽ không phù hợp với hàng thật. Các sản phẩm có chất lượng cao và chắc chắn giá rẻ.
', N'2024-05-02 13:27:14', 281)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (25, 2, N'Mini Models', N'Đèn ngủ để bàn hình hoa tulip trong lồng kính decor phòng siêu đỉnh - Quà tặng người yêu', 95000,null, 150000, N'- 90%, There is no sign of damage. Just have been used once
', N'2 year', N'2024-05-02', N'no brand', N'japan', N'-LƯU Ý ; ĐÈN NGỦ CHƯA ĐƯỢC GHÉP SẴN , QUÝ KHÁCH VỀ PHẢI TỰ GHÉP Ạ ! - Đèn ngủ hình cây hoa tulip được làm thủ công 100% với thiết kế gọn gàng , xinh xắn sử dụng đèn led tiết kiệm điện và đế gỗ chắc chắn. đặc biệt đèn được thiết kế hình cây hoa rất tỉ mỉ , vừa làm đèn ngủ ban đêm , vừa làm đồ trang trí bàn làm việc hoặc kệ ban ngày . làm quà tặng ý nghĩa cho bạn gái , người thân , bạn bè . Ưu điểm nổi bật của sản phẩm : - Không tỏa nhiệt , an toàn cho người sử dụng và trẻ nhỏ - Sử dụng 3 pin AAA rất tiện lợi ( Shop có tặng kèm 3 pin , pin có thể mua ở bất kì quán tạp hóa nào ) * Chất liệu : Đế gỗ , vỏ thủy tinh * Màu sắc : chuẩn như trên ảnh
', N'2024-05-02 13:28:26', 286)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (26, 2, N'Mini Models', N' Mô hình 12 con giáp chibi cute biểu cảm dễ thương làm trang trí tiểu cảnh, quà tặng', 49000,null, 70000, N'70%, There is no sign of damage or scratch. 
', N'2 year', N'2024-05-02', N'no brand', N'japan', N'-Loại sản phẩm:12 CON GIÁP MÔ HÌNH MINI - Số lượng: 12 - Chất liệu: Thạch cao cứng - Đóng gói: Hộp carton bọc xốp chắc chắn - Kích thước: 3.5-4CM - Màu sắc: nhiều màu - Dành cho: mọi độ tuổi - Dành cho các dịp: Ngày lễ Kỷ niệm, đính hôn, quà tặng, quà lưu niệm, tiệc tùng, trường học, văn phòng
', N'2024-05-02 13:29:44', 275)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (27, 2, N'Mini Models', N'10 Cái  gói Trong Suốt Nhựa Trái Cây Flatback DIY Phụ Kiện ', 69000,null, 90000, N'80%, There is no sign of damage or scratch. Just have been used for 3 days
', N'2 year', N'2024-05-02', N'no brand', N'japan', N'-Loại: Mặt phẳng nhựa Chất liệu: Nhựa Màu sắc: như hình ảnh hiển thị Kích thước: như hình ảnh hiển thị Số lượng: (30g, 3,3) Sử dụng: Để trang trí DIY trên Scrapbooking, Craft, Hair, Cloth, Shoes, điện thoại di động, máy tính xách tay và túi xách, v.v. Lưu ý: Có thể có một chút khác biệt về màu sắc khi cài đặt độ tương phản màn hình led khác nhau. 1 inch = 25,4mm hoặc 1mm = 0,0393 inch Xin vui lòng cho phép sự khác biệt 1-3mm do đo lường thủ công, cảm ơn. Đóng gói bao gồm: 10 cái / gói X Resin Flatback
', N'2024-05-02 13:31:08', 275)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (28, 2, N'Mini Models', N'Bình Thủy Sinh Kèm Tượng Cô Gái Tập Yoga, Chậu Trồng Cây Thuỷ Sinh Để Bàn Làm Việc, Bàn học,...', 200000,null, 535000, N'-90%, There is no sign of damage. Just have been used for 2 days
', N'2 years', N'2024-02-05', N'no brand', N'Japan', N'-Bình Thủy Sinh Kèm Tượng Cô Gái Tập Yoga, Chậu Trồng Cây Thuỷ Sinh Để Bàn Làm Việc, Bàn học,... Chậu thủy sinh trồng cây mini để bàn, Lọ thủy tinh trồng cây thủy sinh, Bình thủy sinh Thích hợp trang trí bàn làm việc, bàn làm việc tại công ty, văn phòng, bàn học, tủ sách,... Thích hợp trồng các loại cây thủy sinh --Kích thước tổng thể: D13.5 x C11cm , --Kích thước chậu thủy tinh: D6.4 x C8 cm -- Chất liệu: Thủy tinh , composite
', N'2024-05-02 13:32:34', 275)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (29, 2, N'Car', N'Mitsu Attrage 1.2MT 2023 Lướt 7,500km Nhập Thái', 248500000,null, 355000000, N'Xe cá nhân, 1 chủ mua mới, Đi gia đình ko kinh doanh.
Bảo dưỡng bảo trì định kì đầy đủ tại hãng', N'2 years', N'2024-02-05', N'Mitsubishi', N'Thái Lan', N'"Xe cá nhân, 1 chủ mua mới, Đi gia đình ko kinh doanh.
Bảo dưỡng bảo trì định kì đầy đủ tại hãng.
Động cơ - hộp số - keo chỉ - gầm bệ nguyên bản chưa qua sửa chữa.

"', N'2024-05-02 13:36:52', 285)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (30, 2, N'Motorbike', N'GPX LEGEND 150 S- 202I.chính chủ xe classic pkl', 20930000,null, 29900000, N'Bảo Hành tận tình và chu đáo cho khách hàng.Bảo hành tận nơi tận nhà quý khách Hà Nội.', N'2 years', N'2024-02-05', N'GPX', N'Thái Lan', N'"Màu xanh sần thời trang, đời chót hàng đầu hiện nay Động cơ 150cc, năng động , Công nghệ fun xăng cơ, phanh đĩa to 1 kênh, máy êm cực mượt, đầm xe
Date cuối biển số TP odo thấp . Bảo hành đầy đủ 6 tháng
Bảo hành Cam kết xe đẹp- nguyên bản tuyệt đối
Cam kết xe không tai nạn, không ngập nước
HQCN. An ninh pháp lý quy chuẩn,sang tên ngay 
Có trao đổi giao lưu xe ga xe số"', N'2024-05-02 13:37:40', 281)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (31, 2, N'Pet', N'Poodle Tiny Chuẩn Xinh . Trắng Tinh Khô', 2100000,null, 3000000, N'5 tháng tuổi ( đã tiêm 1 mũi ngừa 5 bệnh kèm tây run ok đầy đủ cho khách )', N'2 years', N'2024-02-05', N'Chó Poodle', N'Việt Nam', N'"- lông cực dày , chân ngắn , mặt xinh , dày lông . Phồng
- chế độ bảo hành đầy đủ , tư vấn nhiệt tình khi cần thiết"', N'2024-05-02 13:39:38', 43)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (32, 2, N'Accessories', N'OMEGA SEAMASTER 231.23.39.21.02.001', 6300000,null, 9000000, N'Bảo Hành 5 Năm Tại Shop
Cam kết 100% chính hãng .Bao Check Tất Cả  Store Trên Toàn Quốc', N'2 years', N'2024-02-05', N'OMEGA', N'Nhật  Bản', N'"- Size: 38.5mm
- Máy Automatic
- Niềng, núm, kim, cọc số Vàng hồng khối 18k
- Chống nước: 150m
- G.iá new hãng đang bán rất cao ~ 210 triệu"', N'2024-05-02 13:42:51', 276)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (33, 2, N'Electronic Devices', N'Loa google nest audio', 10500000,null, 15000000, N'Tình trạng: Đã sử dụng (chưa sửa chữa)', N'3 tháng', N'2024-02-05', N'Google', N'Singapore', N'Tình trạng: đẹp full box', N'2024-05-02 13:45:01', 271)
INSERT INTO [dbo].[Product] ([productId], [sellerId], [category], [name], [price], [image], [originalPrice], [condition], [warrantyPolicy], [dateBought], [Brand], [Origin], [Description], [PostedDate], [SearchCounter]) VALUES (34, 2, N'Electronic Devices', N'Máy in màu Epson L120 4màu sắc nét cực căng đẹp', 3500000,null, 5000000, N'95% Tình trạng: Đã sử dụng', N'4 tháng', N'2024-02-05', N'Epson ', N'Thái Lan', N'Máy in màu Epson l120 là loại máy nhỏ gọn dùng cho học sinh sinh viên hộ gia đình kinh doanh chùa nhà thờ văn phòng nhỏ khởi nghiệp', N'2024-05-02 13:45:46', 259)
go
--drop table Account;
--go
create table Account (
	userId int references UserTable(userId) unique, 
	username nvarchar(100) primary key, 
	password nvarchar(100)
);
go

INSERT INTO [dbo].[Account] ([userId], [username], [password]) VALUES (2, N'huong', N'123123')
INSERT INTO [dbo].[Account] ([userId], [username], [password]) VALUES (1, N'huy', N'123123')
INSERT INTO [dbo].[Account] ([userId], [username], [password]) VALUES (3, N'khanh', N'123123')
go
--drop table CartItem;
--go

create table CartItem (
	userId int references UserTable(userId),
	productId int references Product(productId),
	primary key(userId, productId),
);
go
INSERT INTO [dbo].[CartItem] ([userId], [productId]) VALUES (2, 3)
INSERT INTO [dbo].[CartItem] ([userId], [productId]) VALUES (2, 10)
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
INSERT INTO [dbo].[ReceiveInfo] ([receiveId], [userId], [name], [phone], [address]) VALUES (1, 1, N'Nguyen Hoang Huy', N'0783701185', N'393, to 12, ap Tan Hau, xa Tan Thuan Tay, thanh pho Cao Lanh, tinh Dong Thap')
INSERT INTO [dbo].[ReceiveInfo] ([receiveId], [userId], [name], [phone], [address]) VALUES (2, 1, N'Nguyen Hoang Kiet', N'0339132788', N'45 Tan Lap, Dong Hoa, Di An, Binh duong ')
INSERT INTO [dbo].[ReceiveInfo] ([receiveId], [userId], [name], [phone], [address]) VALUES (3, 1, N'Nguyen Nguyen Toan Khoa', N'0987654321', N'Hoang Dieu 2, Linh Trung Thu Duc')
INSERT INTO [dbo].[ReceiveInfo] ([receiveId], [userId], [name], [phone], [address]) VALUES (4, 2, N'Le Thi Thu Huong', N'0123456789', N'5/3 112 Phuoc Long A, TP Thu Duc, Viet Nam')
INSERT INTO [dbo].[ReceiveInfo] ([receiveId], [userId], [name], [phone], [address]) VALUES (5, 1, N'Khoa', N'23123', N'Hoang Dieu 2, linh xuan, thu duc, viet nam')
INSERT INTO [dbo].[ReceiveInfo] ([receiveId], [userId], [name], [phone], [address]) VALUES (6, 3, N'Doan Minh Khanh', N'0987654321', N'Quan 3, Le Van Si, thanh pho Ho CHi Minh')
INSERT INTO [dbo].[ReceiveInfo] ([receiveId], [userId], [name], [phone], [address]) VALUES (7, 3, N'Le Thi Thu Huong', N'0987654321', N'5/3 112 Phuoc Long A, Thu Duc, HCM')
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
	status nvarchar(100),
	totalprice int
);
go
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (1, 2, 1, 4, N'2024-04-22 00:21:21', N'', N'Fast', 40000, N'', N'completed', 10510000)
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (2, 1, 2, 1, N'2024-05-02 13:49:35', N'', N'Standard', 20000, N'', N'completed', 26110000)
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (3, 3, 1, 7, N'2024-05-02 14:28:49', N'', N'Standard', 20000, N'', N'completed', 7000000)
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (4, 1, 2, 1, N'2024-05-02 14:30:42', N'', N'Standard', 20000, N'', N'completed', 2120000)
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (5, 1, 2, 8, N'2024-05-02 14:45:00', N'', N'Fast', 40000, N'', N'cancelled', 14040000)
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (6, 1, 2, 1, N'2024-05-09 01:28:37', N'', N'Standard', 20000, N'', N'cancelled', 3520000)
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (7, 1, 2, 1, N'2024-05-10 13:10:14', N'', N'Standard', 20000, N'', N'cancelled', 310000)
INSERT INTO [dbo].[OrderTable] ([orderId], [buyerId], [sellerId], [receiveId], [time], [note], [shippingMethod], [shippingFee], [paymentMethod], [status], [totalprice]) VALUES (8, 1, 2, 1, N'2024-05-10 14:00:54', N'', N'Standard', 20000, N'', N'waiting', 310000)
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
go
INSERT INTO [dbo].[Rating] ([ratingId], [senderUserId], [receiverUserId], [orderId], [productId], [marks], [detail]) VALUES (1, 2, 1, 1, 1, 2, N'Very good')
INSERT INTO [dbo].[Rating] ([ratingId], [senderUserId], [receiverUserId], [orderId], [productId], [marks], [detail]) VALUES (2, 1, 2, 2, 20, 5, N'Ok ch?t lu?ng, dáp ?ng nhu c?u, dúng là d?i m?i nh?t có khác.')
INSERT INTO [dbo].[Rating] ([ratingId], [senderUserId], [receiverUserId], [orderId], [productId], [marks], [detail]) VALUES (3, 1, 2, 4, 31, 4, N'ok cute')
go
--drop table OrderItem;
--go
create table OrderItem (
	orderId int references OrderTable(orderId),
	productId int references Product(productId),
);
go
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (1, 1)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (1, 2)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (1, 11)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (2, 20)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (3, 4)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (3, 5)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (4, 31)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (5, 33)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (5, 34)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (6, 34)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (7, 23)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (7, 24)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (8, 23)
INSERT INTO [dbo].[OrderItem] ([orderId], [productId]) VALUES (8, 24)
go

create table CancelProduct
(
	orderId int references OrderTable(orderId),
	productId int references Product(productId),
	reasonCancel nvarchar(1000)
);
go
INSERT INTO [dbo].[CancelProduct] ([orderId], [productId], [reasonCancel]) VALUES (5, 33, N'I have another choice')
INSERT INTO [dbo].[CancelProduct] ([orderId], [productId], [reasonCancel]) VALUES (6, 34, N'I have another choice')
INSERT INTO [dbo].[CancelProduct] ([orderId], [productId], [reasonCancel]) VALUES (7, 23, N'')
go
--drop table detailImage
create table DetailImage (
	productId int references Product(productId),
	image varbinary(max),
);
go
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (1, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (1, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (1, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (2, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (2, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (2, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (3, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (3, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (3, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (4, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (4, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (4, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (5, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (5, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (5, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (6, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (6, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (6, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (7, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (7, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (7, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (8, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (8, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (8, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (9, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (9, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (9, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (10, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (10, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (10, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (11, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (11, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (11, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (23, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (23, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (20, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (20, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (20, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (21, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (21, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (21, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (22, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (22, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (22, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (23, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (24, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (24, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (24, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (25, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (25, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (25, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (26, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (26, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (26, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (27, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (27, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (27, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (28, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (28, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (28, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (29, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (29, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (29, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (30, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (30, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (30, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (31, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (31, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (32, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (32, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (32, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (33, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (33, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (34, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (34, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (34, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (1, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (31, null)
INSERT INTO [dbo].[DetailImage] ([productId], [image]) VALUES (33, null)
go


--drop table LikedItem;
--go

create table LikedItem (
	userId int references UserTable(userId),
	productId int references Product(productId),
	primary key(userId, productId),
);
go
INSERT INTO [dbo].[LikedItem] ([userId], [productId]) VALUES (1, 24)
INSERT INTO [dbo].[LikedItem] ([userId], [productId]) VALUES (1, 29)
INSERT INTO [dbo].[LikedItem] ([userId], [productId]) VALUES (1, 30)
INSERT INTO [dbo].[LikedItem] ([userId], [productId]) VALUES (1, 33)
INSERT INTO [dbo].[LikedItem] ([userId], [productId]) VALUES (2, 3)
go


