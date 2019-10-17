using System;
using System.IO;
using System.Diagnostics;

namespace lab_51_CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = new string[]
            {
                "Id, UserName, SpartaId", 
                "0, Miguel, 2019-10-17 13:52", 
                "1, Myles, 2019-10-17 13:53", 
                
            };
            File.WriteAllLines("data.txt", data);
            File.WriteAllLines("data.csv", data);

            Console.WriteLine("Data Written");
            Console.ReadLine();
            Process.Start("EXCEL.exe", "data.csv");

            
        }
    }
}
