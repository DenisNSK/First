﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._48_б
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            double[] mas = new double[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(100, 200) / 10.0;
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    mas[i] = mas[i] - 1;
                }

                else
                {
                    mas[i] = mas[i] + 1;
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();

        }
    }
}
