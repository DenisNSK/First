using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._87
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            double f = 0;
            if ( x<= 0)
            {
                f = 0;
            }
            else if (x<0 && x <= 1)
            {
                f = x;
            }
            else
            {
                f = x*x;
            }
            Console.WriteLine(f);
            Console.ReadKey();
        }
    }
}
