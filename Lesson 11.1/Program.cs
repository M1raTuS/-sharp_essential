/* Универсальные шаблоны. Ограничения

Используя Visual Studio, создайте проект по шаблону Console Application.  
В коллекцию  ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, 
переберите данную коллекцию с помощью, цикла for – С какой проблемой вы столкнулись? */

using System;
using System.Collections;

namespace Lesson_11._1
{
    class MyClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();

            array.Add(1);
            array.Add(1.5);
            array.Add('a');
            array.Add("aaa");
            array.Add(new MyClass());

            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
