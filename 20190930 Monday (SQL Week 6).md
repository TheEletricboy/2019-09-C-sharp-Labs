#SQL

SQL Theory Terms

4 Categories

#DML Data Manipulation Language
	Basic queries: Select, Insert, Update, Delete (CRUD Operations)


#DDL Data Definition Language
	Create Data Structures ir Database/Table

		CREATE/DROP  -  database & table  ie add new or remove completely
		ALTER 		 -  table ir to add key/column
		TRUNCATE 	 -  remove
	

#DCL Data Control Language
	Permissions 	Grant/REVOKE



#TCL Transaction Control Language
	Group of transactions TOGETHER
		1) COMMIT (all of the transactions in the group as a whole) eg ATM withdrawl is either all commit or nothing
		2)ROLLBACK to a given point eg start of transaction group
		3)SAVEPOINT: midway point of saving data progression throughout a series of transactions
##==================================================================================================================================
#Basic Commands


```sql
	
	use db01 						//bring into scope
	drop database db01 				//risk of exception if no db present
	drop database if exists db01	
	go 
	create database db01
	go
```

#Data Types

INT
TINYINT
BIT 					0,1,null
CHAR(5)					FIXED WIDTH IE CUSTOMERID='ALFKI';	ASCII ie 8bit
VARCHAR(50) 			Variable width up to 50 max			ASCII ie 8bit
NCHAR /NVARCHAR			UNICODE 							ie 16bit
DATE/TIME/DATETIME
BLOB / BINARY 			BLOB(Binary Large Object) eg MOVIE.mov
???FLOAT
???DECIMAL

#GETTING HELP

```sql

	#meta data about your table
	SP_HELP

``` 
