using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._79
{
    class Program
    {
        static void Main(string[] args)
        {
            string mass = "Женя и Зоя нашли в лесу ёжика. Он лежал тихо. Ребята решили, что ёжик заболел. Зоя положила его в корзину. Дети побежали домой. Они кормили ёжика молоком.";
            int count = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (i != '.')
                {
                    if ((mass[i] >= 1072 && mass[i] <= 1103) ||
                        (mass[i] >= 1040 && mass[i] <= 1071))
                        count++;
                }

                else
                    break;
            }

            if (count != 0)
                Console.WriteLine("Кол-во букв {0}", count);

            else
                Console.WriteLine("Буквы отсутствует");
        }
    }
}
