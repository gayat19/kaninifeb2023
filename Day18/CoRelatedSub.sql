 use Northwind

 select * from Categories

select * from Products where exists
(select * from shippers where phone like '%2%')

--print the product detaisl of teh product that that have price 
--greater than the average price of all the products
select * from products where unitprice
>(select avg(unitprice) from products)


--print the products that have price greater than the price of 
-- every product that are from 'Seafood'
select * from Products where UnitPrice > all
(select UnitPrice from products where CategoryID = 
(select categoryid from Categories where CategoryName = 'Seafood'))
--or
select * from Products where UnitPrice > 
(select max(UnitPrice) from products where CategoryID = 
(select categoryid from Categories where CategoryName = 'Seafood'))

select * from Products where UnitPrice > any
(select UnitPrice from products where CategoryID = 
(select categoryid from Categories where CategoryName = 'Seafood'))
--or
select * from Products where UnitPrice > 
(select min(UnitPrice) from products where CategoryID = 
(select categoryid from Categories where CategoryName = 'Seafood'))

--print the details of products that have price taht is greater than
--the average price of the products in the same category
select * from Products p where UnitPrice >
( select avg(UnitPrice) from products p2
where p.CategoryID = p2.CategoryID
group by CategoryID)

--print the product details of products wheich have been ordered
-- if teh ordered quantity is less than the average of quantity
--of that product being ordered
select * from products where productid in
(select productid from [order details] o where quantity <
(select avg(quantity) from [Order Details] od
where o.ProductID = od.ProductID
group by ProductID))

--union and union all
select * from products where CategoryID = 
(select CategoryID from Categories where CategoryName = 'SeaFood')
union all
select * from products where productId in
(select productid from [Order Details] where Quantity > 100)


select * from products where (CategoryID,UnitPrice)=
(select CategoryID,UnitPrice from products where Productid = 2)


