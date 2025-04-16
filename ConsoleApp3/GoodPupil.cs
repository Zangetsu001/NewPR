using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class GoodPupil:Pupil
    {
        public GoodPupil(string lastName):base(lastName) { }
        public override void Study() => Console.WriteLine($"{LastName} учится хорошо!");
        public override void Read() => Console.WriteLine($"{LastName} читает достаточно быстро!");
        public override void Write() => Console.WriteLine($"{LastName} пишет с небольшими ошибками!");
        public override void Relax() => Console.WriteLine($"{LastName} отдыхает, смотря телевизор!");


    }
}
