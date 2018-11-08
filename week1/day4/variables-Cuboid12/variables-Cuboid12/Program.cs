using System;

namespace variables_Cuboid12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:

            double Cube_Length, Cube_Heigth, Cube_Width;
            Console.WriteLine("Enter Length of Cube : ");
            Cube_Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Heigth of Cube : ");
            Cube_Heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width of Cube : ");
            Cube_Width = Convert.ToDouble(Console.ReadLine());
            double Surface_Area = 2 * Cube_Length * Cube_Width + 2 * Cube_Length * Cube_Heigth + 2 * Cube_Length * Cube_Width;
            double Volume = Cube_Length * Cube_Width * Cube_Heigth;

            Console.WriteLine("Surface Area : " + Surface_Area);
            Console.WriteLine("Volume  : " + Volume);
            // Surface Area: 600
            // Volume: 1000
        }
    }
}
