using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new BadPupil();
            Pupil p2 = new GoodPupil();
            Pupil p3 = new ExcelentPupil();
            Pupil p4 = new Pupil();

            ClassRoom room1 = new ClassRoom(p1, p2);

            room1.Study();
            Console.WriteLine(new string('*',20));
            room1.Read();
            Console.WriteLine(new string('*', 20));
            room1.Write();
            Console.WriteLine(new string('*', 20));
            room1.Relax();
            Console.ReadKey();
        }
    }
}
