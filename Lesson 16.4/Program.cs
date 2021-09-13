/* Перегрузка операторов 

Создайте класс, который будет содержать информацию о дате (день, месяц, год). 
С помощью механизма перегрузки операторов, определите операцию разности двух дат (результат в виде количества дней между датами), 
а также операцию увеличения даты на определенное количество дней.  */

using System;

namespace Lesson_16._4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date1 = new MyDate(DateTime.Now);
            Console.WriteLine(date1.ToString());

            MyDate date2 = new MyDate(new DateTime(2020, 12, 4));
            Console.WriteLine(date2.ToString());

            Console.WriteLine(MyDate.Sub(date1, date2).ToString());
            Console.WriteLine(MyDate.Add(date1, date2).ToString());

            Console.ReadKey();
        }
    }
}
