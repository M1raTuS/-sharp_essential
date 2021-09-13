using System;

namespace Lesson_4._2
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(fileName + " открыт");
        }
        public void Create()
        {
            Console.WriteLine(fileName + " создан");
        }
        public void Change()
        {
            Console.WriteLine(fileName + " отредактирован");
        }
        public abstract void Save();


    }
}
