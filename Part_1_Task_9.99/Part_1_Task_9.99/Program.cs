using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._99
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "очепатка";

            char b1 = word[0];
            char b2 = word[1];
            char b3 = word[2];
            char b4 = word[3];
            char b5 = word[4];
            char b6 = word[5];
            char b7 = word[6];
            char b8 = word[7];

            Console.WriteLine($"{b1}{b4}{b3}{b2}{b5}{b6}{b7}{b8}");
        }
    }
}
