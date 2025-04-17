using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = {
                new Plane(10, 20, 500000, 800, 2022, 10000, 200),
                new Car(15, 25, 30000, 150, 2023),
                new Ship(5, 10, 200000, 60, 2021, 500, "Одесса")
            };

            foreach (var v in vehicles) v.Show();
        }
    }
}
