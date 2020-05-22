using System;
using System.Collections.Generic;
using System.Text;

namespace ооплаб2
{
    class Point2D
    {
        private double x;
        private double y;

        private double xx;
        private double yy;


        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetX()
        {
            return x + xx ;
        }

        public double GetY()
        {
            return y + yy;
        }

        public void shiftX(double value)
        {
            xx = value;
        }

        public void shiftY(double value)
        {
            yy = value;
        }

        public double getDistance(Point2D otherPoint)
        {
            //Math.Sqrt((x2-x1)Math.Pow(2,2)+(y2-y1)Math.Pow(2,2));
            //return Math.Sqrt(Math.Pow(x - otherPoint.GetX(), 2) + (y2 - y1)Math.Pow(2, 2));
            return Math.Sqrt(Math.Pow(x - otherPoint.GetX(), 2) + Math.Pow(y - otherPoint.GetY(), 2));
        }

        public bool equals(Point2D otherPoint)
        {
            return true;

        }

        public override string ToString()
        {
             return "(" + (Math.Round(GetX())) + "; " + (Math.Round(GetY()) + ")");
        }

    }
}
