using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._19
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = 7, sum = 0;
            Console.WriteLine("Введите число");

            for (int i = 1; i < 16; i++)
            {
                if (i % 2 != 0) sum += c;
            }

            Console.WriteLine($"Сумма = {-sum}");
        }
    }
}
