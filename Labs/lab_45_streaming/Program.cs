using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System.Net;

namespace lab_45_streaming
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        //Deserialize to list
        static List<Customer> customersFromXML = new List<Customer>();
        static void Main(string[] args)
        {
            var customer01 = new Customer()
            {
                CustomerID = "ALFKI",
                ContactName = "Fred",
                CompanyName = "Sparta",
                City = "Berlin"
            };
            
            var customer02 = new Customer()
            {
                CustomerID = "BOB22",
                ContactName = "Bob",
                CompanyName = "Sparta",
                City = "Berlin"
            };

            var customer03 = new Customer()
            {
                CustomerID = "CHAR1",
                ContactName = "Charles",
                CompanyName = "Sparta",
                City = "Berlin"
            };
            customers.Add(customer01);
            customers.Add(customer02);
            customers.Add(customer03);


            //LIST
            //Serialize to XML, JSON and BINARY
            var formatter = new SoapFormatter();
            //Save to FILE ('Stream' to file system)
            using (var stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, customers);
            }
            //Run code and see visually the output
            Console.WriteLine(File.ReadAllText("data.xml"));
            //Reverse Process ==> Tsream Back and deserialize data
            //open file as a stream
            using (var reader = File.OpenRead("data.xml"))
            {
                //Deserialize to list
                customersFromXML = formatter.Deserialize(reader) as List<Customer>;
            }
            //Print out List
            customersFromXML.ForEach(c => {
                Console.WriteLine($"{c.CustomerID,-15}" +
                    $"{c.ContactName,-20} {c.City}");
            });
            //REPEAT SIMULATE STREAMING FROM INTERNET
            //for the sake of time: easy version: synchronous (not async)
            var getHTMLdata = 
                WebRequest.Create("https://raw.githubusercontent.com/philanderson888/data/master/Customers.xml");
            getHTMLdata.Proxy = null;
            //get web response from request to that url
            using (var webresponse = getHTMLdata.GetResponse())
            {
                //STREAM DATA IN BECAUSE IT COULD BE LARGE FILE, NO IDEA SIZE
                using (var webstream = webresponse.GetResponseStream())
                {
                    //Get web stream above;now new stream to stream to local file system for processing
                    using (var filestream = File.Create("CustomersFromWeb.xml"))
                    {
                        webstream.CopyTo(filestream);
                    }
                }
            }

            using (var reader2 = File.OpenRead("CustomersFromWeb.xml"))
            {
                //Deserialize to list
                customersFromXML = formatter.Deserialize(reader2) as List<Customer>;
            }
            //Print out List
            Console.WriteLine("CUSTOMERS FROM WEB");
            customersFromXML.ForEach(c => {
                Console.WriteLine($"{c.CustomerID,-15}" +
                    $"{c.ContactName,-20} {c.City}");
            });




        }
    }

    [Serializable]
    class Customer
    {
        //[NonSerialized]
        private string NINO;
        public string CustomerID { get; set;}
        public string ContactName { get; set;}
        public string CompanyName { get; set;}
        public string City { get; set; }

        public Customer()
        {
            this.NINO = "ABCD";
        }
    }

}