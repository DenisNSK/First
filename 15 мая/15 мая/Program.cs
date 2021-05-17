using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_мая
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x % 10;
            int b =x/10  % 10; 
            int c = x / 100;
            if (x > a * b * c)
            {
                Console.WriteLine("больше");
            }
            else
                        {
                Console.WriteLine("меньше");
            }
            Console.ReadKey();

        }
    }
}
