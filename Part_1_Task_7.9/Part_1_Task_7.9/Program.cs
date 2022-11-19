using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    if ((i * i + j * j) % 13 == 0) Console.WriteLine($"{i * 10 + j} - a");
                    if (i + j + (i + j) * (i + j) == i * 10 + j) Console.WriteLine($"{i * 10 + j} - b");
                }
            Console.ReadKey(true);
        }
    }
}
