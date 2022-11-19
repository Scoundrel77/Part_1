using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._49
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "клоуны";
            string str = "";

            for (int i = 0; i < word.Length; i++)
            {
                str += "*";
            }

            Console.WriteLine($"{str}{word}{str}");
        }
    }
}
