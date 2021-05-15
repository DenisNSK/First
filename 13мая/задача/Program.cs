using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("число");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x % 10;
            double b = x / 10;
            double c = a * 10 + b; 
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
