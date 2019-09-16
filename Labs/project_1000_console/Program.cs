using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace project_1000_console
{
    class Program
    {

        static List<Rabbit> rabbits;
        static void Main(string[] args)
        {
            //stopwatch
            var s = new Stopwatch();
            s.Start();

            int numberOfRabbitsToCreate = 1003;
            //one read
            //using (var db = new RabbitDbEntities())
            //{
            //    rabbits = db.Rabbits.ToList();

            //}


            rabbits = new List<Rabbit>();
            for (int i = 0; i < numberOfRabbitsToCreate; i++)
            {
                using (var db = new RabbitDbEntities())
                {
                    //AddBunnies();
                    db.Rabbits.ToList();
                    var rabbit = (Rabbit)db.Rabbits.Find(i + 1);
                    rabbits.Add(rabbit);

                }
            }
            PrintRabbits();

            s.Stop();
            Console.WriteLine(s.Elapsed + " seconds");
            //Console.WriteLine(s.ElapsedMilliseconds + " milliseconds");

            //report times to console
            //report times to CSV
            File.WriteAllText("RabbitOutPut.csv", "Id,Name,Age");
            File.AppendAllText("RabbitOutPut.csv", "\n1,Billy,12"); //or do Environment.Newline
            File.AppendAllText("RabbitOutPut.csv", "\n2,Fluffy,13");
            Process.Start("RabbitOutput.csv");

            //report times to Word
            //sprint 2: move everything to WPF


            

        }
        static void PrintRabbits()
        {
            //print rabits with lamba
            rabbits.ForEach(rabbit => Console.WriteLine($"{rabbit.RabbitId,-5}" +
                $"{rabbit.RabbitName}"));
        }

        static void AddBunnies()
        {
            var newRabbit = new Rabbit()
            {
                Age = 0,
                RabbitName = $"Rabbit whatever"
            };

            using (var db = new RabbitDbEntities())
            {
                db.Rabbits.Add(newRabbit);
                db.SaveChanges();
            }
        }
    }
}
