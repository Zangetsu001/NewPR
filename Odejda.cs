using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Odejda:Tovar
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Odejda(string name, double price, string size, string color)
            : base(name, price)
        {
            Size = size; Color = color;
        }

        public override double CalcSum() => Price;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Размер: {Size}, Цвет: {Color}");
        }
    }
}
