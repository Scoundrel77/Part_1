using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._99
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 0 };
            Console.WriteLine(Array.IndexOf(a, a.Max()));
        }
    }
}
