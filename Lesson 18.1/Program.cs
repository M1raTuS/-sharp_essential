/* Пространства имен. Директивы препроцессора

Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом приложении */

using System;

using MyNamespaceA;

namespace MyNamespaceB
{
    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            Console.ReadKey();
        }
    }
}
