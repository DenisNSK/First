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
            double d=(r1+2*a);
            double s = Math.PI / 4 * (Math.Pow(d, 2) - Math.Pow(a, 2));
            double V = (s * l);
            double m = (p * v);
            Console.WriteLine(V);
            Console.WriteLine(m);
            Console.ReadLine();

        }
    }
}
