using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._49
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 0, 1, 2, 3, 4, 5, 6, 0, 7, 8, 9 };

            Console.WriteLine(Array.LastIndexOf(a, a.Min()));
        }
    }
}
