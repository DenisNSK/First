using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10];
            mas[0] = 1;
            mas[1] = 2;
            mas[2] = 3;
            mas[3] = 4;
            mas[4] = 5;
            mas[5] = 6;
            mas[6] = 7;
            mas[7] = 8;
            mas[8] = 9;
            mas[9] = 10;


            for (int i = 0; i <= 9; i ++)
            {
                mas[i] = i + 1;
            }
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("№" + i + "" + mas[i]);
            }
            int sum = 0;
            for (int i = 0; i <= 9; i++)
            {
                sum = sum + mas[i];
            }
            Console.WriteLine("summa" + sum);
                Console.ReadKey();
        }
    }
}
