using System;

namespace lab_014_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var h = new HolidayWithTravel();
            h.Places();
            h.Activities();
            h.Travel();


            var m = new MaccasWithBurgers();
            m.Burgers();
            m.Plates();
            m.Drinks();
        }

        abstract public class Holiday
        {
            public abstract void Travel();

            public void Places() { Console.WriteLine("Visiting Vienna, salsburg"); }

            public void Activities() { Console.WriteLine("skiing, wlaking, dishing"); }

        }




        public class HolidayWithTravel : Holiday
        {
            public override void Travel()
            {
                Console.WriteLine("By Train Eurostar then HIRE a car");}
            }



        abstract public class Maccas
        {
            public abstract void Burgers();

            public void Plates() { Console.WriteLine("no plates mate we only have trays"); }

            public void Drinks() { Console.WriteLine("Coke n stuff"); }
        }


        public class MaccasWithBurgers : Maccas
        {
            public override void Burgers()      //we must override it 
            {
                Console.WriteLine("we got burgers now");
            }
        }


    }
}
