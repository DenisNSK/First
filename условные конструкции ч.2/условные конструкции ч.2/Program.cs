using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace условные_конструкции_ч._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r % 2== 0) 
            { 
                Console.WriteLine("Четное");
            }
            else
            {
                Console.WriteLine("не Четное");
            }
            Console.ReadKey());




                    }
    }
}
