using System;

namespace lab_04_class_summary
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance
            var person01 = new Someone();
            person01.Name = "Phil";
            //console.readline to input data from user

            Console.WriteLine("What is your favourite food?");

            string inputFood = Console.ReadLine();
            person01.SetFood(inputFood);

            Console.WriteLine(inputFood);
        }
    }

    //create class with private /public field & get set
    class Someone {
        public string Name;
        private string Food;

        public string GetFood()
        {
            return this.Food;
        }

        //parameter is data passed into the method
        public void SetFood(string food)
        {
            this.Food = food;
        }
    }

}
