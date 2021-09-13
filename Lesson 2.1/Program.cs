/*Классы и объекты
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
Поле дата заполнения анкеты должно быть проинициализировано только один раз (при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
Реализуйте вывод на экран информации о пользователе. */

using System;

namespace Lesson_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "log";
            string name = "Ivan";
            string surname = "Ivanov";
            int age = 18;

            User user = new User();
            User user2 = new User(login, name, surname, age);

            Console.WriteLine(user.date);

            Console.ReadKey();
        }
    }
}
