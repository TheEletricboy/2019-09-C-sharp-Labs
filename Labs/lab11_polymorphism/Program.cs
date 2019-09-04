using System;

namespace lab11_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var dad01 = new Dad(24, "Me name is dad");
            dad01.AgeChange();
            
            var child01 = new Child();
            child01.AgeChange();

            Console.WriteLine($"the dads age is{dad01.Age} and the child is {child01.Age}");
            
        }

        class Dad
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public Dad()
            {

            }

            public Dad(int age, string name)
            {
                this.Age = age;
                this.Name = name;

                
            }

            public virtual void AgeChange()
            {
                Age++;
            }
        }





        class Child: Dad
        {
            
            public override void AgeChange() {
                Age += 2;           //we are adding 2 years instead of 1 from DAD()
                base.AgeChange();   //gets the AgeChangeMethod() from the parent method
            }  
            public Child(int age, string name) : base(age, name)
            {
               // this.Age = 10;
            }
        }
    }






    //create base class(Parent)
    //create child class
    //add 2 fields (one numeric)
    //add constructor
    //parent add method (change number)
}
