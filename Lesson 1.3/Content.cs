using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
