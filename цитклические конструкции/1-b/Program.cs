using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int b = Convert.ToInt32(Console.ReadLine());
            int f = (1);
            for (int i = 1; i < b; i++)
            {
                f = b*i;


            }
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
