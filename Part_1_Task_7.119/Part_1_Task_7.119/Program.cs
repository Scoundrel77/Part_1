using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._119
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 0 };
            int maxNumber = a[0];
            int minNumber = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (maxNumber < a[i])
                    maxNumber = a[i];

                if (minNumber > a[i])
                    minNumber = a[i];
            }

            if ((maxNumber - minNumber) <= 25)
                Console.WriteLine("Верно");

            else
                Console.WriteLine("Не верно");
        }
    }
}
