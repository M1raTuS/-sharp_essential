/* Структуры и их разновидности 
 
Создайте класс MyClass и структуру MyStruct, которые содержат в себе поля public string change. В классе  Program  создайте два  метода:  
-	static void ClassTaker(MyClass myClass), который присваивает полю change экземпляра myClass значение «изменено». 
-	static void StruktTaker(MyStruct myStruct), который присваивает полю change экземпляра myStruct значение «изменено». 
Продемонстрируйте разницу в использовании классов и структур, создав в методе Main() экземпляры структуры и класса. 
Измените, значения полей экземпляров на «не изменено», а затем вызовите методы ClassTaker и StruktTaker. Выведите на экран значения полей экземпляров. Проанализируйте полученные результаты. */

using System;

namespace Lesson_7._3
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Change";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Change";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "Dont Change";
            myStruct.change = "Dont Change";

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            Console.ReadKey();

        }
    }
    class MyClass
    {
        public string change;
    }

    struct MyStruct
    {
        public string change;
    }


}
