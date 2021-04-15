using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace самостоятельная_работа
{
    class Program
    {
        static void Main(string[] args)
        {//4.6
            Console.WriteLine("Введите первое число");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double v = Convert.ToDouble(Console.ReadLine());
            

            if ((n<v) | (v>n))



            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();

            //4.9
            Console.WriteLine("Введите скорость км/ч");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость м/с");
            double m = Convert.ToDouble(Console.ReadLine());
            double k1 = k * 1000 / 3600; 

            if ((k1>m))



            {
                Console.WriteLine(k+"км/ч");
            }
            else
            {
                Console.WriteLine(m+"м/с");
            }
            Console.ReadKey();

            //4.1
            Console.WriteLine("Введите число");
            double x = Convert.ToDouble(Console.ReadLine());
            Math.Pow(Math.Sin(x), 2);
            
            if ((x > 0))
            {
               double y = Math.Pow(Math.Sin(x), 2);
                Console.Write(y);

            }
            else
            {
                double y =1-2*Math.Sin(Math.Pow(x,2));
                Console.WriteLine(y);
            }
            Console.ReadKey();

            //4.10

            Console.WriteLine("Введите сторона квадрата");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите окружность");
            double r = Convert.ToDouble(Console.ReadLine());
            double s1 = (a * a);
            double s2 = (2 * 3.14 *Math.Pow(r, 2));
            if (s1>s2)



            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();

        }
    }
}
