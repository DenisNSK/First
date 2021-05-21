using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int i = 100;
            while (n <= 10)
            {
                if (i % 10 == 7 & i % 9 == 0)
                {
                    n++;
                    Console.WriteLine(i);
                }
                
                i++;
            }
            Console.ReadKey();
                

            }
        }
    }

