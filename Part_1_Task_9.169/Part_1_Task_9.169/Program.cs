using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._169
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s1;
            int k = 0;
            Console.WriteLine("Введите текст");
            s = Console.ReadLine();
            s = s + " ";
            s1 = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')

                    s1 = s1 + s[i];
                else
                {
                    if (s1[0] == s1[s1.Length - 1])
                    {
                        Console.WriteLine(s1, "{0}");
                        k++;
                    }

                    s1 = "";
                }
            }

            if (k == 0)
                Console.WriteLine("Нет слов, начинающих и заканчивающих на одну букву");
            Console.ReadKey();
        }
    }
}
