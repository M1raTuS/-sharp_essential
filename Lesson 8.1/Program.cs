/* Структуры и их разновидности 
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Реализуйте программу, которая будет принимать от пользователя дату его рождения и выводить количество дней до его следующего дня рождения.  */

using System;

namespace Lesson_8._1
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User(Convert.ToDateTime("24,09,1991"));

            user.Date();

            Console.ReadKey();
        }
    }

    class User
    {
        public DateTime Birthday { get; set; }
        TimeSpan wait;
        public User(DateTime birthday)
        {
            Birthday = birthday;
        }

        public void Date()
        {
            DateTime thisYear = new DateTime(DateTime.Now.Year, Birthday.Month, Birthday.Day);
            if (thisYear < DateTime.Now)//Если значение поля thisYear меньше значения поля now
            {
                thisYear = new DateTime(DateTime.Now.Year + 1, Birthday.Month, Birthday.Day);
                wait = thisYear - DateTime.Now;
            }
            else
            {
                wait = thisYear - DateTime.Now;
            }

            Console.WriteLine(wait.Days);
        }
    }
}
