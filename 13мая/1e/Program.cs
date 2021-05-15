using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1e
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y");
            double y = Convert.ToDouble(Console.ReadLine());
            double c = (5 * Math.Cos(y));
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
