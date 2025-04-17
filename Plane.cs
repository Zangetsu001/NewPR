using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Plane:Vehicle
    {
        public double Height;
        public int Passengers;

        public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)
        {
            Height = height; Passengers = passengers;
        }

        public override void Show()
        {
            Console.WriteLine($"Plane: Coords({X}, {Y}), Price={Price}, Speed={Speed}, Year={Year}, Height={Height}, Passengers={Passengers}");
        }
    }
}
