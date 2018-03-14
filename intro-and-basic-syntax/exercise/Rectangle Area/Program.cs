using System;

namespace P02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double widht = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            Console.WriteLine($"{widht*hight:f2}");
        }
    }
}
