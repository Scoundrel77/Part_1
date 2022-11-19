using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._59
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mass = { "о" };
            int sch = 0;
            Console.Write("Введите предложение: ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (mass.Contains(str[i].ToString().ToLower()))
                    sch += 1;
            }

            Console.Write("Количество букв о = " + sch);
            Console.Read();
        }
    }
}
