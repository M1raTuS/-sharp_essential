using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Choise redactor = new Choise();
            redactor.ChooseDocument("file.doc");

            redactor.Open();
            redactor.Change();
            redactor.Save();

            // Delay.
            Console.ReadKey();

        }
    }
}
