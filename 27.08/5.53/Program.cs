using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._53
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = (0);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Введите число");
                int a = Convert.ToInt32(Console.ReadLine());
                s = s + a;
            }
            double sr = s / 10.0;
            Console.WriteLine(sr);
            Console.ReadLine();
        }
    }
}
