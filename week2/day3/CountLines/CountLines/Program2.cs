using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CountLines
{
    class Program2
    {
        static void Main(string[] args)
        {
            WriteLine(@"C:\Users\Kelly_Chen\Documents\GitHub\kellyc07\week2\day3\CountLines\CountLines\TextFile1.txt");
        }
        static void WriteLine(string filename)
        {
            try
            {
                string[] content = File.ReadAllLines(filename);
                string path = @"C:\Users\Kelly_Chen\Documents\GitHub\kellyc07\week2\day3\CountLines\CountLines\TextFile1.txt";
                Console.WriteLine(content.Length);
            }

            catch (Exception error)    //err
            {
                Console.WriteLine("Unable to read file: TextFile1.txt");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
