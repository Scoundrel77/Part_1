using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._59
{
    class Program
    {
        static void Main(string[] args)
        {
            //a
            int a = 1234;
            bool flag = false;

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            string num = a.ToString();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i].ToString() == "4")
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("4-е есть");

            else
                Console.WriteLine("4-е нет");

            //b
            int num1 = a % 10;
            int num2 = (a / 10) % 10;
            int num3 = (a / 100) % 10;
            int num4 = (a / 1000) % 10;

            if (num1 == 4 || num2 == 4
                || num3 == 4 || num4 == 4)
                Console.WriteLine($"{b} входит 4");

            else
                Console.WriteLine("Не входит!");
        }
    }
}
