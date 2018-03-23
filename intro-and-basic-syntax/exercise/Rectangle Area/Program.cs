using System;

namespace P02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take widht from Console
            double widht = double.Parse(Console.ReadLine());
            //Take hight from Console
            double hight = double.Parse(Console.ReadLine());
            //Print in Console
            Console.WriteLine($"{widht*hight:f2}");
        }
    }
}
