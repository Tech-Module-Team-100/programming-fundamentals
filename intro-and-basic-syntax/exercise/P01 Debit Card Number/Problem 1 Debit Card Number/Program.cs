//CONFIRMED Vladi96 <- GitHub and Vladi_9_6 <-SoftUni
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1_Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
    // changing the names of the variables
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1.ToString("D4") + " " + number2.ToString("D4") + " " + number3.ToString("D4") + " " + number4.ToString("D4"));

        }
    }
}
