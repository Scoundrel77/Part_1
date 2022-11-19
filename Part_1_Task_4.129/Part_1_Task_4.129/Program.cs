using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_4._129
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц (номер)");
            int month = Int32.Parse(Console.ReadLine());
            if (year < 0 || year > DateTime.Now.Year || month < 1 || month > 12)
            {
                Console.WriteLine("Неверный формат даты");
                Console.ReadKey();
                return;
            }

            DateTime birth = new DateTime(year, month, 1);
            int age = DateTime.Now.Year - birth.Year - (DateTime.Now.Month >= month ? 0 : 1);
            Console.WriteLine($"возраст - {age} лет");
            Console.ReadKey();
        }
    }
}
