using System;

namespace types1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            string name;
            name = "John Doe";
            Console.WriteLine("my name is " + name);
            //  - Your age
            int age;
            age = 31;
            Console.WriteLine("my age is " + age);
            //  - Your height in meters (as a decimal fraction)
            decimal height = 1.87m;
            Console.WriteLine("my height is " + height);
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87
        }
    }
}
