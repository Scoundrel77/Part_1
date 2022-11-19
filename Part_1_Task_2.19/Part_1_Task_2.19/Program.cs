using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_2._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, sum, proiz;
            int n = 4567;
            a = (n / 1000) % 10;
            b = (n / 100) % 10;
            c = (n / 10) % 10;
            d = n % 10;

            sum = a + b + c + d;
            proiz = a * b * c * d;

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {proiz}");
        }
    }
}
