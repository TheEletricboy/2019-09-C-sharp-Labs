using System;
using System.Threading;
using System.Collections.Generic;

namespace lab_12_rabbit_explosion
{
    class Program
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static public int maxPop = 200;

        static void Main(string[] args)
        {
            var ageCounter = 0;
            var agePro = 3;

            var r0 = new Rabbit();
            r0.Age = ageCounter;

            r0.Name = $"Rabbit{ageCounter}";

            rabbits.Add(r0);
            //Console.WriteLine($"{r0.Name} and age{r0.Age}");
            Console.WriteLine($"{r0.Name}");
            ageCounter++;

            while (true)
            {
                
                var r = new Rabbit();
                r.Age = ageCounter;
                
                r.Name = $"Rabbit{ageCounter}";

                rabbits.Add(r);
                //Console.WriteLine($"{r.Name} and age{r.Age}");
                Console.WriteLine($"{r.Name}");



                if (rabbits.Count > maxPop)
                {
                    Console.WriteLine("Population max exceeded!!!!");
                    break;
                }

                if (ageCounter >= agePro)
                {
                    agePro += ageCounter;       //if the age of rabbits is bigger or equal to whatever value I assign to agePro then add
                                                //the value of agePro to the value of ageCounter
                    Console.WriteLine("I am now ABLE TO REPRODUCE===============================");
                    
                }


                Thread.Sleep(200);
                ageCounter++;
            }

            

        }

        class Rabbit
        {
            public string Name { get; set; }
            public int Age { get; set; }



            public Rabbit()
            {

            }

            public Rabbit(string Name, int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
            
        }
    }



    //    Thread.Sleep(200); 1/5 secs
    //loop it
    //Every loop, create a new rabbit and add to list of rabbits
    //set a population limit and see how many iterations it takes to reach population limit
    }

