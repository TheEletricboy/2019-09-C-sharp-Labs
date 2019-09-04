using System;

namespace lab10_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Method01();
            Method01(100);
            Method01("hello");
            Method01(100, "goodbye");
        }


        static void Method01() { Console.WriteLine("Blank"); }
        //static void Method01(int x) { Console.WriteLine(x); }
        static void Method01 (int x) { Method01(x, "some value"); } 
        static void Method01(string y) { Console.WriteLine(y); }
        static void Method01(int x, string y) { Console.WriteLine(x+" "+y); }
    }
}
