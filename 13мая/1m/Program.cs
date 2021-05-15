using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1m
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y");
            double y = Convert.ToDouble(Console.ReadLine());
            double z = (-5 * (Math.Sqrt(x) + Math.Sqrt(y)));
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
