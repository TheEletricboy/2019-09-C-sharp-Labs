﻿#define DEBUG
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_linq
{
    class Program
    {
        static List<Customer> customers;
  

        static void Main(string[] args)
        {
#if DEBUG
            Console.WriteLine("we are debugging");
            System.Threading.Thread.Sleep(2000);

#endif

            using (var db = new NorthwindEntities())
            {
                //customers = db.Customers.ToList();
                db.Orders.ToList();
                db.Order_Details.ToList();

                //Cannot print this
                //LINQ produces output of type IQueriable 
                //This is an abstract type so we cast it to a list
                var output1 = (from customer in db.Customers
                               select customer).ToList();
                Console.WriteLine("\n\n Trivial LINQ query \n");
                output1.ForEach(c => { Console.WriteLine($"{c.CustomerID}"); });

                Console.WriteLine("\n\n Linq where \n\n");
                var LINQwhere = (from customer in db.Customers
                                 where customer.City == "London" || customer.City == "Berlin"
                                 select customer).ToList();
                PrintCustomers(LINQwhere);

                //LINQwhere.ToList().ForEach(c => Console.WriteLine($"{c.CustomerID, -10}" +
                //    $"{c.City}"));

                Console.WriteLine("\n\nOrder By Customer Name:\n");
                var LINQOrderBy =
                    (from customer in db.Customers
                     where customer.City == "London"
                     orderby customer.ContactName descending
                     select customer).ToList();
                PrintCustomers(LINQOrderBy);

                Console.WriteLine("\n\nLambda has OrderBy..ThenBy\n");
                var LINQOrderByThenBy =
                    db.Customers.Where(c => c.City == "London" || c.City == "Berlin" || c.City == "Madrid")
                    .OrderBy(c => c.City)
                    .ThenBy(c => c.ContactName)
                    .ToList();
                PrintCustomers(LINQOrderByThenBy);
                Console.WriteLine("\n\n Creating a custom output object\n");
                var customObect =
                    from c in db.Customers
                    join order in db.Orders
                        on c.CustomerID equals order.CustomerID
                    select new
                    {
                        Name = c.ContactName,   //have to equals it if the 2 names are different
                        OrderID = order.OrderID,    //i could take OrderID from the begining and nothing would change because theyre the same
                        OrderDate = order.OrderDate,
                        order.ShipCity
                    };
                customObect.ToList().ForEach(item => Console.WriteLine($"{item.Name, -20}{item.OrderID, -10}" +
                    $" {item.OrderDate: dd/MM/yyyy}   {item.ShipCity}"));


                //slick version: print only
                //print customer name, city berlin, order ID, order date, 
                db.Orders.Where(o => o.Customer.City == "Berlin").ToList().ForEach(p => {
                    Console.WriteLine($"{p.Customer.ContactName,-20}{p.Customer.City,-30}{p.OrderID, -15}{p.OrderDate: dd/mm/yyyy}");
                });

                //join 3 tables: order details, orders and customers
                db.Order_Details.Where(od => od.Order.Customer.City == "Berlin").ToList().ForEach(od => {
                    Console.WriteLine($"{od.Order.Customer.ContactName, -20}{od.Order.Customer.City, -15}{od.OrderID, -15}" +
                        $"{od.ProductID, -15}{od.Order.OrderDate: dd/mm/yyy}");
                });

                //get to the product table
                db.Order_Details.Where(od => od.Order.Customer.City == "Berlin").ToList().ForEach(od => {
                    Console.WriteLine($"{od.Order.Customer.ContactName,-20}{od.Order.Customer.City,-15}{od.OrderID,-15}" +
                        $"{od.ProductID,-15}{od.Order.OrderDate: dd/mm/yyy}      {od.Product.ProductName, -25}");
                });

            }






        }

        //hashing helps make the code cleaner
#region PrintBlock
        //print customers (List<Customer> customer)
        static void PrintCustomers(List<Customer> customers)
        {
            customers.ForEach(c => Console.WriteLine($"{c.CustomerID, -10}|{c.ContactName, -25}|{c.City}"));
        }
#endregion PrintBlock



    }
}
