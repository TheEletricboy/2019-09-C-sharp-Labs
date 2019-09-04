using System;

namespace lab_08_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //object
            object o = 10;

            Console.WriteLine(o);
            Console.WriteLine(o.GetType());

            o = "a str4ing";

            Console.WriteLine(o);
            Console.WriteLine(o.GetType());

            o = new int[1, 2, 3];

            Console.WriteLine(o);
            Console.WriteLine(o.GetType());

            dynamic obj2 = 10;

            Console.WriteLine(obj2);
            Console.WriteLine(obj2.GetType());

            obj2 = "A string";
            Console.WriteLine(obj2);
            Console.WriteLine(obj2.GetType());

            obj2 = new int[1, 2, 3];
            Console.WriteLine(obj2);
            Console.WriteLine(obj2.GetType());

        }
    }
}
