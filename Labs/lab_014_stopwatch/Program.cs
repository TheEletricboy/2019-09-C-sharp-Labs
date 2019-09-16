using System;
using System.Diagnostics; //must have this 
using System.IO;

namespace lab_014_stopwatch
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();


            var counter = 0;
            for (int i = 0; i < 100_000_000; i++)
            {
                counter++;
            }

            

            s.Stop();
            Console.WriteLine(s.Elapsed + " seconds");
            Console.WriteLine(s.ElapsedMilliseconds + " milliseconds");
            Console.WriteLine(s.ElapsedTicks + " pretty fast");

            
        }
    }
}
