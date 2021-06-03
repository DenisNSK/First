using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_мая
{
    class Program
    { 
    public static double ploshd(double a, double b, double c)
    {

        double V = a * b * c;



        return V;

    }
    static void Main(string[] args)
    {

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Введи первую сторону прямогульного паралепипеда");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи вторую сторону прямогульного паралепипеда");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введи третью сторону прямогульного паралепипеда");
            double c = Convert.ToDouble(Console.ReadLine());
            double otvet = ploshd(a, b, c);
            Console.WriteLine("Ответ" + otvet);

        }
        Console.ReadKey();

    }
}
}
