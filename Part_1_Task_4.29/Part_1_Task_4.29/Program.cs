using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._29
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 345, b, c, d, e, f;
            b = Math.Pow(a, 2);
            c = (a / 100) % 10;
            d = (a / 10) % 10;
            e = a % 10;
            f = (Math.Pow(c, 3) + Math.Pow(d, 3) + Math.Pow(e, 3));

            if (b > f)
                Console.WriteLine($"Квадрат числа больше: {b} > {f} ");
            else if (b < f)
                Console.WriteLine("Сумма кубов цифр больше");
            else if (b == f)
                Console.WriteLine("Они равны");
        }
    }
}
