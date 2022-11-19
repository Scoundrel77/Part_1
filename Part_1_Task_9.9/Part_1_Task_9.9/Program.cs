using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._9
{
    class Program
    {
        static void Main(string[] args)
        {
            string surname_1 = Console.ReadLine();
            string surname_2 = Console.ReadLine();

            if (surname_1.Length > surname_2.Length)
                Console.WriteLine($"Фамилия {surname_1} длинее");

            else if (surname_1.Length < surname_2.Length)
                Console.WriteLine($"Фамилия {surname_2} длинее");

            else
                Console.WriteLine($"Фамилии одинаковые");
        }
    }
}
