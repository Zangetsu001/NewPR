using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Ukrainian:Person
    {
        public Ukrainian(string name) : base(name) { }
        public override void SayHello() => Console.WriteLine($"{Name}: Вiтаю!");
    }
}
