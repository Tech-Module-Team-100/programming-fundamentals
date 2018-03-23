using System;

namespace P02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take widht from Console
            double widhtDouble = double.Parse(Console.ReadLine());
            //Take hight from Console
            double hightDouble = double.Parse(Console.ReadLine());
            //Print in Console
            Console.WriteLine($"{widhtDouble*hightDouble:f2}");
        }
    }
}
