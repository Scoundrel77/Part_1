using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double kmch = 1;
            double mc = 1;
            double c;

            c = mc * 3600 / 1000;

            if (kmch > c)
                Console.WriteLine($"{kmch} > {c}");

            else if (kmch < c)
                Console.WriteLine($"{kmch} < {c}");

            else
                Console.WriteLine($"{kmch} = {c}");
        }
    }
}
