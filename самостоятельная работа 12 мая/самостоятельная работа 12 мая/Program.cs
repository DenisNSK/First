using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace самостоятельная_работа_12_мая
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("катет a ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("катет b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("толщина h");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("масса m");
            int m = Convert.ToInt32(Console.ReadLine());
            double s = ((a * b)*1/2);
            double v = (s * h);
            double p = (m / v);
            Console.WriteLine(p);
            Console.ReadKey();

        }
    }
}
