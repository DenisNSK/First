using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            double k = 0;
            if ( Math.Sin(x)>=0)
            {
                k = Math.Pow(x,2);

            }
            else
            {
                k = Math.Abs(x);
            }
            double y = 0;
            if(x>=k)
            {
                y = Math.Abs(x);
            }
            {
                y = k * x;
            }

            Console.WriteLine("y=" + y);
            Console.ReadKey();
        }
    }
}
