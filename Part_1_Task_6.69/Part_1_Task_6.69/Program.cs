using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_6._69
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            bool flag = true;
            int[] array = new int[10];
            int i = 0;

            do
            {
                array[i] = int.Parse(r.Next(10, 100) + "10000");

                Console.Write(array[i] + " ");

                if (i > 0 && array[i] < array[i - 1])
                {
                    flag = false;
                    break;
                }
            }

            while (i++ < 9);

            Console.WriteLine(flag ? "\nУпорядочена" : $"\nНе упорядочена, порядковый номер числа: {i}");
        }
    }
}
