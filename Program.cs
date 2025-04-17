using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = {
            new Russian("Иван"),
            new Ukrainian("Олег"),
            new American("John")
        };

            foreach (var p in people) p.SayHello();
        }
    }
}
