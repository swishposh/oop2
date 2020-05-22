using System;
using System.Collections.Generic;
using System.Text;

namespace ооплаб2
{
    class Rectangle
    {
        private Point2D point1;
        private Point2D point2;
        private Point2D point3;
        private Point2D point4;

        public Rectangle(Point2D point1, Point2D point2, Point2D point3, Point2D point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
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

        public Point2D GetPoint4()
        {
            return point4;
        }

        public void shiftX(double value)
        {
            point1.shiftX(value);
            point2.shiftX(value);
            point3.shiftX(value);
            point4.shiftX(value);
        }

        public void shiftY(double value)
        {
            point1.shiftY(value);
            point2.shiftY(value);
            point3.shiftY(value);
            point4.shiftY(value);
        }

        public double getPerimeter()
        {
            return point1.getDistance(point2) + point2.getDistance(point3) + point3.getDistance(point4) + point4.getDistance(point1);
        }

        public double getArea()
        {
            return point1.getDistance(point2) * point2.getDistance(point3);
        }
    }
}
