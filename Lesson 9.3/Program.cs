/* Делегаты 
 
Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте анонимный метод, который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений методов, 
сообщенных с делегатами в массиве. Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.   */

using System;

namespace Lesson_9._3
{
    class Program
    {
        static Random rand = new Random();

        delegate int MyDelegate();
        delegate double MyDel(MyDelegate[] a);

        static int GetRandom()
        {
            return rand.Next(100);
        }

        static void Main()
        {
            var array = new MyDelegate[50];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();
            }

            MyDel d = delegate (MyDelegate[] c)
            {
                double sr = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    sr += c[i].Invoke();
                }
                return sr / array.Length;
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i].Invoke() + " ");
            }

            Console.WriteLine("\nСреднее арифметическое элементов {0:##.###}", d(array));


            Console.ReadKey();
        }
    }
}
