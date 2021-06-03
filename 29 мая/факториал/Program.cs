using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace факториал
{
    class Program
    { 
    public static double fak(double x)
    {
        double n = 1;
        for (int i = 1; i <= x; i++)
        {
            n = n * i;
        }


        return n;
    }
    static void Main(string[] args)
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine("по факту");
            double x = Convert.ToDouble(Console.ReadLine());
            double otvet = fak(x);
            Console.WriteLine("Ответ" + otvet);
        }
        Console.ReadKey();
    }
    }
}
