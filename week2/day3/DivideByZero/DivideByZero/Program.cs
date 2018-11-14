using System;
using System.IO;
namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                int result = 10 / number;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("you are wrong");
            }
            //static void WriteFile(int number)
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
// Create a function that takes a number
// divides ten with it,
// and prints the result.
// It should print "fail" if the parameter is 0
