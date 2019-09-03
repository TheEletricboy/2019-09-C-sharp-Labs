using System;

namespace lab07_methods
{
    class Program
    {


        static void Main(string[] args)
        {
            DoThis();
            DoThisAswell();
            var m = new Mammal();       //m is an instance of the class MAMMAL
            m.GetOlder();       //call in a method from another class: which increases age to 1
            Console.WriteLine(m.Age);
            

            
            //method inside a method
            void DoThis(){

                Console.WriteLine("I am doing something");
            }
            //ATTACH METHOD TO CLASS: ADD 'STATIC' KEYWORD

            CountNumbers(5000);         //y only
            CountNumbers(5000, 3000);   //x and y

            OutParameter(10, 10, out int a);
            Console.WriteLine($"output parameter is: {a}");

            TupleMethod();              //not gathering the output: out put is wasted
            var tupleOutput = TupleMethod();    //output is sent to custom object
            Console.WriteLine($"{tupleOutput.x}, {tupleOutput.y}, {tupleOutput.z}");

        }

        static void DoThisAswell()
        {

            Console.WriteLine("i am doing something as well");
        }

        static void CountNumbers(int y, int x = 100) {
            Console.WriteLine(x*y);
        }

        static void OutParameter(int x, int y, out int z)
        {
            z = x * y;  //will return this as Z
        }

        static (int x, string y, bool z) TupleMethod()
        {
            return (10, "hi", false);
        }

    }

    class Mammal
    {

        public int Age { get; set; }
        public void GetOlder() { Age++; }
    }
}
