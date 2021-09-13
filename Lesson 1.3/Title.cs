using System;

namespace Lesson_1._3
{
    class Title
    {
        readonly string title;

        public Title(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);
        }


    }
}
