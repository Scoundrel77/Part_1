using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_8._49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            var m = int.Parse(Console.ReadLine());

            for (var i = 1; i < n; i++)
            {
                int sum = 0, temp = i;
                do
                {
                    sum += temp % 10;
                    temp /= 10;
                }
                while (temp > 0);

                if (m == sum * sum)
                    Console.WriteLine(i);
            }
        }
    }
}
