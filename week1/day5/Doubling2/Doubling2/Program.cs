using System;

namespace Doubling2
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an integer variable named `baseNum` and assign the value `123` to it
            // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
            // - Print the result of `Doubling(baseNum)`
            DoublingFunction();
        }
         static void DoublingFunction()
        {
            int baseNum = 123;
            Console.WriteLine(baseNum * baseNum);

        }

    }
}
