using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r % 5 == 0 )
            {
                Console.WriteLine("делится");
            }
            else
            {
                Console.WriteLine("не делится");
            }
            Console.ReadKey();
        }
    }
}
