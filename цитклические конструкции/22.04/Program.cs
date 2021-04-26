using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("стоимость одной единицы");
         double k = Convert.ToDouble(Console.ReadLine());
            for (int i = 2; i <= 20; i++)
            { Console.WriteLine(i + "кол-во "+i*k+"рублей"); }
           

            Console.ReadKey();
        }
    }
}
