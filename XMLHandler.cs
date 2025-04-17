using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class XMLHandler:AbstractHandler
    {
        public override void Open() => Console.WriteLine("Открыт XML-файл");
        public override void Create() => Console.WriteLine("Создан XML-файл");
        public override void Change() => Console.WriteLine("Изменён XML-файл");
        public override void Save() => Console.WriteLine("Сохранён XML-файл");
    }
}
