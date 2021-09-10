using System;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            costumer person;
            person = new costumer();

            Console.WriteLine(" välj (1)Skapa ny kund | (2)Visa antal kunder | (3)Visa lista över alla kunder (4)Avsluta");
            while (true)
            {


                string x = Console.ReadLine();
                if (x == "1")
                {
                    Console.WriteLine("Mata in ditt namn");
                    person.name = Console.ReadLine();
                    Console.WriteLine("Mata in din ålder: ");
                    person.age = Console.ReadLine();
                    Console.WriteLine("Mata in din längd: ");
                    person.height = Console.ReadLine();
                    Console.WriteLine($"{person.name}  {person.age}  {person.height}");
                    break;
                }
                if (x == "2")
                {

                }

                if (x == "3")
                {

                }

                if (x == "4")
                {

                }

            }
        }






        public class costumer
        {
            public string name;
            public string age;
            public string height;
        }
    }
}
