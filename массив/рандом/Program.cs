using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рандом
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВКЭМ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i=0; i<n; i++)
            {
                mas[i] = r.Next(-50, 50);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + mas[i];
            }
            double d= 1.0*sum/n;
            Console.WriteLine(" sr " + d);

                Console.ReadKey();

        }
    }
}
