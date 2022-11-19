using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_1._59
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
