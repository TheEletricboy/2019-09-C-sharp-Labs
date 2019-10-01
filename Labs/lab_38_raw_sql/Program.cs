using System;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace lab_38_raw_sql
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //List of Customers
            List<Customer> customers = new List<Customer>();

            string connectionstring = @"Data Source=localhost;Initial Catalog=Northwind;
            Persist Security Info=True; User Id=SA;Password=Passw0rd2018";
            using (var connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                Console.WriteLine(connection.State);
            }

            string connectionstring2 = @"Data Source=localhost;Initial Catalog=Northwind;";
            using (var connection2 = new SqlConnection(connectionstring))
            {
                connection2.Open();
                Console.WriteLine(connection2.State);


                //code
                string sqlquery01 = "select * from customers";
                using (var sqlcommand = new SqlCommand(sqlquery01, connection2))
                {
                    //read customers on a loop
                    var reader = sqlcommand.ExecuteReader();
                    while (reader.Read())
                    {
                        var CustomerID = reader["CustomerID"].ToString();
                        var ContactName = reader[""].ToString();
                        var CompanyName = reader["CompanyName"].ToString();
                        var City = reader["City"].ToString();
                        var Country = reader["Country"].ToString();
                        //new customer
                        var customer = new Customer();
                        //add customer to list of customers
                        customers.Add(customer);

                    }
                }
            }
        }

        class Customer
        {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        }

    }
}

