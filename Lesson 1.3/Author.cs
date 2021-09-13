using System;

namespace Lesson_1._3
{
    class Author
    {
        readonly string author;

        public Author(string author)
        {
            this.author = author;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
        }


    }
}
