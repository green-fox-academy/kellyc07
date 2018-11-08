using System;

namespace types3
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            int hours = 6;
            Console.WriteLine("An average Green Fox attendee codes {0} daily", hours );
            // The semester is 17 weeks long
            int weeks = 17;
            Console.WriteLine("The semester is {0} long", weeks);
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            Console.WriteLine("spend {0} hours on workdays", hours*5);
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine("the percentage of coding hours in workhours {0}", (decimal)hours * 5 /(decimal) 52);
        }
    }
}
