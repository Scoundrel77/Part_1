using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_8._29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 150, k = 2, count = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }

                if (count == k)
                {
                    Console.WriteLine($"{i}");
                    count = 0;
                }

                else
                    count = 0;
            }

            Console.ReadKey();
        }
    }
}
