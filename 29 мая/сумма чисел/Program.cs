using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace сумма_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            while (a!= 0)
            {
              int  b = a % 10;
              int c = a / 10;
                k = b + c;
                    }
            Console.ReadKey();
        }
    }
}
