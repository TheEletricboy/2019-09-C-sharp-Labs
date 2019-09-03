using System;

namespace tab_02_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //use the class: create a new Dog Object 
            var dog01 = new Dog(); //create new empty black Dog Object
            dog01.Name = "Fido";
            dog01.Age = 1;
            dog01.Height = 400;

            //grow our dog!
            dog01.Grow();
            //PRINT new age and height
            Console.WriteLine("Age is: " + dog01.Age + " and height is: " + dog01.Height);
            dog01.Grow();
            //$ literal syntax: just print whats inside
            //except {} CURLY BRACES: PUT VARIABLES IN THEM
            Console.WriteLine($"Age is {dog01.Age} and the height is {dog01.Height}");
        }
    }

    //intructions/blueprint for creating new dog object ==> all this an INSTANCE of a class
    class Dog {
        public string Name;
        public int Age;
        public int Height;

        public void Grow()      //have a method but return nothing
        {
            //LET THE PC KNOW: IS IT RETURNING ANY VALUE???
            //IF NO ==> USE KEYWORD "VOID"
            //IF YES ==> SPECIFIY THE TYPE: IE INT, STRING

            this.Age++; //instead of Age = Age +1 or Age +=1
            this.Height += 10;  //when using THIS youre telling the program to change the actual CLASS VARIABLES


        }
    }
}
