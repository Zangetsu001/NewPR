using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Obuv:Tovar
    {
        public int Count { get; set; }
        public Obuv(string name, double price, int count)
            : base(name, price) => Count = count;

        public override double CalcSum() => Price * Count;

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество: {Count}");
        }
    }
}
