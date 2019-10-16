use master
go

drop database if exists ToDoItemsDatabase
go

CREATE DATABASE ToDoItemsDatabase
go

use ToDoItemsDatabase
go

CREATE TABLE Users(
	UserId INT NOT NULL IDENTITY PRIMARY KEY,
	UserName NVARCHAR(50) NULL,
);

CREATE TABLE Categories(
	CategoryId INT NOT NULL IDENTITY PRIMARY KEY,
	CategoryName NVARCHAR(50) NULL,
)

CREATE TABLE ToDoItems(
	ToDoItemId INT NOT NULL IDENTITY PRIMARY KEY,
	Item VARCHAR(50) NULL,
	DateDue DATE NULL,
	Done bit NULL,
	CategoryId INT NULL FOREIGN KEY REFERENCES Categories(CategoryId),
	UserId INT NULL FOREIGN KEY REFERENCES Users(UserId),
);

INSERT INTO Users VALUES ('Bob');
INSERT INTO Users VALUES ('Bill');
INSERT INTO Users VALUES ('Ben');

INSERT INTO Categories VALUES ('Admin');
INSERT INTO Categories VALUES ('Database');
INSERT INTO Categories VALUES ('Coding');

INSERT INTO ToDoItems VALUES ('first item', GETDATE(), 0, 1, 2);
INSERT INTO ToDoItems VALUES ('second item', GETDATE(), 1, 2, 3);
INSERT INTO ToDoItems VALUES ('third item', GETDATE(), 0, 2, 1);
INSERT INTO ToDoItems VALUES ('fourth item', GETDATE(), 1, 3, 1);
INSERT INTO ToDoItems VALUES ('fifth item', GETDATE(), 1, 1, 3);
INSERT INTO ToDoItems VALUES ('sixth item', GETDATE(), 1, 2, 3);
INSERT INTO ToDoItems VALUES ('seventh item', GETDATE(), 0, 3, 2);
INSERT INTO ToDoItems VALUES ('eigth item', GETDATE(), 0, 3, 2);

select * from Users;
select * from Categories;
select * from ToDoItems;