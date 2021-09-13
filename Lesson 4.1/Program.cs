/* Абстрактные классы и интерфейсы
 
Задание Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Изменить Lesson 1.2  и создать общий абстрактный класс для всех частей документа. */

using System;

namespace Lesson_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание екземпляра класса
            Document document = new Document("Контракт");

            document.Body = "Тело контракта...";
            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
