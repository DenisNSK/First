using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2i
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = (1 / (1 + (1 / (2 + (1 / (2 + 3 / 5))))));
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
