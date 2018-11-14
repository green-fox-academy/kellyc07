using System;
using System.IO;
namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Kelly_Chen\Documents\GitHub\kellyc07\week2\day3\PrintEachLine\PrintEachLine\myfile.txt";

            try
            {
                string[] content = File.ReadAllLines(path);
                //Console.WriteLine(content[0]);
                
                for(int i = 0; i<content.Length; i++)
                {
                    Console.WriteLine("{0}", content[i]);
                }
                    


                //StreamReader reader = new StreamReader(path);
                //string line = "";
                // while (line != null)
                //{
                //line = reader.ReadLine();

                //}
            }
            catch (Exception)    //err
            {
                Console.WriteLine("Unable to read file: myfile.txt");
            }
            finally
            {

                Console.ReadLine();
            }
            
        }
            
        
    }
}
// Write a program that opens a file called "my-file.txt", then prints
// each of lines form the file.
// If the program is unable to read the file (for example it does not exists),
// then it should print an error message like: "Unable to read file: my-file.txt"