/* Структуры и их разновидности 
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта назначения, номер поезда, время отправления. 
Написать программу, выполняющую следующие действия: 
-	ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train (записи должны быть упорядочены по номерам поездов); 
-	вывод на экран информации о поезде, номер которого введен с клавиатуры (если таких поездов нет, вывести соответствующее сообщение). */

using System;

namespace Lesson_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var train = new Train[2];

            MyClass.AddingTrain(train);
            Console.WriteLine("Вы ввели такую информацию о поездах:");
            MyClass.Sort(train);
            MyClass.Show(train);
            Console.WriteLine("Введите номер поезда:");
            int poisk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));
            MyClass.Search(train, poisk);

            Console.ReadKey();
        }
    }
}
