select top 5 * from Customers order by customerid desc

select * from Products
select * from Products where UnitsInStock < 10 and Discontinued=0
order by UnitsInStock desc

update products set UnitsInStock=200 where ProductID=31;
select * from Products where UnitsInStock < 10

select country from customers order by country 
select distinct country from customers order by country


select * from products where ProductName like '%ch%'
select * from products where ProductName like 'ch%'
select * from products where ProductName not like 'ch%'
select * from employees where region IN ('wa', 'bc')

select distinct region from customers
select * from customers where region in ('ak', 'bc', 'ca')

select * from products where unitprice between 10 and 15 order by UnitPrice asc


--Count city, country 
select count(distinct (city)) as 'Cities' from customers
select count(distinct (country)) as 'Countries'from customers
--average price, min price max price
select avg(unitprice) as 'averageprice', min(unitprice) as 'minprice', max(unitprice) as 'maxprice' from products
--sum of unis on stock
select sum(UnitsInStock) as 'StockTotal' from products


--//get product, price, discount, price including discount from ORDER DETAILS

--		//customer ==> place order with OrderID
--		//order ==> details with Order_DetailId

select * from orders
select ProductName, [Order Details].UnitPrice, Discount, quantity,  
([Order Details].unitprice *(1- discount)) as 'Discount Price' 
from [Order Details]
inner join Products on products.ProductID = [Order Details].ProductID
order by 'Discount Price' desc


--Get total of (quantity*unitprice) as 'ordervalue'

select sum(quantity)*sum(unitprice) as 'order value' from [Order Details]
select sum(quantity*unitprice) as 'order value' from [Order Details]

--get total of (1-discount)* 'order value'
select sum(quantity*unitprice*(1-discount)) as 'order value' from [Order Details]

--difference

select sum(quantity*unitprice) as 'grosssales', 
sum(quantity*unitprice*(1-discount)) as 'DiscountedSales',
(sum(quantity*unitprice) - sum(quantity*unitprice*(1-discount))) as 'discount given'
from [Order Details]

select 'GROUP BY' 
select supplierid, sum(unitsonorder) as 'Total Units on Order'from products group by SupplierID
having sum(UnitsOnOrder) = 0
order by 'Total Units on Order' desc

select 'GROUP BY' 
select supplierid, sum(unitsonorder) as 'Total Units on Order'from products group by SupplierID
having sum(UnitsOnOrder) > 0
order by 'Total Units on Order' desc

--Subqueries
select * from customers where customerid not in
(select customerid from orders)
