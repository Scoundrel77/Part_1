using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_1._49
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double b = 4;
            double t = 60;
            double s;

            s = ((a + b) / 2) * (Math.Sin(t) / Math.Cos(t) * (b - a) / 2);
            Console.WriteLine(s);
        }
    }
}
