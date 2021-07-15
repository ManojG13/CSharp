
use SchoolDB;
go

Create table Persons
(
   Id int primary key,
   FirstName varchar(20),
   LastName varchar(20),
   Age int
)

go

Create table Orders
(
   OrderId int primary key,
   OrderNumber int not null,
   PersonID int FOREIGN KEY REFERENCES Persons(Id)

)


insert into Persons values(1,'Hansen','Ola',30)
insert into Persons values(2,'Svendson','Tove',23)
insert into Persons values(3,'Harry','Dorothy',26)
insert into Persons values(4,'Hansen','Ola',30)


insert into Orders values(1,77895,1);
insert into Orders values(2,4455,null);

select distinct FirstName from Persons


select * from Orders

select * from Persons
select * from Persons where FirstName like 'H%'

select * from Persons where (Age > 25 or FirstName like 's%')


select * from Persons where Age not in (23,30)