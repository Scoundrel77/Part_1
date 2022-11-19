using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._89
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3, x = 5;

            if (k < x)
                Console.WriteLine($"{k * x}");

            else if (k >= x)
                Console.WriteLine($"{k + x}");
        }
    }
}
