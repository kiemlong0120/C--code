create database CoffeShop
Go

use CoffeShop
go

-- food
-- table
-- foodCategory
-- Account
-- Bill
 
create Table tableFood
(
	id int identity primary key,
	Name nvarchar(100)  not null default N'Ban chua co ten',
	Status nvarchar(100) not null	default N'trong' --trong || co nguoi
)
go


create Table Account
(
	UserName nvarchar(100) primary key,
	DisplayName nvarchar(100) not null default N'quang',
	Password nvarchar(1000) not null default 0,
	Type int not null  default 0 --1:admin && 0:staff
)
go

create table FoodCategory
(
	id int identity primary key,
	Name nvarchar(100) not null default N'Chua dat ten'
)
go

create table Food
(
	id int identity primary key,
	Name nvarchar(100)  not null default N'Chua dat ten',
	idCategory int  not null,
	price float  not null default 0
	foreign key (idCategory) references dbo.FoodCategory(id)
)
go

create table Bill
(
	id int identity primary key,
	DateCheckIn date  not null default getdate(),
	DateCheckOut date ,
	idTable int  not null,
	status int not null default 0 --1: da thanh toan && 0: chua thanh toan

		foreign key (idTable) references dbo.tableFood(id)

)
go


create table billInfor
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
go