using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._30г
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число");
             int b = Convert.ToInt32(Console.ReadLine());
            int s = (0);
            for(int i=a; i<=b; i++)
            { s = s + i * i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
