--orders sorted by Ship Region
use Northwind
select * from orders order by ShipRegion,ShipCity

select * from orders order by (case 
	when ShipRegion IS NULL then ShipCity
	else ShipRegion
    end)
select (RequiredDate - IsNull(shippedDate,SYSDATETIME()))  
from Orders

select (RequiredDate - isnull(shippedDate,SYSDATETIME()))  
from Orders
select format((RequiredDate - isnull(shippedDate,SYSDATETIME())) , N'dd') 
'Expected vs. Actual'
from Orders

select DATEADD(day,3,SYSDATETIME())

create function udf_sample()
returns varchar(20)
as
begin
  return 'Hello World'
end

select dbo.udf_sample()

create function udf_sum(@num1 int,@num2 int)
returns int
as
begin
  return (@num1+@num2)
end

select dbo.udf_sum(10,20)

--create a function that will take componenets of salary
--basic,HRA,DA and deductions
--return back the net salary(basic+HRA+DA-deductions)-10%
Create Function udf_CalSal(@basic int ,@HRA int,@DA int,@deductions int)
returns int
as
begin
	return ((@basic+@HRA+@DA-@deductions)*90/100)
end

select dbo.udf_CalSal(20000,2000,1000,20)

create function udf_SampelTable(@cid int)
returns table
as

	return (select ProductId,ProductName from Products where CategoryID=@cid)

select * from dbo.udf_SampelTable(2)

drop function dbo.udf_MyProduct
create function udf_MyProduct(@cid varchar(10),@eid int)
returns @MyProduts table(pid int,pname varchar(50),pprice money)
as
begin
insert into @MyProduts 
	select productid,productname,unitPrice from products
	where productid in(select productid from [order details]
	where orderid in(select orderid from orders where customerid=@cid))

	insert into @MyProduts 
	select p.productid,productname,p.unitPrice from products p
	join [Order Details] od on od.ProductID=p.ProductID
	join orders o on o.OrderId = od.OrderID
	where EmployeeID = @eid
   return
end

select * from Customers

select * from dbo.udf_MyProduct('ALFKI',2) order by pid

sp_helptext sp_helptext

--Create a function that will take the supplier name as parameter and return back the
--category name number of products as return.
--sort the result with the category name



