using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler = new XMLHandler();
            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
        }
    }
}
