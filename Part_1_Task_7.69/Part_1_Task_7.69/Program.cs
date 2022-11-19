using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Task_7._69
{
    class Program
    {
        class P
        {
            public double m { get; set; }
            public double v { get; set; }
            public double p { get; set; }

            public P(double m, double v)
            {
                this.m = m;
                this.v = v;
                p = m / v;
            }
        }

        static void Main(string[] args)
        {
            List<P> obj = new List<P>();
            Random rand = new Random();

            for (int i = 0; i < 30; i++)
                obj.Add(new P(rand.Next(1, 1000), rand.NextDouble()));

            Console.WriteLine("Объекты:");

            foreach (var item in obj)
                Console.WriteLine(" Масса: {0}, объем: {1}, плотность: {2}", item.m, Math.Round(item.v, 2), Math.Round(item.p, 2));
            
            Console.WriteLine("Минимальная плотность: {0}", Math.Round(obj.Min(o => o.p), 2));
            Console.ReadKey();
        }
    }
}
