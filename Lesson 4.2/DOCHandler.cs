using System;

namespace Lesson_4._2
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
            this.fileName = fileName;
        }


        public override void Save()
        {
            Console.WriteLine(fileName + " сохранен в формате DOC");
        }
    }
}
