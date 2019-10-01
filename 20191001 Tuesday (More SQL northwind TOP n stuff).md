##Tuesday 20191001

#Virtual Machines

Docker can run 'containers' which are mini virtual machines.
	Virtual machine ==> 10GB ==> has 'kernel' which is very large

	Container ==> 2GB max, often much less

Goal
	1)Pull container from internet containing SQL Server
	2)Connect to it and run SQL Server
	3)Talk to Northwind database on that server

COMMANDS

```bash

# get image
docker pull kcornwall/sqlnorthwind
# run iamge
docker run -d --name sql4 -p 1433:1433 kcornwall/sqlnorthwind
# list running images
docker ps
# list all images
docker ps -a
# start/stop
docker start sql
docker stop sql

```

Connect to Docker container:

	1)Lightweight: Azure Data Studio 45mb
	2)Heavier duty: SQL Server Management Studio

Connection Details:
	
	Server 			localhost, 1433
	Authentication 	SQL Server
	User 			SA
	Password 		Passw0rd2018


UPDATE:

```sql
UPDATE mytable set name='fred' where id=2
```

Delete:
```sql
DELETE from mytable where id=2
```

#Normal From

Aims to ensure INTEGRITY of data within a database ie all of the relationships make sense, and all of the data is current and can be found quickly wiht the right searches. No duplication of data etc.

1st Normal form
	
	One field should hold One item of data only eg mobile phone field should not hold 2 mobile numbers

	Atomic: As small as possible ie 1 unit of data per cell

2nd Normal Form:

	All keys depend on PRIMARY KEY

3rd Normal Form

	No keys should have any inter dependent relationships with each other

		Name, Address, Post code, City, County

			In theory the city and county actually are related

		Name, address, post code, city

			County
				City1
				City2


# TOP 
```sql
	select top 5 * from Customers order by customerid desc
```

#Select where..... and......

```sql
	select * from products where unitsinstock < 10 and disctontinued=0;
```

#Operators



#Select Distinct

```sql
	select country from customers order by country 
	select distinct country from customers order by country
```

#as select...as.....

	SELECT (calculation) as 'columnname'

	AS IS OPTIONAL

	SELECT (calculation) 'columnname'


#Contains ==> SQL 'like' keyword
```sql
	#contains 'abc'
	like'%abc%'
	#start
	like 'abc%'
	#end
	like '%abc'
	#does not contain
	like %[^abc]%
	select * from products where ProductName not like 'ch%'
```

#Multiple Exact Hits - Use IN keyword
```sql
	select * from employees where region IN ('wa', 'bc')
```

#Between
```sql
	select * from products where unitprice between 10 and 20
```

#Cumulative functions
```sql
	SUM, COUNT, AVERAGE, MIN, MAX
```

#Maths

Easy to do mathematical operations inside the query

EG: Product Discount
		100£ with 10% discount ==> sell for 90£

		//get product, price, discount, price including discount from ORDER DETAILS

		//customer ==> place order with OrderID
		//order ==> details with Order_DetailId

```sql
	select sum(quantity*unitprice) as 'grosssales', 
sum(quantity*unitprice*(1-discount)) as 'DiscountedSales',
(sum(quantity*unitprice) - sum(quantity*unitprice*(1-discount))) as 'discount given'
from [Order Details]
```

#Substring

```sql
	Substring(string, startindex, length)
	Substring('cheese',,2) returns 'he'
```

#charindex
charindex('', ,'BR23 4AZ') returns 5 in the index of space

LTRIM removes leading spaces

Replace('some text', 'some text', 'cheese') returns 'some cheese'

UPPER

Lower

#Case ...when ...else

case when(x>10) then 'old'
else 'young'
end
as 'are you old'

#Group by ..having

Order by only works for fields which exist initially but not on cumulative fields

	So we can find the sum of all units in stock per product category but this field does not exist initially so we cant order by this field.

	Cumulative fields ie: SUM/MAX/MIN/AVG/COUNT
	Group by 	(selecting into batches)
	Having... 	(Same as ORDER BY)

Order matters!
	
		SELECT DISTINCT FROM WHERE .....
		Group BY ...HAVING....
		ORDER BY...

#JOINS

INNER JOIN = LEFT JOIN

	table1 			table2
		tableid 		table2id

	All from table1 plus matching from table2 only where there is a match

FULL JOIN

	All from table1 plus all from table2 and NULL if no matching record in table2

#Subqueries

Query within a query: useful for large, long queries

```sql

select ...from ...where (select...from...)
//find customers with no orders
Ex: select * from customers where customerId not in (select customerId from orders)

```
#EXTRA TERMS

IDENTITY(1,1) 			Autoincrement starting at value 1 and jump by 1 each time
IDENTITY 				Autoincrement 
PRIMARY KEY CLUSTERED	Only one primary key


#Connection Strings and Environemnt Variables

We can build a connection string