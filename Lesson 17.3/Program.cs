﻿/* Анонимные и динамические типы. LINQ

Используя Visual Studio, создайте проект по шаблону Console Application 
Используя динамические и анонимные типы данных, 
создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание */

using System;
using System.Collections.Generic;

namespace Lesson_17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
               {new {Key = "table"},    new {Value="стол"}},
               {new {Key = "apple"},    new {Value="яблоко"}},
               {new {Key = "pen"},      new {Value="ручка"}},
               {new {Key = "pencil"},   new {Value="карандаш"}},
               {new {Key = "task"},     new {Value="задание"}},
               {new {Key = "key"},      new {Value="ключ"}},
               {new {Key = "customer"}, new {Value="покупатель"}},
               {new {Key = "ship"},     new {Value="корабль"}},
               {new {Key = "car"},      new {Value="машина"}},
               {new {Key = "cap"},      new {Value="чашка"}},

               {"table",   "стол"},
               {"apple",    "яблоко"},
               {"pen",      "ручка"},
               {"pencil",   "карандаш"},
               {"task",     "задание"},
               {"key",      "ключ"},
               {"customer", "покупатель"},
               {"ship",     "корабль"},
               {"car",      "машина"},
               {"cap",      "чашка"}
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
