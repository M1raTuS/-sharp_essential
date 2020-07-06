using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Play();
            (p as Interface.IPlayable).Pause();
            (p as Interface.IPlayable).Stop();

            p.Record();
            (p as Interface.IRecodable).Pause();
            (p as Interface.IRecodable).Stop();
            Console.ReadKey();
        }
    }
}
