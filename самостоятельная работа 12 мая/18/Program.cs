using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("длин l");
            int l= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("плотность p");
            int p= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("толщина стенок a");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("внутренний радиус r1");
            int r1 = Convert.ToInt32(Console.ReadLine());
            int r2 = (a + r1);
            double v=l*Math.PI*(Math.Pow(r2, 2) - Math.Pow(r1, 2));
            double m = (p * v);
            Console.WriteLine(v);
            Console.WriteLine(m);
            Console.ReadLine();

        }
    }
}
