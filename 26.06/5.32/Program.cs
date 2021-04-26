using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = (0);
            for (int i = 1; i <= n; i++)
            {
                s = s + 1 / i;
            }
            Console.WriteLine("куб");
            Console.ReadKey();
        }
    }
}
