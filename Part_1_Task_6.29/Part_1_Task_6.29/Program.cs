using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_6._29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число n=");
            n = Convert.ToInt32(Console.ReadLine());
            Tuple<int, int, int> res = GetMinMaxLen(n);
            Console.WriteLine("Номер: {0}", n);
            Console.WriteLine("От начала мин. позиции: {0}, от начала макс. позиции {1}", res.Item3 - 1 - res.Item1, res.Item3 - 1 - res.Item2);
            Console.WriteLine("От конца мин. позиции: {0}, от конца макс. позиции {1}", res.Item1, res.Item2);
            Console.ReadKey();
        }

        private static Tuple<int, int, int> GetMinMaxLen(int n)
        {
            int min = 10, max = -1;
            int pmin = -1, pmax = -1;
            int d, l = 0;

            while (n != 0)
            {
                d = n % 10;

                if (d < min)
                {
                    min = d;
                    pmin = l;
                }

                if (d > max)
                {
                    max = d;
                    pmax = l;
                }

                n /= 10;
                l++;
            }

            return new Tuple<int, int, int>(pmin, pmax, l);
        }

    }
}
