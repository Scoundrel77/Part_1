using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_6._109
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n = 12, n1, a, s, k, znak;
            n1 = n;
            k = 0;

            while (n1 != 0)
            {
                k = k + 1;
                n1 = n1 / 10;
            }

            znak = 1;
            s = 0;

            while (n != 0)
            {
                a = n % 10;
                s = s + a * znak;
                znak = znak * -1;
                n = n / 10;
            }

            Console.WriteLine($"Знакочередующаяся сумма цифр числа = {s}");
        }
    }
}
