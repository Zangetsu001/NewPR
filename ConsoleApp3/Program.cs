using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom room = new ClassRoom(
           new ExcelentPupil("Иванов"),
           new GoodPupil("Петров"),
           new BadPupil("Сидоров")
       );
            room.ShowInfo();
        }
    }
}
