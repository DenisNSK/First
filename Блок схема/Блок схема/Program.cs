using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Блок_схема
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Введите первое число");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a<(b+c)& b<(c+a)& c<(a+b))

                

            {
                Console.WriteLine("Существует треугольник");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
            Console.ReadKey();
        }
    }
}
