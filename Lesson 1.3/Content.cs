using System;

namespace Lesson_1._3
{
    class Content
    {
        readonly string content;

        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(content);
        }


    }
}
