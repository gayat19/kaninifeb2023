use Northwind

select * from Products
select * from Products where UnitPrice>=15
--display products which have reorderlevel>0
select * from Products where reorderlevel>0

select * from Products where reorderlevel>0 and reorderlevel<=20
select * from Products where reorderlevel between 1 and 20

--products that are supplied by supplier with id 8
select * from Products where SupplierID=8

--products supplied by supplier 8 and 13
select * from Products where SupplierID=8 or SupplierID=13


--products supplied by supplier 8,13,21 and 24
select * from Products where SupplierID in(8,13,21,24)

--products that are priced greater than 12, 19 and 15
select * from Products where UnitPrice > 12

--products that are priced greater than teh greatest of  12, 19 and 15
select * from Products where UnitPrice > 19

--print products that are in stock
select * from Products where UnitsInStock>0

--select the products that are not priced above 25
select * from Products where UnitPrice<=25

-- select the products that have been discontinued
select * from Products where Discontinued = 1

-- select the products that are not discontinued
select * from Products where Discontinued != 1
select * from Products where Discontinued = 0


select ProductName,UnitPrice from products

select ProductName,UnitPrice from products where UnitPrice>=25
select ProductName,UnitPrice as Price_Per_Unit from products
where UnitPrice>=25
--or
select ProductName,UnitPrice  Price_Per_Unit from products
where UnitPrice>=25
--or
select ProductName,UnitPrice  'Price Per Unit' from products
where UnitPrice>=25

select productname 'Product Name' from Products
print 'Hello'

--print the product name and its discontinued status for those products 
--that are in stock and have price rage of 10 to 20
select productname 'Product Name', Discontinued 'Discontinues status'
from Products where UnitsInStock > 0 and UnitPrice between 10 and 20

--print product name and price of those products that are not 
--discontiued and are not supplied by the supplier with id 8 and 13
select productname 'Product Name', UnitPrice 'Price per Unit'
from Products where Discontinued = 0 and SupplierID  not in (8,13)
--or
select productname 'Product Name', UnitPrice 'Price per Unit'
from Products where Discontinued = 0 
and SupplierID != 8 and SupplierID != 13
--print product name and quantityper unit of those products that been
--re ordered and are from category 2,7 and 3
select productname 'Product Name', QuantityPerUnit 'quantity per unit'
from Products where ReorderLevel > 0 
and CategoryID in (2,3,7)
--or
select productname 'Product Name', QuantityPerUnit 'quantity per unit'
from Products where ReorderLevel > 0 
and (CategoryID = 2 or CategoryID = 3 or CategoryID = 7)

select * from products where QuantityPerUnit like '%jars%'
select * from products where ProductName like '_o%'
select * from products where ProductName like '_o%' and 
ProductName not like '% %'
--select the products with last letter as e
select * from products where ProductName like '%e'
--select product name taht have last but one char as b
select * from products where ProductName like '%b_'
--select products that are measured in kg
select * from products where QuantityPerUnit like '%kg%'
and QuantityPerUnit not like '%pkg%'

select top 2* from products
select top 2 productname,UnitPrice from products

select categoryid from products
select  distinct categoryid from products
select  distinct categoryid, SupplierID from products

select * from Products
select * from Products order by CategoryID
select * from Products order by CategoryID desc

select * from Products order by CategoryID,UnitsInStock
select * from Products order by CategoryID desc,UnitsInStock

--print the product details sorted by price in descending order
--list only those products which have names that contain o and e
-- also the products should be in stock and not discontinued
select * from Products where ProductName like '%o%' 
and ProductName like '%e%'
and UnitsInStock >0 and Discontinued =0
order by unitprice desc
--print product name and quantity per unit for those products
-- thathave been reordered and have price in the range of 20 to 25
--also ensure the products are sorted by category id then by supplier id
-- and are not supplied by suuplied 7,11 and 14

select ProductName,QuantityPerUnit from products 
where  ReorderLevel>0 and (UnitPrice between 20 and 25) 
and SupplierID not in (7,11,14) order by CategoryID,SupplierID


select sum(unitprice),productname from products

select sum(unitprice) 'sum of price',avg(unitprice) 'average of price'
from products


select avg(unitprice) 'average of price'
from products
where categoryid=1

--print the average price of products in every category
select categoryid,avg(unitprice) 'average of price'
from products
group by categoryid 
select categoryid,avg(unitprice) 'average of price'
from products
group by categoryid 
order by avg(unitprice)
--or
select categoryid,avg(unitprice) 'average of price'
from products
group by categoryid 
order by 2
--or
select categoryid,avg(unitprice) 'average of price'
from products
group by categoryid 
order by 'average of price'

select categoryid,avg(unitprice) 'average of price'
from products
where Discontinued=0
group by categoryid 
order by 'average of price'

select categoryid,avg(unitprice) 'average of price'
from products
where Discontinued=0
group by categoryid 
having avg(unitprice)>25
order by 'average of price'
--print the supplier wise total products in stock for those products
--that are not from category 3 and 4 also have been reorderd 
--and not discontinued, have the total greater than 30
--sorted in descending order of supplier id
select SupplierId,sum(unitsinstock) 'Total in Stock' from products
where CategoryID not in (3,4) and ReorderLevel>0 and Discontinued =0
group by SupplierID
having sum(unitsinstock)>30
order by 1 desc




select * from products where
soundex(productName) =soundex('chaii')

select round(123.45,0)
select round(123.45,1)
select round(123.45,-1)
select round(127.45,-1)
