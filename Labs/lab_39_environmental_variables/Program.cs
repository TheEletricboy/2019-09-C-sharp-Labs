using System;
using System.Collections.Generic;
using System.Collections;

namespace lab_39_environmental_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (DictionaryEntry item in Environment.GetEnvironmentVariables())
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }
            //query 
            Console.WriteLine("=============================================");
            Console.WriteLine(Environment.GetEnvironmentVariable("WinDir"));


            //set one
            Environment.SetEnvironmentVariable("SecretPassword", "123");
            Console.WriteLine(Environment.GetEnvironmentVariable("SecretPassword"));


        }
    }
}
