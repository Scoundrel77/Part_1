using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_5._29
{
    class Program
    {
        static double Vvod_Chisla(string info)
        {
            double chislo;
            string vvod;

            Console.Write("Введите " + info + ": ");
            vvod = Console.ReadLine();

            while (!Double.TryParse(vvod, out chislo))
            {
                Console.WriteLine("Недопустимые символы в строке ввода. Ожидается число:");
                vvod = Console.ReadLine();
            }

            return chislo;
        }

        static int Vvod_Chisla_Int(string info)
        {
            int chislo;
            string vvod;

            Console.Write("Введите " + info + ": ");
            vvod = Console.ReadLine();

            while (!Int32.TryParse(vvod, out chislo))
            {
                Console.WriteLine("Недопустимые символы в строке ввода.Ожидается целое число:");
                vvod = Console.ReadLine();
            }

            return chislo;
        }

        static void Main(string[] args)
        {
            int a, rez, b, n;
            double x, y, z;

            //а)
            Console.WriteLine("Задача C2.3");
            Console.WriteLine("а)");

            rez = 0;

            for (a = 1; a <= 1000; a++)
                rez += a;

            Console.WriteLine("среднее арифметическое всех целых чисел от 1 до 1000 равно {0}", rez / 1000.0);
            Console.ReadKey();

            // б)

            Console.WriteLine("б)");
            b = Vvod_Chisla_Int("целое число (b > 100)");

            rez = 0;

            for (a = 100; a <= b; a++)
                rez += a;

            Console.WriteLine("среднее арифметическое всех целых чисел от 100 до {1} равна {0}", rez / (b - 100.0 + 1), b);
            Console.ReadKey();

            // в)
            Console.WriteLine("в)");
            b = Vvod_Chisla_Int("целое число (a < 200)");

            rez = 0;

            for (a = 200; a >= b; a--)
                rez += a;

            Console.WriteLine("среднее арифметическое всех целых чисел от 200 до {1} равна {0}", rez / (200.0 - b + 1), b);
            Console.ReadKey();

            // г)
            Console.WriteLine("г)");
            a = Vvod_Chisla_Int("целое число a");
            b = Vvod_Chisla_Int("целое число (b > a)");

            rez = 0;

            for (int i = a; i <= b; i++)
                rez += i;

            Console.WriteLine("среднее арифметическое всех целых чисел от {2} до {1} равна {0}", rez / (b - a + 1.0), b, a);
            Console.ReadKey();
        }

    }
}
