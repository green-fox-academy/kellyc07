using System;

namespace userinput14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user
            Console.WriteLine("Hello users what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("hello {0}",name);
        }
    }
}
