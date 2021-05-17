using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("переменная");
            double x = Convert.ToDouble(Console.ReadLine());
            double f = 0;
            if (x > 2)
            {
                f = 2;
            }
            else if(0<x||x<=2)
            {
                f = 0;
            }
            else
            {
                f=-3*x;
            }
            Console.WriteLine("f="+f);
            Console.ReadKey();
        }
    }
}
