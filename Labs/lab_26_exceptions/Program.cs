using System;
using System.IO;

namespace lab_26_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //error: when your bank calculates our interest incorrectly: programmer error in logic
            //exception: code crashes so the program cannot continue 

            //handled: the excepton takes place inside a TRY BLOCK, code is handled in the CATCH BLOCK
            //          whether exception or not, then run the FINALLY BLOCK

            //unhandled: messy exception: program terminates uncleanly
            //compiler: REDLINE IR WILL NOT BUILD

            //runtime: eg divide by zero

            int x = 10;
            int y = 0;
            //Console.WriteLine(x/y);   //unhandled exception

            try {
                //any code that might produce an exception
                Console.WriteLine(x/y); //throw an exception
            }
            catch(Exception e) {
                Console.WriteLine("hey dont do that");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("have fun");
            }


            Console.WriteLine("===============================================================");

            //custom exceptions
            var MyException = new Exception("hey this is a phil special");
            try{
                //imagine engine is GETTING HIT BUT HAS NOT BURNED OUT YET
                throw (MyException);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Large Application
            //Nesting: MAIN, SUB, SUB.
            try
            {
                try
                {
                    try
                    {
                        throw (new Exception("Inner Exception - phills code"));
                    }
                    catch(Exception e) { throw; }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                File.WriteAllText("log.txt", $"Phils code not working again - typical - {e.Message}");
            }

            //types of exceptions 
            try { }
            catch(DivideByZeroException) {
                Console.WriteLine("dont do that");
            }
            catch (Exception e) {
                Console.WriteLine("all exceptions");

            }








        }
    }
}
