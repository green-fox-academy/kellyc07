﻿using System;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            char[] charArray = reversed.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));


            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

           
        }
    }
}