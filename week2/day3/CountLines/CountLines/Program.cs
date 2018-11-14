using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Kelly_Chen\Documents\GitHub\kellyc07\week2\day3\CountLines\CountLines\TextFile1.txt";
            WriteLine(path);
        }
        static public void WriteLine(string path)
        {
            try
            {
                string[] content = File.ReadAllLines(path);
                Console.WriteLine(content.Length);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
// Write a function that takes a filename as string,
// then returns the number of lines the file contains.
// It should return zero if it can't open the file, and
// should not raise any error.