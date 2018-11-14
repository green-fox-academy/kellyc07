using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            Console.WriteLine("how many the number of chickens the farmer has?");
            string number = Console.ReadLine();

            // The second represents the number of pigs owned by the farmer
            Console.WriteLine("how many pigs the farmer owned ?");
            string animals = Console.ReadLine();
            // It should print how many legs all the animals have
            int a = Convert.ToInt16(number);
            int b = Convert.ToInt16(animals);
            Console.WriteLine("total legs: " + a * b);
           
                
        }
    }
}
