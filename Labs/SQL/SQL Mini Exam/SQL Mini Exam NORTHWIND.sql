--1.1
select CustomerId, CompanyName, 
Address, City, Region, PostalCode 
from Customers
where City='Paris' OR City='London';

--1.2
select * from Products
where CategoryID=1 or CategoryID=2
--or also WHERE  QuantityPerUnit Like '%bottle%'

--1.3
select Suppliers.CompanyName,Suppliers.Country, * from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
where QuantityPerUnit Like '%bottle%'

--1.4 Write an SQL Statement 
--that shows how many products there are 
--in each category. Include Category Name in result 
--set and list the highest number first.
select CategoryName, count(distinct()) from Products


--1.5 List all UK employees using concatenation 
--to join their title of courtesy, first name and last
--name together. Also include their city of residence.

select CONCAT(TitleOfCourtesy, FirstName, ' ', LastName),
City 
from Employees where Country='UK'


--1.6

--1.7
--Count how many Orders have a Freight amount greater
--than 100.00 and either USA or UK as Ship Country.
select * from Orders
where ShipCountry IN ('USA', 'UK') and Freight > 100 
order by Freight asc

--1.8 Write an SQL Statement to identify the 
--Order Number of the Order
--with the highest amount 
--of discount applied to that order.
select top 1 OrderID, 
sum(UnitPrice * Quantity * Discount) as 'Discount Given'
from [Order Details]
Group by OrderID
order by sum(UnitPrice * Quantity * Discount) desc

--2.0
drop table if exists SpartansTable
go
create table SpartansTable(
	SpartanID INT not null IDENTITY PRIMARY KEY,
	Title NVARCHAR(50) null,
	FirstName NVARCHAR(50) null,
	LastName NVARCHAR(50) null,
	University NVARCHAR(50) null,
	Course NVARCHAR(50) null,
	MarkAchieved NVARCHAR(50) null
)

insert into SpartansTable values('Mr','Miguel', 'Vieira', 'Bedfordshire', 'Games Course', 'First')
insert into SpartansTable values('Ms','Ruoyi', 'Jiang', 'No clue', 'Games Course', 'First')
insert into SpartansTable values('Mr','Myles', 'Muda', 'London something', 'Computer Sc Course', 'Second')
insert into SpartansTable values('Mr','Alykhan', 'Esmail', 'No clue', 'Games Course', 'First')

select * from SpartansTable
--end 2.0