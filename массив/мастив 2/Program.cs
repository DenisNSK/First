using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace мастив_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 15;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i <15; i++)
            {
                mas[i] = r.Next(15, 35);
            }
            for (int i = 0; i < 15; i++)
            {
                Console.Write(mas[i] + " ");
            }
           double sum = 0;
            for (int i = 0; i < 15; i++)
            {
                sum = sum + Math.Pow(mas[i],2);
            }
            Console.WriteLine(" um " );

            Console.ReadKey();
        }
    }
}
