using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._79
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 1.5, 3.4, -2.6 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    Console.WriteLine($"{numbers[i]} ^ 2 = {Math.Pow(numbers[i], 2)}");
            }
        }
    }
}
