using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._29
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = 0;
            int[] studentsMarks = null;

            Console.Write("Введите количество учеников в классе: ");
            studentsNumber = Int32.Parse(Console.ReadLine());
            while (studentsNumber < 1)
            {
                Console.Write("Ошибка: неверное количество учеников! Повторите ввод: ");
                studentsNumber = Int32.Parse(Console.ReadLine());
            }

            studentsMarks = new int[studentsNumber];

            Console.WriteLine("Введите оценки по химии всех учеников класса:");
            for (int i = 0; i < studentsMarks.Length; i++)
            {
                Console.Write($"{i + 1}-й ученик: ");
                studentsMarks[i] = Int32.Parse(Console.ReadLine());
                while (studentsMarks[i] < 1 || studentsMarks[i] > 5)
                {
                    Console.Write("Ошибка: неверная оценка! Повторите ввод: ");
                    studentsMarks[i] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"Количество учеников с оценкой 2 по химии: {studentsMarks.Where(m => m == 2).Count()}");
            Console.WriteLine($"Количество учеников с оценкой 5 по химии: {studentsMarks.Where(m => m == 5).Count()}");

            Console.ReadKey(true);
        }
    }
}
