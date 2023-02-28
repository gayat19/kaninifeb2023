use master


create database dbEmployeeDetails

use dbEmployeeDetails

create table tblArea
(area varchar(50),zipCode char(6))

select * from tblArea

sp_help tblArea

drop table tblArea

create table tblArea
(area varchar(50) primary key,
zipCode char(6))

create table tblArea
(area varchar(50) constraint pk_area primary key,
zipCode char(6))
--This is a comment

--alter table to add primary key
create table tblArea
(area varchar(50),zipCode char(6))

--alter the column to make not null
alter table tblArea
alter column area varchar(50) not null 

alter table tblArea
add constraint pk_area primary key(area)

--alter table to add a column
alter table tblArea
add remarks text

--delete a column
alter table tblArea
drop column remarks

create table tblSkills
(skill varchar(30) constraint pk_skill primary key,
skill_description varchar(50))

sp_help tblSkills


create table tblEmployees
(id int identity(101,1) constraint pk_eid primary key,
name varchar(50) not null,
phone varchar(15) unique,
emp_area varchar(50) constraint fk_area foreign key 
references tblArea(area))

create table tblEmployeeSkill
(emp_id int constraint fk_eid foreign key references tblEmployees(id),
skill_name varchar(30) constraint fk_skill foreign key 
references tblSkills(skill),
skill_level float check(skill_level>=1 and skill_level<=10),
constraint pk_empSkill primary key(emp_id,skill_name))

sp_help tblEmployeeSkill



sp_help tblEmployees