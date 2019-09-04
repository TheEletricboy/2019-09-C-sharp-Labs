using System;

namespace lab_09_constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            var merc01 = new Mercedes("CHASIS1234ABC", "Silver", 2500);
            var merc02 = new Mercedes();//calling default constructor constructor Mercedes() from the Mercedes class
            

            var aclass01 = new AClass("Chassis123", "blue", 2600);
            var a104 = new A104("Chassis 456", "Red", 1800);
            var a104car02 = new A104("Chassis 456", "Red");
        }



        class Mercedes
        {
            protected string engineChassisID;
            public string Colour { get; set; }

            public int Length { get; set; }

            public Mercedes()   //blank constructor: EXPLICITELY CODE IT
            {

            }

            public Mercedes(string engineChassisID, string colour, int length)
            {
                this.engineChassisID = engineChassisID;
                this.Colour = colour;
                this.Length = length;

            }
        }

        class AClass: Mercedes
        {
            public AClass() { }
            public AClass(string engineChassisID, string colour, int length)
            {
                this.engineChassisID = engineChassisID;
                this.Colour = Colour;
                this.Length = Length;

            }

        }

        class A104: AClass
        {
            // different constructor: calling BASE(parent) constructor

            public A104(string engineChassisID, string colour, int length=2300) : base(engineChassisID, colour, length) { }

        }
    }
}
