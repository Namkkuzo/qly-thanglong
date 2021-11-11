create database QlNhaHang
use QlNhaHang

create table tblFoods (
	Id int IDENTITY(1,1) primary key,
	sName nvarchar (255),
	fPrice float,
	sDecription nvarchar(255)
);

create table tblUsers (
	Id int IDENTITY(1,1) primary key,
	sName nvarchar (255),
	sPassword nvarchar (255),
	sFullName nvarchar (255),
	bAdmin bit,
	dDateOfBirth date,
	bGender bit,
	sPhone nvarchar(255)
);

create table tblOrders (
	Id int IDENTITY(1,1) primary key,
	sCode nvarchar (255),
	dCretedDate date,
	fValue float,
	iUserId int
)

create table tblOrderDetails (
	Id int IDENTITY(1,1) primary key,
	iOrderId int,
	iFoodId int,
	iNumber int
);
select * from tblUsers
insert into tblUsers values (N'Phượng', '1234565789', N'Nguyễn Công Phượng', 0, '1995/01/21', 1, '0275941253');
insert into tblUsers values (N'Hải', '1234565789', N'Nguyễn Quang Hải', 0, '1996/12/12', 1, '5345251253');
insert into tblUsers values (N'Lâm', '1234565789', N'Đặng Văn Lâm', 0, '1992/04/14', 1, '0221923553');
insert into tblUsers values (N'Hải', '1234565789', N'Quế Ngọc Hải', 1, '1980/01/21', 1, '0276341628');
insert into tblUsers values (N'Hậu', '1234565789', N'Đoàn Văn Hậu', 0, '2000/08/21', 0, '0295841913');
insert into tblUsers values (N'Toàn', '1234565789', N'Nguyễn Văn Toàn', 0, '1998/05/12', 0, '0209470956');

insert into tblFoods values (N'Pizza Pizziamocci', 5000, N'Pizza Pizziamocci');
insert into tblFoods values (N'Súp ngô non', 5000, N'Súp ngô non là món khai vị');
insert into tblFoods values (N'Súp gà nấm hương', 5000, N'Súp gà nấm hương là món khai vị');
insert into tblFoods values (N'Cơm rang Phương Đông', 65000, N'Cơm rang Phương Đông');
insert into tblFoods values (N'Cơm rang Hoàng Gia', 70000, N'Cơm rang Hoàng Gia');
insert into tblFoods values (N'Rau bò  khoai xào', 50000, N'Rau bò  khoai xào');
insert into tblFoods values (N'Rau bí xào', 40000, N'Rau bí xào');
insert into tblFoods values (N'Rau muống xào', 30000, N'Rau muống xào');
insert into tblFoods values (N'Nộm hoa chuối', 40000, N'Nộm hoa chuối');
insert into tblFoods values (N'Salat rau củ', 100000, N'Salat rau củ');
insert into tblFoods values (N'Gà nướng ngũ vị', 350000, N'Gà nướng ngũ vị');
insert into tblFoods values (N'Gà hầm thuốc bắc', 270000, N'Gà hầm thuốc bắc');
insert into tblFoods values (N'Gà rang muối', 200000, N'Gà rang muối');
insert into tblFoods values (N'Gỏi cá hồi', 250000, N'Gỏi cá hồi');
insert into tblFoods values (N'Trâu xào cần', 120000, N'Trâu xào cần');
insert into tblFoods values (N'Bò xào lúc lắc', 150000, N'Bò xào lúc lắc');
insert into tblFoods values (N'Bò xốt tiêu đen', 180000, N'Bò xốt tiêu đen');


insert into tblOrders values ('100000', '2021/01/21', 5000, 1);
insert into tblOrders values ('100001', '2021/03/21', 13000, 1);
insert into tblOrders values ('100002', '2021/04/21', 47000, 1);
insert into tblOrders values ('100002', '2021/03/01', 400000, 1);


insert into tblOrderDetails values (1, 1, 1);

insert into tblOrderDetails values (2, 5, 1);
insert into tblOrderDetails values (2, 6, 1);

insert into tblOrderDetails values (3, 3, 2);
insert into tblOrderDetails values (3, 5, 1);
insert into tblOrderDetails values (3, 8, 1);

insert into tblOrderDetails values (4, 13, 2);



