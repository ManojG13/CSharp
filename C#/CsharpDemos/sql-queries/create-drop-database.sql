
create database SchoolDB
go

use SchoolDB
go

create table Students
(
   Id int,
   FirstName varchar(20),
   LastName  varchar(20)
)

go

Alter table Students
Add Email varchar(20)

go

Alter table Students
Add Age int

go

Alter table Students
Drop column Age


--drop table Students

Alter table Students 
Alter column Email varchar(25)

