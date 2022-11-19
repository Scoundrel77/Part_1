using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._139
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            int len = 0;
            foreach (var c in text.ToCharArray())
            {
                if (char.IsDigit(c))
                {
                    Console.Write(c);
                    len = len + 1;
                }
                else if (len > 0)
                {
                    Console.WriteLine();
                    len = 0;
                }
            }

            Console.ReadLine();
        }
    }
}
