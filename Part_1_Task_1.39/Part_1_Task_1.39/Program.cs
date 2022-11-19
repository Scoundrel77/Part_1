using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_1._39
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double y = 5;
            double q;
            double z;

            z = (x + (2 + y) / (Math.Pow(x, 2))) / (y + 1 / (Math.Sqrt(Math.Pow(x, 2) + 10)));
            q = 2.8 * Math.Sin(x) + Math.Abs(y);
            Console.WriteLine(z);
            Console.WriteLine(q);
        }
    }
}
