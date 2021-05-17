using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = 0;
            double k = 0;
            if (Math.Sin(x) >= 0)
            {
                k = Math.Pow(x, 2);
            }
            {
                k = Math.Abs(x);
            }
            if (y>=x)
            {
                y = k*x;

            }
            else
            {
                y = k+x;
            }
                       Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
