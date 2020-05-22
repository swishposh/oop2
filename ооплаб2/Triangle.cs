using System;
using System.Collections.Generic;
using System.Text;

namespace ооплаб2
{
    class Triangle
    {
        private Point2D point1;
        private Point2D point2;
        private Point2D point3;

        public Triangle(Point2D point1, Point2D point2, Point2D point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }

        public Point2D GetPoint1()
        {
            return point1;
        }

        public Point2D GetPoint2()
        {
            return point2;
        }

        public Point2D GetPoint3()
        {
            return point3;
        }

        public void shiftX(double value)
        {
            point1.shiftX(value);
            point2.shiftX(value);
            point3.shiftX(value);
        }

        public void shiftY(double value)
        {
            point1.shiftY(value);
            point2.shiftY(value);
            point3.shiftY(value);
        }

        public double getPerimeter()
        {
            return point1.getDistance(point2) + point2.getDistance(point3) + point3.getDistance(point1);

        }

        public double getArea()
        {
            double p = (point1.getDistance(point2) + point2.getDistance(point3) + point3.getDistance(point1)) / 2;

            return Math.Sqrt(p * (p - point1.getDistance(point2)) * (p - point2.getDistance(point3)) * (p - point3.getDistance(point1)));

        }


    }
}
