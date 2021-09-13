using System;

namespace Lesson_4._2
{
    class Choise
    {
        AbstractHandler abs;

        public void ChooseDocument(string filename)
        {
            string str = filename.Substring(filename.Length - 4);

            switch (str.ToLower())
            {
                case ".doc":
                    abs = new DOCHandler(filename);
                    break;
                case ".txt":
                    abs = new TXTHandler(filename);
                    break;
                case ".xml":
                    abs = new XMLHandler(filename);
                    break;
                default:
                    Console.WriteLine("net takogo");
                    break;
            }

        }

        public void Open()
        {
            abs.Open();
        }

        public void Craete()
        {
            abs.Create();
        }

        public void Change()
        {
            abs.Change();
        }

        public void Save()
        {
            abs.Save();
        }

    }
}
