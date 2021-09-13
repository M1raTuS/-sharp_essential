/* Структуры и их разновидности 
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант. 
Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.  
Создайте класс Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику премию. 
Если сотрудник отработал больше положеных часов в месяц, то ему положена премия. */

using System;

namespace Lesson_8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество отработаных часов: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accauntant a = new Accauntant(); //Создание переменной типа Accauntant и инициализация конструктором по умолчанию

            if (a.AskForBonus(Post.Cleaner, hours)) //В условном операторе производится вызов метода AskForBonus
            {
                Console.WriteLine("Дать премию"); //Отработает если метод AskForBonus вернет true
            }
            else
            {
                Console.WriteLine("Не выдавать премию");//Отработает если метод AskForBonus вернет false
            }

            //Delay.
            Console.ReadKey();
        }
    }
}
