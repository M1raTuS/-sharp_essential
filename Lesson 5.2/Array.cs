using System;
using System.Linq;

namespace Lesson_5._2
{
    class Array
    {

        long sum = 0;
        private int[] massive;

        public Array(int b)
        {
            massive = new int[b];
            Random rand = new Random();
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = rand.Next(1, 50);
            }
        }

        public void Max()
        {
            Console.WriteLine(massive.Max());
        }
        public void Min()
        {
            Console.WriteLine(massive.Min());
        }
        public void Sum()
        {
            foreach (int t in massive)
            {
                sum += t;
            }
            Console.WriteLine(sum);
        }
        public void Middle()
        {
            if (sum == 0)
            {
                Sum();
            }
            Console.WriteLine(sum / (massive.Length));
        }
        public void ne4()
        {
            foreach (int u in massive)
            {
                if (u % 2 != 0)
                {
                    Console.WriteLine(u);
                }
            }
        }

    }
}
