using System;
using System.IO;
using System.Linq;

namespace lab_013_files
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("myFile.txt"))
            {
                var string1 = File.ReadAllText("myFile.txt");
                Console.WriteLine(string1);
            }

            File.WriteAllText("output.txt", "some data to be saved");

            File.WriteAllText("multiplelines.txt", "some\ndata\non\ndifferent\nlines"); //new lines in a string
            Console.WriteLine(File.ReadAllText("multiplelines.txt"));

            File.WriteAllText("multiplelines.txt", "some" + Environment.NewLine + "text" + Environment.NewLine);




            Console.WriteLine("====Saving Arrays to multiple Files!=====");

            string[] myArray = new string[] { "some data", "data", "in", "multiple", "lines" };
            File.WriteAllLines("multiLineFile.txt", myArray);
            
            //read it back
            var outputArray = File.ReadAllLines("multiLineFile.txt");


            //print array using fancy lambda Syntax
            Array.ForEach(outputArray, item => Console.WriteLine(item));

            Console.WriteLine("\n====Logging====\n");

            

            for (int i = 0; i < 10; i++)
            {
                File.AppendAllText("myFile.log", $" Event happened at time {DateTime.Now}\n"); //perhaps adds to the file
                System.Threading.Thread.Sleep(300);

            }
            File.AppendAllText("myFile.log", $"============================================================================");

            Console.WriteLine(File.ReadAllText("myFile.log"));
            

            //Add add logging to your Rabbit app: Log the date, Time and Rabbit name for
            //each rabbit created

        }
    }
}
