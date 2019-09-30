using System;

namespace lab_37_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            short s = 12345;
            int i = 123456789;
            long l = 1234567890123456789;
            float f = 123456789012345678901234567890.0f;
            double d = 1223456789012345678901234567890123456789012345678901234567890.0123456789012345678901234567890123456789012345678901234567890;
            decimal deci = 12345678901234567890;

            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(deci);

            unchecked //how to check if it overflows (use UNCHEKED to not check) (WHEN CHECKING IS VERY CPU INTENSIVE)
            {
                //integer maximums MAX = 4. 0,1,2,3,4, -4, -3,-2,-1,0,1,2,3,-4
                Console.WriteLine("==================================");
                int bigInt = int.MaxValue;
                bigInt += 1;
                bigInt += 1;
                bigInt += 1;
                bigInt += 1;
                bigInt += 1;

                Console.WriteLine(bigInt);



                
            }

            DoThis();
        }
        static int counter = 0;
        static void DoThis()
        {
            counter++;
            Console.WriteLine($"DOING THIS {counter}");
            DoThis();
            
        }
    }
}
