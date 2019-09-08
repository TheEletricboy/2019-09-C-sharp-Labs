using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_017_rabbit_database_explosion
{
    class Program
    {
        static List<Rabbit> rabbits;

        static void Main(string[] args)
        {
            

            using (var db = new RabbitDbEntities())
            {
                rabbits = db.Rabbits.ToList();
            }

            PrintRabbits();

            //foreach (var rabbit in rabbits)             //normal way
            //{
            //    Console.WriteLine($"{rabbit.RabbitId,5}" +
            //    $"{rabbit.Name,-12}{rabbit.Age}");
            //}

            //for the weekend: WPF TextBox01.txt ==> use for Age, Name (2 Boxes)
            //button add: run this code

            var newRabbit = new Rabbit()
            {
                Age = 0,
                Name = $"Rabbit{rabbits.Count+1}"
            };

            using (var db = new RabbitDbEntities())
            {
                db.Rabbits.Add(newRabbit);
                db.SaveChanges();
            }


            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"\n ====After adding new rabbits ===== \n");
            //read db from scratch
            using (var db =new RabbitDbEntities())
            {
                rabbits = db.Rabbits.ToList();
                PrintRabbits();
            }

            
        }


        static void PrintRabbits()
        {
            //print rabits with lamba
            rabbits.ForEach(rabbit => Console.WriteLine($"{rabbit.RabbitId,-5}" +
                $"{rabbit.Name,-12}{rabbit.Age}"));
        }















    }
}
