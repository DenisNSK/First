using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._52
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 20);
                Console.WriteLine(mas[i]);
            }
            for (int i = 0; i <= n; i++)
            {
                if (i % 10 == 4)
                {
                    mas[i] = mas[i] / 2;
                }
                {
                    Console.WriteLine(mas[i]);
                }
                Console.ReadKey();
            }
        }
    }
}
