using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_6._99
{
    class Program
    {
        static void Main(string[] args)
        {
            double s;
            double allWay = 0;
            s = 10;
            bool isBigerThen20 = false;
            bool isSummBigerThen100 = false;

            for (int a = 1; a <= 1000; a++)
            {
                allWay += s;
                s += s * 0.1;

                if (s >= 20)
                {
                    Console.WriteLine($"Больше 20 км в {a} дне");
                    isBigerThen20 = true;
                }

                if (allWay >= 100)
                {
                    Console.WriteLine($"Полный путь больше 100 км в {a} дне");
                    isSummBigerThen100 = true;
                }

                if (isBigerThen20 && isSummBigerThen100)
                    break;
            }
        }
    }
}
