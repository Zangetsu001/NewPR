using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tovar[] goods = {
                new Obuv("Кроссовки", 1200, 3),
                new Odejda("Куртка", 3000, "L", "Черный"),
                new Posuda("Кастрюля", 900, 2.5)
            };

            foreach (var g in goods) g.Print();
        }
    }
}
