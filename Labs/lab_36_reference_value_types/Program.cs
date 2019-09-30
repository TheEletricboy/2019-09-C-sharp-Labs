using System;
using System.Collections.Generic;

namespace lab_36_reference_value_types
{
    class Program
    {
        static void Main(string[] args)
        {

            //PRIMITIVE TYPE: int, bool, char, struct
            //stored in fast stack memory
            //values are stored with declaration in live, fast code
            //destroyed immediately as well (local variable is destroyed)
            //VALUE TYPES as VALUE stored in STACK MEMORY with declaration
            //var x=10; x and 10 stored on the stack
            //COPY OF VALUE TYPE IS INDEPENDENT
            long x = 10;
            long y = x;

            x = 1000;
            y = 3333;
            Console.WriteLine($"x is {x} and y is {y}");

            //Pass x and Y into a method

            DoThis(x, y);
            Console.WriteLine($"x is {x} and y is {y}");
            //pass x and y by reference into DoThis( permanently)
            DoThisPermanently(ref x, ref y);
            Console.WriteLine($"PERMANENTLY x is {x} and y is {y}");


            //reference types
            //value types are primitives eg int, held on fast stack
            //reference types are large obects
            //so the shortcuts(pointer) is held on the fast stack but the actual object held on the slower HEAP
            //(larger memory)

            //int x=10
            //list<string> mylist -----------> {"one", "two"}

            //Copy reference type: by default you only copy the pointer

            var myArray = new int[] { 100, 200, 300 };
            var myArray2 = myArray; //copy the pointer only not a new object in the HEAP

            Console.WriteLine(string.Join(",", myArray));
            Console.WriteLine(string.Join(",", myArray2));
            myArray[2] = 5000;
            myArray[1] = 14000;
            Console.WriteLine(string.Join(",", myArray));
            Console.WriteLine(string.Join(",", myArray2));

            //reference types naturally are treated as global when passed into a
            //method
            var myList = new List<string>() { "first", "second" };
            DoThisMyList(myList);
            Console.WriteLine(string.Join(",", myList));
        }

        static void DoThis(long x, long y)
        {
            x = x * x;
            y = y * y * y;
            Console.WriteLine($"PRIVATE x is {x} and y is {y}");
        }

        static void DoThisPermanently(ref long x, ref long y)
        {
            x = x * x;
            y = y * y * y;
            
        }

        static void DoThisMyList(List<string> list)
        {
            list.Add("lmao");
            list.Add("git gud");
        }

    }
}
