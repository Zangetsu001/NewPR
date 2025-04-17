using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class TXTHandler:AbstractHandler
    {
        public override void Open() => Console.WriteLine("Открыт TXT-файл");
        public override void Create() => Console.WriteLine("Создан TXT-файл");
        public override void Change() => Console.WriteLine("Изменён TXT-файл");
        public override void Save() => Console.WriteLine("Сохранён TXT-файл");
    }
}
