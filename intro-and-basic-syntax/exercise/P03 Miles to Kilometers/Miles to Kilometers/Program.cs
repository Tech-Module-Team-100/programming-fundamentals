using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read milies from Console
            double mile = double.Parse(Console.ReadLine());
            //Print in Console
            Console.WriteLine((mile * 1.60934).ToString("f2"));
        }
    }
}
