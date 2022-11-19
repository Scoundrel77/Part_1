using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._99
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 34, b = 45, c = 23;

            if (a >= b && b >= c)
                Console.WriteLine($"{a + b}");

            else if (a >= b && b <= c)
                Console.WriteLine($"{a + c}");

            else if (b >= a && a >= c)
                Console.WriteLine($"{b + a}");

            else if (b >= a && a <= c)
                Console.WriteLine($"{c + b}");

            else if (c >= a && b <= a)
                Console.WriteLine($"{c + a}");

            else if (c >= a && b >= a)
                Console.WriteLine($"{c + b}");
        }
    }
}
