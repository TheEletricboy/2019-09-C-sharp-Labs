using System;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace lab_30_async
{
    
    class Program
    {
        static List<string> lines = new List<string>();
        static Stopwatch s = new Stopwatch();
        static void Main(string[] args)
        {
            
            s.Start();

            //for (int i = 0; i < 100000; i++)
            //{
            //    File.AppendAllText("data.txt", $"\nAdding line{i} at {DateTime.Now}");
            //    //Console.WriteLine(i);
            //}



            //DoThisLongThing();
            DoThisLongThingAsync();


            s.Stop();
            Console.WriteLine(s.Elapsed);
            Console.ReadLine();
        }

        static void DoThisLongThing()
        {
            Thread.Sleep(3000);
        }

        async static void DoThisLongThingAsync()
        {
            //STREAM in lines using streamreader (dont know exactly length of data we are pulling in)

            using(var reader = new StreamReader("data.txt"))
            {
                while (true)
                {
                    var line = await reader.ReadLineAsync();
                    if (line == null)
                    {
                        break;
                    }

                    lines.Add(line);

                }
                Console.WriteLine($"finished reading {lines.Count} lines which took {s.Elapsed}");
            }

        }

    }
}
