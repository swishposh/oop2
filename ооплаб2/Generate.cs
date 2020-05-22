using System;
using System.Collections.Generic;
using System.Text;

namespace ооплаб2
{
    class Generate
    {
        Random random = new Random();

        const int max = 100;

        public Triangle GetTriangle()
        {
            //double x = random.NextDouble() * max; 
            //double y = random.NextDouble() * max;
            Point2D p1= getPoint();
            Point2D p2 = getPoint();
            Point2D p3 = getPoint();

            return new Triangle(p1, p2, p3);
        }

        public Rectangle GetRectangle()
        {
            double w = random.NextDouble() * max;
            double h = random.NextDouble() * max;

            Point2D p1 = getPoint();
            Point2D p2 = new Point2D(p1.GetX() + w, p1.GetY());
            Point2D p3 = new Point2D(p1.GetX() + w, p1.GetY() + h);
            Point2D p4 = new Point2D(p1.GetX() , p1.GetY() + h);

            return new Rectangle(p1, p2, p3, p4); 
        }

        public Rectangle GetSquare()
        {
            double w = random.NextDouble() * max;
            //double h = random.NextDouble() * max;

            Point2D p1 = getPoint();
            Point2D p2 = new Point2D(p1.GetX() + w, p1.GetY());
            Point2D p3 = new Point2D(p1.GetX() + w, p1.GetY() + w);
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + w);

            return new Rectangle (p1, p2, p3, p4); 
        }

        public Point2D getPoint()
        {
            double x = random.NextDouble() * max;
            double y = random.NextDouble() * max;
            return new Point2D(x, y);
        }
    }
}
