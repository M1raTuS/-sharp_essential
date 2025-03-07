﻿/* Анонимные и динамические типы. LINQ

Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте класс Calculator, методы которого принимают аргументы и возвращают значения типа dynamic. */

using System;

namespace Lesson_17._1
{
    class Calculator
    {
        public dynamic Add(dynamic operand1, dynamic operand2)
        {
            return operand1 + operand2;
        }

        public dynamic Sub(dynamic operand1, dynamic operand2)
        {
            return operand1 - operand2;
        }

        public dynamic Mul(dynamic operand1, dynamic operand2)
        {
            return operand1 * operand2;
        }

        public dynamic Div(dynamic operand1, dynamic operand2)
        {
            if (operand2 != 0) 
            {
                return operand1 / operand2; 
            }
            else
            {
                return "На 0 делить нельзя.";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); 
            int operand1 = 20, operand2 = 13; 

            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, calculator.Add(operand1, operand2)); 
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, calculator.Sub(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, calculator.Mul(operand1, operand2));
            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, calculator.Div(operand1, operand2));

            Console.ReadKey();
        }
    }
}
