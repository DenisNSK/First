using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._28b
{
    class Program
    {
        static void Main(string[] args)
        { //5.28b
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = (1);
            for (int i = a; i<= 20; i++)
            {
                n = n * i;


            }
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
