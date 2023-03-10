use Northwind

Create procedure proc_FirstSample
as
begin
  print 'Hello World'
end

execute proc_FirstSample

drop procedure proc_FirstSample

create proc proc_Second(@uname varchar(20))
as
  print 'Hello' + @uname

exec proc_Second 'Ramu'

create proc proc_Third(@uname varchar(20))
as
begin
  if(@uname is null)
     print 'Can''t even enter a name????'
  else
    print 'Hello' + @uname
end
exec proc_ThIRD null

create proc proc_Add(@num1 int,@num2 int)
as
begin
   if(@num1 is null or @num2 is null)
       print 'Name dha thariyala nu patha number um a???? Worshtu'
	else
	   print (@num1+@num2)
end

proc_Add null,13

sp_help Products

create proc proc_ProductsFilterByPrice(@price money)
as
begin
 select * from Products where UnitPrice < @price
end
proc_ProductsFilterByPrice 20

--create a proc that takes the product name and quantity as parameter
--prints the total amount
create proc proc_CalculatePrice(@pname varchar(20), @qty int)
as
begin
   declare
     @productPrice money,
	 @totalPrice money
	 set @productPrice 
	 = (select unitprice from Products where ProductName= @pname)
	 set @totalPrice = @productPrice * @qty
	 print 'Total price is '+ convert(varchar(20),@totalPrice)
end
--Chang
proc_CalculatePrice 'Chang',3
---Create a procedure that will take a product name and customer name
--Prints the total number orders that he/she has placed for the product
--Total amount he/she has spent on the product

create proc porc_TotalAmount(@pname varchar(50),@cname varchar(50))
as
begin
  declare
   @pid int,
   @pprice money,
   @qty int,
   @count int
   set @pid = (select productID from Products where ProductName = @pname)
   print @pid
   set @pprice = (select unitprice from products where ProductID = @pid)
   print @pprice
   set @qty = (select sum(quantity) from 
		[Order Details] od join orders o 
		on od.OrderID=o.OrderID
		join Customers c on
		c.CustomerID = o.CustomerID
		where CompanyName = @cname and productid = @pid)
    print @qty
	set @count = (select count(od.OrderID) from 
		[Order Details] od join orders o 
		on od.OrderID=o.OrderID
		join Customers c on
		c.CustomerID = o.CustomerID
		where c.COmpanyName = @cname and productid = @pid)
	print @count
	print 'Total price' +convert(varchar(20),(@qty*@pprice))
	print 'Number of times ordered'+convert(varchar(20),@count)
end
--'Chang','Around the Horn'
select * from Orders where CustomerID= 'VINET'
select * from Products
select * from [Order Details] where OrderID = 10248

select * from customers where CustomerID = 'VINET'
select count(orderid),ProductID from [Order Details] 
where orderid=10248
group by ProductID

porc_TotalAmount 'Queso Cabrales','Vins et alcools Chevalier'

select count(od.OrderID) from 
		[Order Details] od join orders o 
		on od.OrderID=o.OrderID
		join Customers c on
		c.CustomerID = o.CustomerID
		where c.CompanyName = 'Vins et alcools Chevalier' 
		and productid = 11

		select sum(quantity) from 
		[Order Details] od join orders o 
		on od.OrderID=o.OrderID
		join Customers c on
		c.CustomerID = o.CustomerID
		where CompanyName = 'Vins et alcools Chevalier' 
		and productid = 11



create proc calcamount(@pname varchar(20), @cname varchar(20))
as
begin
	declare 
	@cost int,
	@qty int

	set @qty=
		(select count(od.quantity) 'no of orders' from [Order Details] od join products p
		on p.productid=od.productid
		join orders o on od.orderid=o.orderid
		join customers c on c.customerid=o.customerid
		where p.productName=@pname and c.ContactName=@cname)

	set @cost=
		(select unitprice from products where productname= @pname) * @qty
	
	print @cost
end


select sum(od.quantity) 'no of orders' from [Order Details] od join products p
		on p.productid=od.productid
		join orders o on od.orderid=o.orderid
		join customers c on c.customerid=o.customerid
		where p.productName='Queso Cabrales' 
		and c.CompanyName='Vins et alcools Chevalier'
---Create a procedure that will take Employee first name and last name
--Print the total amount orders made by the employee
--With tax @12.36%

select * from Employees
select * from Orders
proc_calTal 'Janet','Leverling'
alter proc proc_calTal(@fname varchar(20),@lname varchar(20))
as
begin
   declare
   @gross money,
   @net money
   set @gross = (select sum(quantity*unitprice) from [Order Details] od
					join orders o on o.OrderID = od.OrderID
					join Employees e on e.EmployeeID = o.EmployeeID
					where FirstName= @fname and LastName = @lname)
   set @net = @gross*12.36/100
   print 'TOtal price is '+COnvert(varchar(20),@net)
end