﻿using System;

namespace Lesson_1._4
{
    class Figure
    {
        Point[] point;

        string type;
        public string Type
        {
            get { return type; }
        }

        public Figure(Point p1, Point p2, Point p3)
        {
            point = new Point[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            type = "Triangle";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point = new Point[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            type = "Tetragon";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point = new Point[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            point[4] = p5;
            type = "Pentagon";
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.Y - A.Y), 2) + Math.Pow((B.X - A.X), 2));
        }

        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                //Суммируем длину каждой стороны фигуры
                sum += LengthSide(point[i], point[i + 1]);
            }
            //Прибавляем длину последней стороны
            sum += LengthSide(point[point.Length - 1], point[0]);
            Console.Write(sum);
        }
    }
}
