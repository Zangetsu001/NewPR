using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(params Pupil[] inputPupils)
        {
            Random rnd = new Random();

            for (int i = 0; i < pupils.Length; i++)
            {
                if (i < inputPupils.Length)
                {
                    pupils[i] = inputPupils[i];
                }
                else
                {
                    int randomType = rnd.Next(3); 
                    string randomName = "Валера";

                    switch (randomType)
                    {
                        case 0: pupils[i] = new ExcelentPupil(randomName); break;
                        case 1: pupils[i] = new GoodPupil(randomName); break;
                        case 2: pupils[i] = new BadPupil(randomName); break;
                    }
                }
            }
        }

        public void ShowInfo()
        {
            foreach (var p in pupils)
            {
                Console.WriteLine($"\nУченик {p.LastName}:");
                p.Study();
                p.Read();
                p.Write();
                p.Relax();
            }
        }
    }
}
