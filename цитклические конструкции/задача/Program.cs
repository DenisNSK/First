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
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int f = (0);
            for (int i = 1; i <= n; i++)
            {
                f = f + i;


            }
            Console.WriteLine(" сумма равна " +f);

            Console.ReadKey();
        }
    }
}
