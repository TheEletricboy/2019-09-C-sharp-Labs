using System;
using System.Collections.Generic;

namespace lab05_rabbits
{
    class Program
    {

        static List<Rabbit> rabbits = new List<Rabbit>();
        static void Main(string[] args)
        {


            //count from 1-10
            for (int i = 1; i <=20; i++)
            {
                var r = new Rabbit();
                r.Age = i;
                

                if (i<10) {
                    r.Name = $"Rabbit0{i}";
                }
                else
                {
                    r.Name = $"Rabbit{i}";
                }
                rabbits.Add(r);
            }

            foreach (var rabbit in rabbits) {
                Console.WriteLine($"Name is {rabbit.Name} and age is {rabbit.Age}");
            }
 
            var age = new Rabbit();
          
        }

        class Rabbit
        {
            public string Name { get; set; }
            public int Age { get; set; }
            
        }
    }
}
