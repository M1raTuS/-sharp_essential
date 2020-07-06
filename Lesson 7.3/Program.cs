using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
