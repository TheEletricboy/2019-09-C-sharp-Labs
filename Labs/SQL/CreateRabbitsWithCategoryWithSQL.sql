﻿use master
go

drop database if exists RabbitDb
go

create database RabbitDb
go

use RabbitDb
go

create table Categories(
CategoryId INT IDENTITY PRIMARY KEY NOT NULL,
CategoryNames VARCHAR(50) NULL
)

create table Rabbits(
RabbitId int IDENTITY PRIMARY KEY NOT NULL,
RabbitName varchar(50) NULL,
Age INT NULL,
CategoryId INT NULL,
FOREIGN KEY (CategoryId) REFERENCES Categories (CategoryId)
)



insert into Categories values ('White')
insert into Categories values ('Black')
insert into Categories values ('Pink')

insert into Rabbits values ('Bunny', 10, 1);
insert into Rabbits	values ('Hopy', 12,2);
update Rabbits set CategoryId=3 where RabbitId=1;



select * from Rabbits
select * from Categories