using System;

namespace Lesson_1._2
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        private double AreaCalculator()
        {
            return (Convert.ToDouble(side1) * Convert.ToDouble(side2));
        }

        private double PerimeterCalculator()
        {
            return (Convert.ToDouble(side1) + Convert.ToDouble(side2)) * 2;
        }

        public double Area { get { return this.AreaCalculator(); } }
        public double Perimeter { get { return this.PerimeterCalculator(); } }

    }
}
