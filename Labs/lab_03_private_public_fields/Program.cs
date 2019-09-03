using System;

namespace lab_03_private_public_fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var person01 = new Person();
            person01 .Name= "Fantasia";
            person01.SetNINO("ABC123");
            //print the NINO
            string output = person01.GetNINO();
            Console.WriteLine(output);

            var person02 = new Person();
            person02.Name = "Bob";
            person02.SetNINO("some data here");

        }
        //===========================================================================================================================
        class Person
        {


        private string NINO;
        public string Name;

        //Getter/ Setter methods to read and write private data

        public string GetNINO()
        {
            return this.NINO;
        }

        //parameter is data passed into the method
        public void SetNINO(string nino)
        {
            this.NINO = nino;
        }

    }

    
}
}
