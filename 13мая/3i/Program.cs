using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3i
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("d");
            double d = Convert.ToDouble(Console.ReadLine());
            double s = (a * b + b * c / a * d);
            Console.WriteLine(s);
            Console.ReadKey();



        }
    }
}
