using System;

namespace Lesson_3._2
{
    class ClassRoom
    {
        Random rand = new Random();
        Pupil[] pupil = new Pupil[4];

        public ClassRoom(Pupil p0, Pupil p1)
        {
            pupil[0] = p0;
            pupil[1] = p1;
            pupil[2] = GeneratePupil();
            pupil[3] = GeneratePupil();

        }

        public ClassRoom(Pupil p0, Pupil p1, Pupil p2)
        {
            pupil[0] = p0;
            pupil[1] = p1;
            pupil[2] = p2;
            pupil[3] = GeneratePupil();

        }

        public ClassRoom(Pupil p0, Pupil p1, Pupil p2, Pupil p3)
        {
            pupil[0] = p0;
            pupil[1] = p1;
            pupil[2] = p2;
            pupil[3] = p3;

        }

        public Pupil GeneratePupil()
        {
            int r = rand.Next(1, 4);

            switch (r)
            {
                case 1:
                    return new ExcelentPupil();
                case 2:
                    return new GoodPupil();
                case 3:
                    return new BadPupil();
            }
            return new BadPupil();
        }
        public void Study()
        {
            foreach (Pupil p in pupil)
            {
                p.Study();
            }
        }
        public void Write()
        {
            foreach (Pupil p in pupil)
            {
                p.Write();
            }
        }
        public void Read()
        {
            foreach (Pupil p in pupil)
            {
                p.Read();
            }
        }
        public void Relax()
        {
            foreach (Pupil p in pupil)
            {
                p.Relax();
            }
        }
    }
}
