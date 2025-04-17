using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    abstract class Vehicle
    {
        public double X, Y;
        public double Price, Speed;
        public int Year;

        public Vehicle(double x, double y, double price, double speed, int year)
        {
            X = x; Y = y; Price = price; Speed = speed; Year = year;
        }

        public abstract void Show();
    }
}
