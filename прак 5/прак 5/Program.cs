using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace прак_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("натурал");
            int x = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (x!= 0)
            {
                int a = x % 10;
                if (a % 2 == 0)
                {
                    n++;
                }
                x = x / 10;
            } 
            Console.WriteLine(n);
            Console.ReadKey();

            
        }
    }
 }

