using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._69
{
    class Program
    {
        static void Main(string[] args)
        {
            string mass = "Женя и Зоя нашли в лесу ёжика. Он лежал тихо. Ребята решили, что ёжик заболел. Зоя положила его в корзину. Дети побежали домой. Они кормили ёжика молоком.";
            int count = 0;

            foreach (var a in mass)
            {
                if (a == '.' || a == '?' || a == '!')
                    count++;
            }

            Console.WriteLine("В данном тексте {0} предложений", count);
        }
    }
}
