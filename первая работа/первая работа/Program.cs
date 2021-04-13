using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace первая_работа
{
    class Program
    {
        static void Main(string[] args)
        { 
            //1.14в 

    Console.WriteLine("Введите число");
            double a =Convert.ToDouble(Console.ReadLine());
            double a2 = Math.Pow(a, 2);
            Console.WriteLine("+ a2");
            Console.ReadKey();






            Console.WriteLine("Напишите свое число");
            Console.WriteLine("введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число x");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Math.Sqrt(Math.Pow(x, 2)) + (Math.Pow(x2, 2));
            Console.WriteLine("ваш ответ:" + x3);
            Console.ReadKey();

            //1.17в
            Console.WriteLine("Напишите свое число b1");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите число b2");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("напишите число b3");
            double b3 = Convert.ToDouble(Console.ReadLine());
            double b4 = (b1 * b2 + b1 * b3 + b2 * b3);
            Console.WriteLine("ваш ответ:" + b4);
            Console.ReadKey();

            //1.17г
            Console.WriteLine("Напишите свое число m");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Напишите число v");
            double v = Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine("напишите число b3");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("g");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("h");
            double h = Convert.ToDouble(Console.ReadLine());
            double h1 = (m * Math.Pow(v, 2) / 2 + m * g * h);
            Console.WriteLine("ваш ответ:" + h1);
            Console.ReadKey();

            //1.17d
            Console.WriteLine("hello people");
            Console.WriteLine("Введите число R");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число R2");
            double r2 = Convert.ToDouble(Console.ReadLine());
            double r3 = 1 / r + 1 / r2;
            Console.WriteLine("Ваш ответ:" + r3);
            Console.ReadKey();

            //1.17е
            Console.WriteLine("Я закипел");
            Console.WriteLine("Введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число g");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            double j = m * g * Math.Cos(a);
            Console.WriteLine("Ваш ответ:" + j);
            Console.ReadKey();


        } } } 
