using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._29
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "клоун";
            char b1 = word[0];
            char b2 = word[1];
            char b3 = word[2];
            char b4 = word[3];
            char b5 = word[4];

            Console.WriteLine($"{b4}{b1}{b2}{b3}{b5}");
            Console.WriteLine($"{b1}{b4}{b2}{b3}{b5}");
            Console.WriteLine($"{b1}{b3}{b2}{b4}{b5}");
        }
    }
}
