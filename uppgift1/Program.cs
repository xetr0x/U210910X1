using System;
using System.Collections.Generic;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<costumer> person = new List<costumer>();


            
            while (true)
            {
                Console.WriteLine(" välj (1)Skapa ny kund | (2)Visa antal kunder | (3)Visa lista över alla kunder (4)Avsluta");


                string x = Console.ReadLine();
                if (x == "1")
                {
                    
                    Console.WriteLine("Mata in ditt namn");
                    string name = Console.ReadLine();
                    Console.WriteLine("Mata in din ålder: ");
                    string age = Console.ReadLine();
                    Console.WriteLine("Mata in din längd: ");
                    string height = Console.ReadLine();
                    person.Add(new costumer() { costumername = name, costumerage = age, costumerheight = height});
                    Console.Clear();
                    
                    
                }
                if (x == "2")
                {
                    Console.WriteLine($" Antalet personer i databasen: {person.Count} " );

                }

                if (x == "3")
                {
                    
                    foreach (costumer c in person)
                    {
                        Console.WriteLine($"{c.costumername} {c.costumerage} {c.costumerheight}");
                        Console.WriteLine($"{c.costumername} {c.costumerage} {c.costumerheight}");
                        Console.WriteLine($"{c.costumername} {c.costumerage} {c.costumerheight}");
                    }
                }

                if (x == "4")
                {
                    break;
                }
                if (x != "1" && x != "2" && x != "3" && x != "4")
                {
                    Console.WriteLine("skriv in 1, 2 , 3 eller 4!!!");
                }

            }
        }
            public class costumer
            {
                 public string costumername;
                 public string costumerage;
                 public string costumerheight;
            }
    }
}
