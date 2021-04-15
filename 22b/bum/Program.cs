using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = k % 10;
            int b = k / 100;
            int c = k / 10 % 10;
                        if (Math.Pow(k, 2) == Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 2))
            {
                Console.WriteLine("raven");
            }
            else
            {
                Console.WriteLine(" ne raven");



            }
            Console.ReadKey();
        }
    }
}
