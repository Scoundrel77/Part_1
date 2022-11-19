using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_5._19
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 0.1; i < 1.1; i += 0.1)
            {
                Console.WriteLine($"{Math.Sin(i)}");
            }
        }
    }
}
