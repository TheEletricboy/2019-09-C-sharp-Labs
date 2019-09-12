using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //integers
            byte bmin = 0;
            byte bmax = 255;        //
            byte b_in_binary = 0b_00000000; //0
            byte bmax_in_binary = 0b_11111111;  //255

            byte bmin_in_hex = 0x_00;   
            byte bmax_in_hex = 0x_ff;   //f=1111 which converts to 15 in decimal

            //byte bnegative_is_invalid = -1;   //this does not exist

            //letters are also stored as numbers
            char letter_01 = 'a';
            Console.WriteLine(letter_01);
            Console.WriteLine((int)letter_01);


            //be aware a STRING is stored as an ARRAY of CHARACTERS

            string s = "Hello";
            char[] s2 = "Hello".ToCharArray();

            Console.WriteLine($"First letter has index 0 ie {s[0]} and {s2[0]}");

            //whole numbers
            //int
            var numberofanytype = 27;   //int is 32bits, but one bit stored the sign which is either + or -
            //so int has 31 bits for number storage
            //positive: 0 to max-1 (0,1,2,3,4..., 9)
            //negative: -1 to max (-1, -2 ,-3, -4...., -10)
            Console.WriteLine(int.MaxValue);
            //2147483647
            Console.WriteLine(int.MinValue);
            //-2147483648 is 2^31 (31 bits of numbers)


            //short
            short short01 = 25; //16bits
            long long01 = 2345234523452345;

            short short02 = 12345;
            int int01 = 1234567890;
            long long02 = 1234567890123456789L;

            //DECIMAL NUMBERS

            //float 32 bits
            float f = 1.23f;

            //double 64 bits 
            double d = 1.23d;

            //decimal 128bits 
            decimal decimal01 = 1.23m;

            //FLOATS AND DOUBLES are not exact ever because convert from binary to decimal
            decimal total = 0m;
            for (int i = 0; i < 8192; i++)
            {
                total += 0.7m;
            }
            Console.WriteLine(total);

            //Positive numbers only, unassing means pure 32bits for number
            uint positiveinteger = 500;
            Console.WriteLine(uint.MaxValue);   //2 to the power of 32

            //Operators
            //a+b = c   (expression)
            //a, b      Operands
            //+, -      Operators

            //Unary (one input)
            //Increment
            int x = 0;
            x++;
            ++x;
            //both above add 1
            //in general just use x++, and use if possible on separate lines
            int y1 = 1000;
            int y2 = 1000;
            int z1 = y1++;      //z1=1000 then increment y1 to 1001
            int z2 = ++y2;      //z2 = (increment y2 first to 1000)
            Console.WriteLine(z1);
            Console.WriteLine(z2);

            //NOT
            Console.WriteLine(!true);      //false
            Console.WriteLine(!!true);     //true


            //binary(two inputs)
            //modulus
            //integer division: take care because int/int = int
            Console.WriteLine(9/4);     //output= 2 (even though 9/4 = 2 1/4)
            //integer part: easy: divide integers
            //fractional part: use modulus (remainder operator)
            Console.WriteLine(9%4);     //output: 1

            //Proper division: one number has to be non-integer

            //Ternary Operator
            //  if(condition) ? returnthisiftrue : returnthisiffalse;
            Console.WriteLine(  (10>4) ? "high" : "low"  );
            Console.WriteLine(  (10<4) ? "high" : "low"  );

            //Nullable 
            int number = 100;
            int? number2 = 1000;
            //number 2 useful if we read from database and its possible
            //the box is blank so returns NULL
            number2 = null;

            //NULL coalesce operator : shorthand for
            Console.WriteLine("somevalue"??"returnthisifnull"); //output: somevalue
            Console.WriteLine(null??"returnthisifnull");

            //Default value
            int somenumber = default;   //assigns 0 onto it
            int? somenumber2 = default; //null

            if (somenumber2 == null) Console.WriteLine("its null boy");

            //bit shift (interest only)
            //              8421
            //wtach this binary 1010 is ?? decimal 8+0+2+0 is 10(decimal)
            //shift binary to right >> to make half in size 1010=>101 which is 5
            //shift        to the left << make double 1010=>10100 ie 20
            Console.WriteLine(0b_1010>>1);  //5
            Console.WriteLine(0b_1010<<1);  //20








        }
    }
}
