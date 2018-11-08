using System;

namespace variables_SecondsInADay13
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int remainingHours = 24 - currentHours - 1;
            int remainingMinutes = 60 - currentMinutes;
            int remainingSeconds = 60 - currentSeconds;

            Console.WriteLine(remainingHours * 60 * 60 + remainingMinutes * 60 + remainingSeconds);
            
            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
        }
    }
}
