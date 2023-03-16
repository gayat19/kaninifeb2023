select * from tbl1

create trigger trg_InsertTbl1
on tbl1
for insert
as
begin
   print 'Hello'
end

insert into tbl1 values(106,'JJJ')


select * from tbl1

create trigger trg_InsertTbl1
on tbl1
for insert
as
begin
  declare 
   @myF2 varchar(10)
   set @myF2 = (select f2 from inserted)
   print @myF2
end

drop trigger trg_InsertTbl1

insert into tbl1 values(107,'JJJ')

select * from tbl1
select * from tbl2


alter trigger trg_InsertTbl1
on tbl1
for insert
as
begin
  declare 
   @myF1 varchar(10)
   set @myF1 = (select f1 from inserted)
   insert into tbl2 values(@myF1,SYSDATETIME())
end

insert into tbl1 values(108,'LKG')

drop trigger trg_InsertTbl1

create trigger trg_InsertTbl1
on tbl1
instead of insert
as
begin
  print 'hello'
end

insert into tbl1 values(109,'POI')

select * from tbl1

create view v1
as
select * from Categories

select * from v1

create view vwTables
as
select f1,f2,c2 from tbl1 join tbl2
on tbl1.f1 = tbl2.c1

insert into vwTables values(110,'GTY',SYSDATETIME())

create trigger trgInsertAll
on vwTables
instead of Insert
as
begin
  insert into tbl1 select f1,f2 from inserted
  insert into tbl2 select f1,c2 from inserted
end

insert into vwTables values(110,'GTY',SYSDATETIME())

select * from vwTables

---create a trigger for update on the table order details
--if the price of the product is changed and is more than 50 
-- the discount shoul be changed to 2
select * from [Order Details]
alter trigger trg_UpdateDiscountOnCOndition
on [Order Details]
for Update
as 
begin
   declare 
   @uprice money
   set @uprice = (select unitprice from inserted)
   if(@uprice>50)
     update [Order Details] set Discount=.9 
	 where ProductID = (select ProductID from inserted)
	 and OrderID = (select OrderID from inserted)
end



select * from [Order Details]

sp_help [Order Details]

update [Order Details] set UnitPrice = 20 where OrderID=10248 and ProductID=11
update [Order Details] set UnitPrice = 52 where OrderID=10248 and ProductID=11

select * from tbl1


declare cur_First cursor 
for
select * from tbl1
declare
@myF1 int,@myF2 varchar(10)
open cur_First
fetch cur_First into @myF1,@myF2
while(@@FETCH_STATUS =0)
begin
     print ' The value of f1 is '+convert(varchar(5),@myF1)
	 print ' The value of f2 is '+@myF2
	 print '-----------------------'
	 fetch cur_First into @myF1,@myF2
end
close Cur_First
deallocate Cur_First

declare cur_OrderData cursor
for
select orderId , ContactName from Orders o join CUstomers c
on o.CustomerID = c.CustomerID
declare 
@oid int,@cname varchar(100)
open cur_OrderData
Fetch cur_OrderData into @oid,@cname
while(@@FETCH_STATUS =0)
begin
    print 'Customer Name : '+@cname
	print 'Order ID : '+convert(varchar(5),@oid)
	select * from [Order Details] where OrderID = @oid
	print '------------------'
	Fetch cur_OrderData into @oid,@cname
end
close cur_OrderData
deallocate cur_OrderData


declare cur_OrderData cursor
for
select orderId , ContactName from Orders o join CUstomers c
on o.CustomerID = c.CustomerID
declare 
@oid int,@cname varchar(100)
open cur_OrderData
Fetch cur_OrderData into @oid,@cname
while(@@FETCH_STATUS =0)
begin
    print 'Customer Name : '+@cname
	print 'Order ID : '+convert(varchar(5),@oid)
	declare cur_InnerOrder cursor
	for
	select ProductID,UnitPrice,Quantity,Discount from [Order Details] where OrderID=@oid
	declare
	@pid int,@uprice money,@qty int,@dis float
	open cur_InnerOrder
	fetch cur_InnerOrder into @pid,@uprice,@qty,@dis
	while(@@FETCH_STATUS =0)
	begin
		print 'Product ID : '+convert(varchar(5),@pid)
		print 'Product Price : '+convert(varchar(5),@uprice)
		print 'Product Quantity : '+convert(varchar(5),@qty)
		print 'Discount : '+convert(varchar(5),@dis)
		fetch cur_InnerOrder into @pid,@uprice,@qty,@dis
		print '************'
	end
	close cur_InnerOrder
	deallocate cur_InnerOrder
	print '------------------'
	Fetch cur_OrderData into @oid,@cname
end
close cur_OrderData
deallocate cur_OrderData



