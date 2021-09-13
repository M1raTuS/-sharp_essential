using System;

namespace Lesson_3._1
{
    class Printer
    {

        protected ConsoleColor col;

        public Printer(ConsoleColor col)
        {
            this.col = col;
        }


        Random rnd = new Random();
        public virtual void Print(string value)
        {
            Console.ForegroundColor = col;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
