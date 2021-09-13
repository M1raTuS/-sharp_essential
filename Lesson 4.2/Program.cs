/* Абстрактные классы и интерфейсы
 
Используя Visual Studio, создайте проект по шаблону Console Application.  Требуется:  
Создайте класс AbstractHandler. 
В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 
Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.  */

using System;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Choise redactor = new Choise();
            redactor.ChooseDocument("file.doc");

            redactor.Open();
            redactor.Change();
            redactor.Save();

            // Delay.
            Console.ReadKey();

        }
    }
}
