/* put master in scope */
use master
go
drop database if exists OrangeDB
drop database if exists Oranges

go
create database OrangeDB
go
use OrangeDB
drop table if exists Oranges

--create sub-relationship table FIRST

create table Categories(
	CategoryId INT not null IDENTITY PRIMARY KEY,
	CategoryName NVARCHAR(50) null
)

create table Oranges(
	OrangeId int not null IDENTITY PRIMARY KEY,
	OrangeName NVARCHAR(50) NULL,
	DateHarvested Date NULL,
	isLuxuryGrade Bit NULL,
	CategoryId int null FOREIGN KEY REFERENCES Categories(CategoryId)
)

create table Batch(
	BatchId int not null identity primary key,
	OrangeID int null foreign key references Oranges(OrangeID),
	Quantity int null,
	DespatchDate Date null

)

--populate minor category table first
insert into Categories values('clementines');
insert into Categories values('reds');
insert into Categories values('easy peelers');

insert into Oranges values('Clementine', '2019-09-07', 0, 2);
insert into Oranges values('Blood Orange', '2019-09-15', 1, 1);
insert into Oranges values('Tangerine', '2019-09-08', 0, 3);
insert into Oranges values('Clementine', '2018-12-25', 0, 1);

insert into Batch values(1, 10, '2019-09-30');
insert into Batch values(2, 10, '2019-09-30');
insert into Batch values(3, 10, getdate());
insert into Batch values(4, 50, '2019-08-01');

select * from Oranges
select * from Categories

select * from Oranges
inner join categories on oranges.categoryid = categories.categoryid

--Expiry Date = Harvested Date + 90 days
select orangeid, orangename, categoryname, dateharvested, DATEADD(d,90,dateharvested) as 'expirydate'
from oranges inner join categories on oranges.CategoryId = Categories.CategoryId;

--select *, (DATEDIFF(d, dateHarvested, GETDATE())) as 'SinceExpired',
--CASE
--(DATEDIFF(d, dateharvested, GETDATE())) > 90 THEN 'true'
--ELSE 'false'
--END
--AS 'IsExpired'
--from batch
--inner join oranges on oranges.OrangeId=batch.OrangeID