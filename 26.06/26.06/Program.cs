using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._06
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int s = (0);
            for (int i = 1; i <= 1000; i++)
            {
                s = s + i;
            }
             double sr = s / 1000.0;
            Console.WriteLine(sr);
            Console.ReadKey();
        }
    }
}
