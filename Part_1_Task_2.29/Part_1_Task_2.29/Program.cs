using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_2._29
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 523;
            int firstNum = (a / 100) % 10;
            int secondNum = (a / 10) % 10;
            int lastNum = a % 10;

            Console.WriteLine(a);
            Console.WriteLine($"{secondNum}{firstNum}{lastNum}");
        }
    }
}
