use master

drop database if exists RabbitDb
go

create database RabbitDb
go

select 'here is a comment'
use RabbitDb
go


Create table Rabbits(
	RabbitId INT NOT NULL IDENTITY PRIMARY KEY,
	Age INT,
	Name NVARCHAR(50) NULL
);

INSERT INTO Rabbits Values ('1', 'Rabbit01')
INSERT INTO Rabbits Values ('0', 'Rabbit02')
INSERT INTO Rabbits Values ('5', 'Rabbit03')
INSERT INTO Rabbits Values ('5', 'Rabbit04')
INSERT INTO Rabbits Values ('5', 'Rabbit05')
INSERT INTO Rabbits Values ('5', 'Rabbit06')
INSERT INTO Rabbits Values ('5', 'Rabbit07')


Update Rabbits Set Name='Dead' WHERE RabbitId=3

--delete from rabbits where RabbitId=3

select * From Rabbits


