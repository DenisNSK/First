using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31
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
            if ((a == b) & (b == c) & (c == a))
            {
                Console.WriteLine("raven");
            }
            else
            {
                Console.WriteLine(" ne raven");
                if ((a == b) | (b == c) | (c == a))
                { Console.WriteLine("da"); }
                { Console.WriteLine("net"); }


            }
            Console.ReadKey();
        }
    }
}
