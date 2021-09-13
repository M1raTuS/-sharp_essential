/* Перегрузка операторов 

Создайте класс House c двумя полями и свойствами.  
Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное и глубокое копирование соответственно. 
Реализуйте простой способ проверки. */

using System;

namespace Lesson_16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new House(new Street("Центральная"), "Днепр");

            House clone;
            //clone = house.Clone();
            clone = house.DeepClone();

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);
            Console.WriteLine(new string('-', 50));

            clone.City = "Одесса";
            clone.Street = new Street("Дерибасовская");

            Console.WriteLine("Original: {0}, {1}", house.City, house.Street.Str);
            Console.WriteLine("Clone   : {0}, {1}", clone.City, clone.Street.Str);

            Console.ReadKey();
        }
    }
}
