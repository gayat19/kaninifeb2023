use Northwind

select * from Categories

select CategoryId from Categories where CategoryName = 'Dairy Products'
select * from Products where CategoryID = 4

select * from Products where CategoryID = 
(select CategoryId from Categories where CategoryName = 'Confections')

select * from Products where CategoryID in
(select CategoryId from Categories where CategoryName like 'C%')

--get all the order details for the product 'Valkoinen suklaa'
select * from [Order Details] where ProductID =(
select productId from Products where ProductName = 'Valkoinen suklaa')

select * from Orders where OrderID in(
select distinct OrderID from [Order Details] where ProductID =(
select productId from Products where ProductName = 'Valkoinen suklaa'))

---Print the details of the customers who have ordered 
--the product 'Valkoinen suklaa'
select * from Customers where CustomerID in
(select  distinct CustomerId from Orders where OrderId in
(select distinct OrderId from [Order Details] where ProductId = 
(select productId from Products where ProductName = 'Valkoinen suklaa')))
select * from Region
--Print all the employees from the 'Northern' region
select * from employees where EmployeeID in
(select distinct employeeId from EmployeeTerritories where TerritoryID in 
(select TerritoryID from Territories where RegionID = 
(select RegionId from Region where RegionDescription = 'Northern')))

--Print the number of employees in each terrirory from the region 'Northern'
select TerritoryId, count(employeeId) No_Of_employees from EmployeeTerritories where TerritoryID in 
(select TerritoryID from Territories where RegionID = 
(select RegionId from Region where RegionDescription = 'Western'))
group by TerritoryID

---Print the number of orders by every customer for the 
--product of category 'Beverages'
select customerId,count(OrderId) Number_Of_Orders
from Orders where OrderId in
(select OrderID from [Order Details] where ProductID in 
(select ProductId from Products where CategoryID = 
(select CategoryId from Categories where CategoryName = 'Beverages')))
group by CustomerId
having count(OrderId)>2
order by 2

select * from Shippers
--Print the number of orders for the shipper 'Speedy Express'
select count(orderId) from Orders where ShipVia
=(select shipperId from Shippers where CompanyName=  'Speedy Express')

-- print the number of order executed by every employee 
--from the region 'Northern'

select employeeId,count(orderId) 'Number of employees'
from orders  where employeeid in
(select distinct employeeId from EmployeeTerritories where TerritoryID in 
(select TerritoryID from Territories where RegionID = 
(select RegionId from Region where RegionDescription = 'Northern')))
group by employeeId