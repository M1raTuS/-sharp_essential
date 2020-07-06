using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
