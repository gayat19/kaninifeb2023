use dbEmployeeDetails

sp_help tblarea

insert into tblArea(area,zipCode) values('ABC','123456')
insert into tblArea(area,zipCode) values('XYZ','112233'),('EFG','654321')
insert into tblArea(zipCode,area) values('121212','TKB')
insert into tblArea values('EEE','989898')

select * from tblArea

select * from tblEmployees

sp_help tblEmployees

insert into tblEmployees(name,phone,emp_area)
values('Ramu','9876543210','ABC')
insert into tblEmployees(name,phone,emp_area)
values('Somu','8877665544','XYZ')
insert into tblEmployees
values('Bimu','5544332211','XYZ')
insert into tblEmployees
values('Jimu','5566774433',null)
insert into tblEmployees(name,phone)
values('Fomu','9876123459')


--Failure cases
insert into tblEmployees
values(104,'Bimu','5544332211','XYZ')
insert into tblEmployees
values('Lomu','66877899','UUU')

--
insert into tblSkills values('C','PLT'),('C#','WEB'),('SQL','RDBMS')

select * from tblSkills

insert into tblSkills values('Cgfashdahsvddjdjfjdfbdsjbfjkasj.vc.namsvc.javcasjkcajskjksab','PLT')

sp_help tblskills

select * from tblEmployeeSkill

insert into tblEmployeeSkill values(101,'C',7)
insert into tblEmployeeSkill values(101,'C#',8)
insert into tblEmployeeSkill values(102,'C#',8)


insert into tblEmployeeSkill values(null,'C#',8)
insert into tblEmployeeSkill values(102,null,8)
insert into tblEmployeeSkill values(102,'SQL',11)

select * from tblEmployees

--delete statements
delete from tblEmployees where id=106
delete from tblEmployees where emp_area is null
delete from tblEmployees


delete from tblEmployeeSkill
truncate table tblEmployeeSkill





delete from tblEmployees where id=101



create table tbl1
(f1 int unique not null,f2 varchar(20))

create table tbl2
(f11 int primary key,
f21 int references tbl1(f1))


insert into tbl1 values(1,'abc'),(2,'eee'),(3,'ttt')

sp_help tbl2

select * from tbl1
delete from tbl1 where f1=2
truncate table tbl1 

drop table tbl2
go
drop table tbl1



create table tbl1
(f1 int unique not null,f2 varchar(20))

create table tbl2
(f11 int primary key,
f21 int references tbl1(f1) on delete cascade)



insert into tbl1 values(4,'abc'),(5,'eee'),(6,'ttt')
insert into tbl2 values(101,4),(102,5),(103,6)

select * from tbl1
select * from tbl2

delete from tbl1 
truncate table tbl1

select * from tbl2
begin tran
delete from tbl2
rollback

begin tran
truncate table tbl2
rollback

--

select * from tblArea
select * from tblEmployees
select * from tblSkills
select * from tblEmployeeSkill

update tblArea set zipCode='111222' where area='XYZ'
update tblEmployeeSkill set skill_level=6 where skill_name='C#'
update tblEmployeeSkill set skill_level=8 where skill_name='C#' and
emp_id=101

update tbl2 set f21 = case f21
when 1 then 3
when 2 then 5
end

create table tbl1
(f1 int unique not null,f2 varchar(20))

create table tbl2
(f11 int primary key,
f21 int references tbl1(f1) on update cascade)

insert into tbl1 values(4,'abc'),(5,'eee'),(6,'ttt')
insert into tbl2 values(101,4),(102,5),(103,6)

select * from tbl1
select * from tbl2

update tbl1 set f1=7 where f1=6 
