using System;

namespace P02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take widht from Console
            double widht = double.Parse(Console.ReadLine());
<<<<<<< HEAD
            //Take hight from Console
            double hight = double.Parse(Console.ReadLine());
            //Print in Console
=======
            ///Entering the widht of the rectangle 

            double hight = double.Parse(Console.ReadLine());
            ///Entering the height of the rectangle

>>>>>>> 3d779b42f414eb164ae31470e3e2183236b2ddf6
            Console.WriteLine($"{widht*hight:f2}");
            ///Calculating and printing the area
        }
    }
}
