using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            int a = r % 10;
            ;
            if (r % 10==7)
            {
                 Console.WriteLine("da na 7");
            }
            else
            {
                Console.WriteLine("da ne 7");
                
            
               
            }
            Console.ReadKey();
        }
    }
}
