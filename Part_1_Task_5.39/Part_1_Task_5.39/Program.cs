using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_5._39
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.Write("Введите число: ");
                    sum += int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный ввод");
                }
            }
            Console.WriteLine("Сумма чисел: " + sum);
            Console.ReadLine();
        }
    }
}
