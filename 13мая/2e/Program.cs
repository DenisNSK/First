using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c");
            double c = Convert.ToDouble(Console.ReadLine());
            double q = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4*(a * c))));
            Console.WriteLine(q);
            Console.ReadKey();
        }
    }
}
