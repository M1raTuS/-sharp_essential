﻿/* Наследование и полиморфизм
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создайте класс DocumentWorker. 
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().   
В тело каждого из методов добавьте вывод на экран соответствующих строк: "Документ открыт", 
"Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".   
Создайте производный класс ProDocumentWorker.  
Переопределите соответствующие методы, при переопределении методов выводите следующие строки: 
"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт". 
Создайте производный  класс ExpertDocumentWorker от базового класса ProDocumentWorker. Переопределите соответствующий метод. 
При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате". 
В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, 
то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker. */

using System;

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
