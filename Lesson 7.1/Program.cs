/* Структуры и их разновидности 
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте структуру с именем - Notebook.  
Поля структуры: модель, производитель, цена.  
В структуре должен быть реализован конструктор для инициализации полей и метод для вывода содержимого полей на экран. */

using System;

namespace Lesson_7._1
{
    class Program
    {
        static void Main()

        {
            Notebook not = new Notebook();
            not.Show();
            Notebook not1 = new Notebook("Asus", "Phone", 1000);
            not1.Show();

            Console.ReadKey();

        }



    }
}
