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

            using (var db = new NorthwindEntities())
            {
                //customers = db.Customers.ToList();

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
