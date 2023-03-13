 use northwind
 create proc proc_OutExample(@num int,@result int out)
 as
 begin
   set @result = @num * @num
 end


 declare 
 @res int
 begin
exec proc_OutExample 34,@res out
print @res
end

---change
 create proc proc_OutExample1(@num int  out)
 as
 begin
   set @num = @num * @num
 end

 declare 
 @res int 
 begin
 set @res = 10
exec proc_OutExample1 @res out
print @res
end

--Exception
--Take the category name give out the average of unit price in that category
alter proc proc_AverageOfCategory(@cname varchar(20),@avg float out)
as
begin
   declare
   @sum money,@count int,@cid int
   set @cid = (select categoryID from Categories where CategoryName=@cname)
   set @count = (select count(productID) from products where CategoryID = @cid)
   set @sum = (select sum(UnitPrice) from products where CategoryID = @cid)
   set @count = @count-5
   begin try
	set @avg = @sum/@count
	print 'The average of the products of '+@cname +' is Rs.'+convert(varchar(20),round(@avg,2))
   end try
   begin catch
     print ERROR_MESSAGE()
   end catch
end

declare 
@res int 
begin
 exec proc_AverageOfCategory 'Produce', @res out
 print @res
end


select * from Categories
select count(productid),CategoryID from products group by CategoryID

create table tbl1
(f1 int primary key,
f2 varchar(20))

create table tbl2
(c1 int primary key references tbl1(f1),
c2 date)

begin tran
  insert into tbl1 values(102,'ABC')
  insert into tbl2 values(102,'03-13-2023')
commit

begin tran
  insert into tbl1 values(102,'ABC')
  insert into tbl2 values(102,'03-13-2023')
rollback

--not to try
begin tran
  create table tbl3(cf1 int)
commit


begin tran
  insert into tbl1 values(103,'ABC')
  insert into tbl2 values(103,'03-12-2023')
  if((select c2 from tbl2 where c1=103)<SYSDATETIME())
     commit
rollback

begin tran
  insert into tbl1 values(104,'ABC')
  save tran sptbl2
  insert into tbl2 values(104,'03-14-2023')
  if((select c2 from tbl2 where c1=104)<SYSDATETIME())
     commit
  else
  begin
	rollback tran sptbl2
	commit
  end

create proc proc_Insert2Tables(@f1 int,@f2 varchar(20),@f3 date,@f4 bit out)
as
begin
  begin tran
  begin try
	insert into tbl1 values(@f1,@f2)
	save tran sptbl2
	insert into tbl2 values(@f1,@f3)
	if((select c2 from tbl2 where c1=@f1)<SYSDATETIME())
	begin
		commit
		set @f4 = 1
	end
	else
	begin
		rollback tran sptbl2
		commit
	end
  end try
  begin catch
     rollback
	 set @f4 =0
  end catch
end

declare @res bit
begin
 exec proc_Insert2Tables 105,'GJK','03-19-2023', @res out
  print @res
end



select * from tbl1
select * from tbl2

select * from tbl3

--create a stored procedure that will insert details of order
-- The procedure should take all the details to make entry in to orders, Order Details tables
--The procedure should also update teh stock in the product table
-- Let presume the order is just for 2  items as of now
--Stored procedure will give an out of message indicating Success/Failue

select * from products

select * from sales

sp_help sales