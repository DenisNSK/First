using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//3
            Console.WriteLine("x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y = Math.Sqrt(Math.Pow(x, 2) + (Math.Pow(x1, 2)));
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
