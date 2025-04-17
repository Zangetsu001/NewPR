using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class DOCHandle:AbstractHandler
    {
        public override void Open() => Console.WriteLine("Открыт DOC-файл");
        public override void Create() => Console.WriteLine("Создан DOC-файл");
        public override void Change() => Console.WriteLine("Изменён DOC-файл");
        public override void Save() => Console.WriteLine("Сохранён DOC-файл");
    }
}
