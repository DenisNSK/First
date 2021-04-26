using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            double s = (0);
            for (int i = 1; i <= 11; i=i+2)
            {
                s= s + Math.Pow(x,2) / i;
;            }
          Console.WriteLine("s");
            Console.ReadKey();
        }
    }
}
