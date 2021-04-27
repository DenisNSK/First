using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._71
{
    class Program
    {
        static void Main(string[] args)
        {
           double s = 1000.0;
            for (int i = 1; i <= 10; i++)
            {
              double  s1 = s + s / 100.0 * 2;
                double ds = s1 - s;
                Console.WriteLine(ds);
                s = s1;
              }

            Console.ReadKey();
        }
    }
}
