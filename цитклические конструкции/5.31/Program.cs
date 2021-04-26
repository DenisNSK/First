using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double n = Convert.ToDouble(Console.ReadLine());
            double f = (0);
            for (int i = 1; i <= n; i++)
            {
                f = f + 1.0/i;


            }
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
