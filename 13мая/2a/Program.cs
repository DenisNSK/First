using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            double x1 = (-1 / (Math.Pow(x, 2)));
            Console.WriteLine(x1);
            Console.ReadKey();
        }
    }
}
