using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6._3
{
    class Program
    {
        

        public class Book //Класс Book
        {
            public class Note //Nested класс
            {
                string text = "";
                public string Text //Свойство для работы з полем text
                {
                    get //Аксессор
                    {
                        return text;
                    }
                    set //Мутатор
                    {
                        if (text != "")
                            text += "\n";
                        text += value;
                    }

                }
            }
            public void FindNext(string str) //Метод поиска
            {
                Console.WriteLine("Поиск строки : " + str); //Отобразит строку с указанным ключом для поиска
            }
        }



        private static void Main()
        {
            Book.Note note = new Book.Note();

            note.Text = "Hello";
            note.Text = "World";

            Console.WriteLine(note.Text);

            Console.ReadKey();
        }

    }

}
