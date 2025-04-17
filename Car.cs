using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Car:Vehicle
    {
        public Car(double x, double y, double price, double speed, int year)
        : base(x, y, price, speed, year) { }

        public override void Show()
        {
            Console.WriteLine($"Car: Coords({X}, {Y}), Price={Price}, Speed={Speed}, Year={Year}");
        }
    }
}
