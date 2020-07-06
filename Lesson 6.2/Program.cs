using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._2
{
    
    

    internal static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book b = new Book();
            b.FindNext(str);
        }
    }

    internal class Book //Класс Book
    {
        public void FindNext(string str) //Метод поиска
        {
            Console.WriteLine("Поиск строки : " + str); //Отобразит строку с указанным ключом для поиска
        }
    }
   

    class Program
    {
        private static void Main()
        {
            FindAndReplaceManager.FindNext("Hi");

            Console.ReadKey();
        }
    }
}
