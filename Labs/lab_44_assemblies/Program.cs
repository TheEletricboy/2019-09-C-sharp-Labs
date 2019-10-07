using System;
using System.Reflection;    //WE NEED THIS

namespace lab_44_assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            //use INT type as an example
            var myType = typeof(int);
            //lets find DLL where INT LIVES IN WINDOWS
            //Ie: Assembly
            var myAssembly = Assembly.GetAssembly(myType);
            Console.WriteLine($"Assembly is called {myAssembly.GetName()}\n\n");
            Console.ReadLine();
            //check out all other types in the same assembly
            //pritn them out
            foreach (var type in myAssembly.GetTypes())
            {
                Console.WriteLine(type);
            }
        }
    }
}
