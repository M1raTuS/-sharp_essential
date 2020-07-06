using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker or = new DocumentWorker();
            or.OpenDocument();
            or.EditDocument();
            or.SaveDocument();

            Console.WriteLine("");

            ProDocumentWorker pro = new ProDocumentWorker();
            pro.OpenDocument();
            pro.EditDocument();
            pro.SaveDocument();

            Console.WriteLine("");

            ExpertDocumentWorker ex = new ExpertDocumentWorker();
            ex.OpenDocument();
            ex.EditDocument();
            ex.SaveDocument();

          

            Console.ReadKey();
        }
    }
}
