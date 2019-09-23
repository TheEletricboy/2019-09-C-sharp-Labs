using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_31_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //anonymous (lambda) delegate
            var task01 = new Task(() => { Console.WriteLine("running task01"); }   );
            task01.Start();

            //delegate is a PLACEHOLDER for one or more methods
            //the simplest delegate is called an ACTION
            //ACTION: void DoThis(){}     //no parameters in, void output
            var taskOld = new Task(   DoThis  );
            taskOld.Start();

            var task02 = Task.Run(() => { Console.WriteLine("task02 is running"); });


            Console.ReadLine();
        }

        static void DoThis()
        {
            Console.WriteLine("I am doing something");
        }
    }
}
