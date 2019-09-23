using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace lab_31_tasks
{
    class Program
    {

        
        static void Main(string[] args)
        {
            var stop1 = new Stopwatch();
            var stop2 = new Stopwatch();
            //anonymous (lambda) delegate
            var task01 = new Task(() => { Console.WriteLine("running task01"); }   );
            task01.Start();

            //delegate is a PLACEHOLDER for one or more methods
            //the simplest delegate is called an ACTION
            //ACTION: void DoThis(){}     //no parameters in, void output
            var taskOld = new Task(   DoThis  );
            taskOld.Start();

            var task02 = Task.Run(() => { Console.WriteLine("task02 is running"); });

            var taskArray = new Task[10];
            taskArray[0] = Task.Run(() => { Console.WriteLine("[taskArray01]"); } );
            taskArray[1] = Task.Run(() => { Console.WriteLine("[taskArray02]"); } );
            taskArray[2] = Task.Run(() => { Console.WriteLine("[taskArray03]"); } );

            var counter = 3;
            for (int i = 3; i < 10; i++)
            {
                
                taskArray[i] = Task.Run(() => { Console.WriteLine($"--Task array{counter}--"); });
                System.Threading.Thread.Sleep(10);
                counter++;
            }

            Task.WaitAll(taskArray);
            //Console.ReadLine();


            stop1.Start();
            
            var myList = new List<string> { "a", "b", "c" };
            myList.ForEach((s) => {
                Console.WriteLine($"Item is {s}");
                System.Threading.Thread.Sleep(50);
            });
            stop1.Stop();
            Console.WriteLine($"MY LIST FOR EACH: {stop1.Elapsed}");

            //Parallel ForEach
            stop2.Start();
            Parallel.ForEach(myList, (s) => {
                Console.WriteLine($"Parallel item is {s}");
                System.Threading.Thread.Sleep(50);
            });
            Console.WriteLine($"PARALLEL IS  {stop2.Elapsed}"); //this one is 3 times faster than the other
            stop2.Stop();

            //PLINQ Parallel LINQ
            var output = (from item in myList select item).ToList();
            var outputASPARALLEL = (from item in myList select item).AsParallel().ToList();

            //getting data back from a task
            //var t = Task.Run( ()=>{} );
            //var t = Task<T>.Run...... return data of type T
            //access data with T.Result

            var taskWithResult = Task<int>.Run( ()=> {
                return 100;
            });
            taskWithResult.Wait();
            Console.WriteLine($"result of our task is {taskWithResult.Result}");


            Console.ReadLine();
        }

        static void DoThis()
        {
            Console.WriteLine("I am doing something");
        }
    }
}
