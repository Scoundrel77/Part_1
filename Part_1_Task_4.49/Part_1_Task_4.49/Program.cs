using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._49
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            d = Math.Pow(b, 2) - (4 * a * c);
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            if (x1 != x2)
                Console.WriteLine($"{x1} {x2}");

            else
                Console.WriteLine($"{x1}");
        }
    }
}
