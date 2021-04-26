using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._28_w
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число");
            int b = Convert.ToInt32(Console.ReadLine());
            int f = (1);
            for (int i = a; i <= b; i++)
            {
               f= f*i;


            }
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
