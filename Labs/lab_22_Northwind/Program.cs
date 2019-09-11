using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_22_Northwind
{
    class Program
    {
        static List<Product> products;
        static List<Category> categories;

        static void Main(string[] args)
        {
            using (var db = new NorthwindEntities()) {

                products = db.Products.ToList();
                categories = db.Categories.ToList();


            }
            products.ForEach(p => {
                Console.WriteLine($"ID: {p.ProductID, -5} Name: {p.ProductName, -35} " +
                    $"Unit Price: {p.UnitPrice,-15} Discontinued: {p.Discontinued,-35}");
            });
            Console.WriteLine("===================================================================================");
            //categories

            //Products with category name 
            products.ForEach(p => { Console.WriteLine($"ID: {p.ProductID, -10} Name: {p.ProductName, -30} " +
                $"CategoryID from Category table: {p.Category.CategoryName}"); });
            //we access the categroy table because Customer table is connected to it
        }   
















    }
}
