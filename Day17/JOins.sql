select Products.CategoryID,ProductName,CategoryName 
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
--Print the orderId, order date and the customer name
select OrderId,OrderDate,ContactName from
Customers join Orders
on Customers.CustomerID = Orders.CustomerID
--or
select OrderId,OrderDate,ContactName from
Customers c join Orders o
on c.CustomerID = o.CustomerID
--or
select OrderId,OrderDate,ContactName from
Customers c,Orders o
where c.CustomerID = o.CustomerID

select CompanyName,ProductName,CategoryName
from Suppliers s join Products p
on s.SupplierID=p.SupplierID
join Categories c 
on c.CategoryID= p.CategoryID

select CompanyName,ProductName,CategoryName
from Suppliers s join Products p
on s.SupplierID=p.SupplierID
join Categories c 
on c.CategoryID= p.CategoryID
where CategoryName like '%e%'


select CompanyName,ProductName,CategoryName
from Suppliers s join Products p
on s.SupplierID=p.SupplierID
join Categories c 
on c.CategoryID= p.CategoryID
where ProductId in (select distinct productID from [Order Details])

--printt category name and number of products
select CategoryName,count(productid) 'Number of products'
from
Products p join Categories c on 
p.CategoryID = c.CategoryID
group by CategoryName
--print the customer name and the number of orders placed by him
select ContactName,count(OrderId) 'number of orders placed'
from Orders o join Customers c
on o.CustomerID = c.CustomerID
group by ContactName

--managername and employee name reporting to him/her
select EmployeeID, 
concat(firstname,' ',LASTname) Employee_Name,
ReportsTo
from Employees

---employee firstname and managers firstname
select emp.firstname 'Employee Name',
mgr.FirstName 'Manager Name'
from Employees emp join Employees mgr
on emp.reportsTO = mgr.EmployeeID



select concat(emp.firstname,' ',emp.lastname) 'Employee Name',
concat(mgr.FirstName,' ',mgr.LastName) 'Manager Name'
from Employees emp join Employees mgr
on emp.reportsTO = mgr.EmployeeID
---Manager Name and the numebr of employees reporting to him
select 
concat(mgr.FirstName,' ',mgr.LastName) 'Manager Name',
count(emp.EmployeeId) 'number of employees reporting'
from Employees emp join Employees mgr
on emp.reportsTO = mgr.EmployeeID
 group by concat(mgr.FirstName,' ',mgr.LastName)




