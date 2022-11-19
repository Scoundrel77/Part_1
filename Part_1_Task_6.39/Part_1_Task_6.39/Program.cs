using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_6._39
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 436123;

            //а
            do
            {
                number = number / 10;

                if (number < 100)
                {
                    do
                    {
                        number = number - 10;

                        if (number < 10)
                        {
                            Console.WriteLine("Вторая (с начала) цифра : {0}", number);
                        }
                    }
                    while (number > 10);
                }
            }

            while (number > 100);

            //б
            number = 436123;

            do
            {
                number = number / 10;

                if (number < 100)
                {

                    Console.WriteLine("Вторая (с начала) цифра : {0}",
                        number.ToString().ToCharArray()[1]);
                }
            }

            while (number > 100);

            Console.ReadKey();
        }
    }
}
