﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = (0);
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("Введите число");
                int a = Convert.ToInt32(Console.ReadLine());
                s = s + a;
            }
            double sr = (s*1.0) / n;
            Console.WriteLine(sr);
            Console.ReadLine();
        }
    }
}
