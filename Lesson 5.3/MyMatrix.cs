using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._3
{
    class MyMatrix
    {
        int[][] matrix;

        public MyMatrix(int n, int m)
        {
            matrix = new int[Math.Abs(n)][];
            for (int i = 0; i < Math.Abs(n); i++)
                matrix[i] = new int[Math.Abs(m)];
            Fill();
        }
        public void ShowPartial(int startRow, int startCol, int endRow, int endCol)
        {
            if (startRow < 0 || startCol < 0 || endRow > matrix.Length || endCol > matrix[0].Length) //Проверка валидности полученных аргументов
            {
                Console.WriteLine("Попытка обращения за пределы массива.");
                return;
            }

            if (startRow > endRow || startCol > endCol) //Проверка размещена ли конечная точка раньше начальной
            {
                Console.WriteLine("Неверно заданы координаты конечной точки");
                return;
            }
            if (startRow + endRow > matrix.Length || startCol+ endCol > matrix[0].Length) 
            {
                Console.WriteLine("Неверно заданы координаты");
                return;
            }
            for (int i = startRow; i < endRow+ startRow; ++i)
            {
                for (int j = startCol; j < endCol+ startCol; ++j)
                    Console.Write("{0}  ", matrix[i][j]); 
                Console.Write("\n");
            }
        }
        public void Show()
        {
            ShowPartial(0, 0, matrix.Length, matrix[0].Length);
        }

        private void Fill()
        {
            Random rand = new Random();
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[i].Length; j++)
                    matrix[i][j] = rand.Next(10, 90);
        }

        public void Change(int Row, int Col)
        {
            if (Row < 0 || Col < 0) //Проверка валидности полученных аргументов       || Row > matrix.Length || Col > matrix[0].Length
            {
                Console.WriteLine("Попытка обращения за пределы массива.");
                return;
            }

            if (Row > matrix.Length || Col > matrix[0].Length)
            {
                Console.WriteLine("Неверно заданы координаты");
                return;
            }
            matrix[Row][Col] = 11;
        }


    }
}
