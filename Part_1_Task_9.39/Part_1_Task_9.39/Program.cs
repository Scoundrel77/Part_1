using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._39
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "клоуны";
            //a
            char b1 = word[0];
            char b2 = word[1];
            char b3 = word[2];

            char b4 = word[word.Length - 1];
            char b5 = word[word.Length - 2];
            char b6 = word[word.Length - 3];

            Console.WriteLine($"{b6}{b5}{b4}{b1}{b2}{b3}");

            //b
            string word1 = "";
            string word2 = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (i <= 2)
                    word1 += word[i].ToString();

                if (i >= word.Length - 3 && i <= word.Length - 1)
                    word2 += word[i].ToString();
            }

            Console.WriteLine("{0}{1}", word2, word1);
        }
    }
}
