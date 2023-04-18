

create database dbPizzaStore12Apr2023
Go

use dbPizzaStore12Apr2023
go

Create Table Pizzas
(id int identity(101,1) primary key,
name varchar(50),
price float)
Go

create proc proc_InsertPIzza(@pname varchar(50),
@pprice float)
as
  Insert into Pizzas(name,price) values(@pname,@pprice)

  Go

create proc proc_GetAllPizzas
as
	select * from Pizzas
Go

exec proc_InsertPIzza 'ABC',234.4
exec proc_InsertPIzza 'XYZ',200.0
exec proc_InsertPIzza 'AAA',321.7
exec proc_InsertPIzza 'KLO',123.9

exec proc_GetAllPizzas

create proc proc_GetLatestId
as
   select max(id) from Pizzas

exec proc_GetLatestId