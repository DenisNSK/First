using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace система_координат
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1");
                }
                else
                    Console.WriteLine("4");


            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("2");

                }
                else
                {
                    Console.WriteLine("3");

                }
            }

            Console.ReadKey(); 
        }
    } 
}
