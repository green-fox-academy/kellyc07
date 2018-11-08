using System;

namespace MileToKmConverter15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("input the data");
            int distance =int.Parse(Console.ReadLine());
            decimal miles = Convert.ToDecimal(distance * 0.62);
            Console.WriteLine(miles);


        }
    }
}
