using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Ship:Vehicle
    {
        public int Passengers;
        public string Port;

        public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers; Port = port;
        }

        public override void Show()
        {
            Console.WriteLine($"Ship: Coords({X}, {Y}), Price={Price}, Speed={Speed}, Year={Year}, Passengers={Passengers}, Port={Port}");
        }
    }
}
