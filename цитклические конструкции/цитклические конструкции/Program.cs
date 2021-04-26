using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace цитклические_конструкции
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int k = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<10;i++)
            { Console.Write(k + " "); }
            Console.WriteLine();
            for (int i = 5; i <= 20; i++)
            { Console.Write(i+ " "); }

                Console.ReadKey();
        }
    }
}
