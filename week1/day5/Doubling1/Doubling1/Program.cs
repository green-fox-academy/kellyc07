﻿using System;

namespace Doubling1
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 123;

            Console.WriteLine(DoublingFunction(baseNum));
        }

        // - Create an integer variable named `baseNum` and assign the value `123` to it
        // - Create a function called `Doubling` that doubles it's input parameter and returns with an integer
        // - Print the result of `Doubling(baseNum)`
       
        public static int DoublingFunction(int baseNum)
        {
            return (baseNum * baseNum);      
        }
        }
    
    }
  
