using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil.Study");
        }

        public override void Read()
        {
            Console.WriteLine("GoodPupil.Read");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil.Write");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil.Relax");
        }
    }
}
