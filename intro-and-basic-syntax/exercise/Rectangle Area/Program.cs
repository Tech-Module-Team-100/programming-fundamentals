using System;

namespace P02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            ///Entering the widht of the rectangle 

            double hight = double.Parse(Console.ReadLine());
            ///Entering the height of the rectangle

            Console.WriteLine($"{widht*hight:f2}");
            ///Calculating and printing the area
        }
    }
}
