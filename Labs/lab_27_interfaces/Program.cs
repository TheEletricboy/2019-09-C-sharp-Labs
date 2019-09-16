using System;
using external;

namespace lab_27_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();

            c.DoThis();
            c.DoThat();
            c.DoingSomeThings();
            c.AlsoDoThis();

        }

    }


    class Parent {
        public void DoingSomeThings() { Console.WriteLine("Doing some things"); }
    }

    class Child : Parent , IDoThis , IDoThat , IAlsoDoThis{
        public void DoThis() { Console.WriteLine("Im doing this"); }
        public void DoThat() { Console.WriteLine("Im doing that"); }
        public void AlsoDoThis() { Console.WriteLine("I also do this"); }
    }

    interface IDoThis {
        void DoThis(); }

    interface IDoThat {
        void DoThat(); }

    

}

namespace external
{
    interface IAlsoDoThis
    {
        void AlsoDoThis();
    }
}
