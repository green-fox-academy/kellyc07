using System;
using System.Text;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            Console.WriteLine(quote.IndexOf("you"));
            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            StringBuilder addsomething = new StringBuilder(quote);
            addsomething.Insert(20, " always takes longer than");

            // Using pieces of the quote variable (instead of just redefining the string)

            Console.WriteLine(addsomething);
        }
    }
}
