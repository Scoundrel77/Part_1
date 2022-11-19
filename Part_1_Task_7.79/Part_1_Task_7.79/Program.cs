using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._79
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] { 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 };

            Console.Write("Массив: ");

            foreach (int item in a)
            {
                Console.Write(item + " ");
            }

            int i = 1;
            int mn = a.Length;

            while (i < a.Length)
            {
                if (a[i] == a[i - 1])
                {
                    int j = i;
                    int k = 1;

                    while (j < a.Length && a[j] == a[j - 1])
                    {
                        j++;
                        k++;
                    }

                    if (k < mn && k >= 2)
                    {
                        mn = k;
                    }

                    i += k;
                }

                else
                {
                    i++;
                }
            }

            if (mn == a.Length)
            {
                Console.WriteLine("Нет одинаковых рядом!");
            }

            else
            {
                Console.WriteLine("Наименьшая длина отрезка из нулей: " + mn);
            }

            Console.ReadKey();
        }
    }
}
