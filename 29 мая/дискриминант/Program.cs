using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дискриминант
{
    class Program
    {
        public static double disk(double a, double b, double c)
        {

            double x= Math.Pow(b,2)-(4*a*c);
            return x;

        }
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("число");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("число");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("число");
                double c = Convert.ToDouble(Console.ReadLine());
                double p = disk(a, b, c);
                Console.WriteLine("p="+p);

            }
            Console.ReadKey();
        }
    }
}
