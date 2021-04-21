using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace оператор_кейс
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовое значение");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a) {
                case 2:
                    {
                        Console.WriteLine("неуд");
                        break;
                    }

                 
                case 3:{ 
                    Console.WriteLine("удов");
                    break;
                   } 
                case 4:{ 
                    Console.WriteLine("хорош");
                    break;
                  }
                case 5:{
                   Console.WriteLine("отл");
                        break;
                 }
                default:
                    Console.WriteLine("Ошибка ввода данных");
                break;
}
            Console.ReadKey();




}
    }
}
