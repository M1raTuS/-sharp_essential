/* Статические и вложенные классы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать статический класс FindAndReplaceManager с методом void FindNext(string str) для поиска по книге. 
При вызове этого метода, производится последовательный поиск строки в книге. */

using System;

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
