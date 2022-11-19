using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_6._79
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = 5, z = 3, m = 7;

            while (2 > 1)
            {
                if (g == m)
                {
                    Console.WriteLine($"M: {m} является членом геометрической прогрессии");
                    break;
                }

                g = g * z;

                if (g > m)
                {
                    Console.WriteLine($"M: {m} не является членом геометрической прогрессии");
                    break;
                }
            }
        }
    }
}
