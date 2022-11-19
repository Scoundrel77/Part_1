using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_9._179
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = new[] { "потоп", "буря", "молоко", "сено", "рыба", "работа" };
            IEnumerable<string> symWords = words.Where(x => x.Equals(new string(x.Reverse().ToArray())));
            IEnumerable<string> unicWords = words.Where(x => x.Length == x.Distinct().Count());
            Console.WriteLine("Симметричные слова: " + string.Join(", ", symWords));
            Console.WriteLine("Слова с неповторяющимися буквами: " + string.Join(", ", unicWords));
            Console.ReadKey();
        }
    }
}
