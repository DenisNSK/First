using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("пон");
                        break;
                    }


                case 2:
                    {
                        Console.WriteLine("вт");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("ср");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("чт");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("пт");
                        break;
                    }
                case 6:
                    { Console.WriteLine("сб");
                        break;
                    }
                case 7:
                    { Console.WriteLine("вс");
                        break; }
                default:
                    Console.WriteLine("Ошибка ввода данных");
                    break;
            }
            Console.ReadKey();

        }
    }
}
