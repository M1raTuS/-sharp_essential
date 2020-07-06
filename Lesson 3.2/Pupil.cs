using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil.Study");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil.Read");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil.Write");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil.Relax");
        }
    }
}
