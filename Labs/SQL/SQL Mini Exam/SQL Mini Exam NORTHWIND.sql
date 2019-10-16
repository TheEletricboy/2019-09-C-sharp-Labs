select ShipRegion from Orders



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
select Categories.CategoryName as CategoryName, count(Products.CategoryID) as 'Number of products in Categories' from Products
inner join Categories on Products.CategoryID = Categories.CategoryID
GROUP by Categories.CategoryName
order by 'Number of products in Categories' desc;




--1.5 List all UK employees using concatenation 
--to join their title of courtesy, first name and last
--name together. Also include their city of residence.

select CONCAT(TitleOfCourtesy, FirstName, ' ', LastName),
City 
from Employees where Country='UK'


--1.6
SELECT RegionDescription, ROUND((SUM((Quantity*UnitPrice)*1-Discount)), 2) as 'Sales Total By Region'
FROM Region
INNER JOIN Territories on Territories.RegionID = Region.RegionID
INNER JOIN EmployeeTerritories on Territories.TerritoryID = EmployeeTerritories.TerritoryID
INNER JOIN Orders on EmployeeTerritories.EmployeeID = Orders.EmployeeID
INNER JOIN [Order Details] on [Order Details].OrderID = Orders.OrderID
GROUP BY RegionDescription
HAVING (SUM((Quantity*UnitPrice)*1-Discount) > 1000000);

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
insert into SpartansTable values('Ms','Ruoyi', 'Jiang', 'NA', 'Games Course', 'First')
insert into SpartansTable values('Mr','Myles', 'Muda', 'London something', 'Computer Sc Course', 'Second')
insert into SpartansTable values('Mr','Samuel', 'Ribeiro', 'London', 'Computer Sc Course', 'NA')
insert into SpartansTable values('Mr','Ryan', 'Burdus', 'NA', 'NA', 'First')
insert into SpartansTable values('Mr','Mohsin', 'NA', 'NA', 'NA', 'NA')


select * from SpartansTable
--end 2.0

--3.1 
select e.FirstName + '' + e.LastName AS "Employee Name", b.FirstName + '' + b.LastName AS "Reports To"
FROM Emplyees e
INNER JOIN Employees b ON e.ReportsTo=b.EmployeeID
ORDER BY "Reports To", "Employee Name";

--3.2
SELECT s.CompanyName,SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) As "Supplier Total"
      FROM [Order Details] od
      INNER JOIN Products p ON od.ProductID=p.ProductID
      INNER JOIN Suppliers s ON p.SupplierID=s.SupplierID
      GROUP BY s.CompanyName
      HAVING SUM(od.UnitPrice*od.Quantity*(1-od.Discount))>10000
      ORDER BY SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) DESC;

--3.3
SELECT TOP 10 c.CustomerID AS "Customer ID", c.CompanyName As "Company",
FORMAT(SUM(UnitPrice * Quantity * (1-Discount)),'C') 
AS "YTD Sales"
FROM Customers c
            INNER JOIN Orders o ON o.CustomerID=c.CustomerID
            INNER JOIN [Order Details] od ON od.OrderID=o.OrderID
      WHERE YEAR(OrderDate)=(SELECT MAX(YEAR(OrderDate)) From Orders)
      --WHERE YEAR(OrderDate)=1998 --WHERE YEAR(OrderDate)='1998'

AND o.ShippedDate IS NOT NULL
      GROUP BY c.CustomerID, c.CompanyName
      ORDER BY SUM(UnitPrice * Quantity * (1-Discount)) DESC;

--3.4
