using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ооплаб2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Generate generate = new Generate();

        Triangle tri = null;
        Rectangle rec = null;



        Point2D p2d = null;
        Generate gen = null;

        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void drawRectangle(Rectangle r)
        {
            drawLine(r.GetPoint1(), r.GetPoint2());
            drawLine(r.GetPoint2(), r.GetPoint3());
            drawLine(r.GetPoint3(), r.GetPoint4());
            drawLine(r.GetPoint4(), r.GetPoint1());
        }

        private void drawLine(Point2D begin, Point2D end)
        {
            // создание объекта (экземпляра) класса Line 
            Line line = new Line();

            // задание цвета линии (красный) с помощью свойства Stroke 
            line.Stroke = Brushes.Red; // задание толщины линии (5) с помощью свойства StrokeThickness line.StrokeThickness = 5; 

            // задание относительных координат начала и конца линии с помощью свойств X1, Y1, X2, Y2 
            line.X1 = begin.GetX();
            line.Y1 = begin.GetY();
            line.X2 = end.GetX();
            line.Y2 = end.GetY();

            // добавление линии в холст (линия добавляется в список "дочерних" элементов холста) 
            canvas.Children.Add(line);
        }

        
        private void drawTriangle(Triangle tri)
        {
            drawLine(tri.GetPoint1(), tri.GetPoint2());
            drawLine(tri.GetPoint2(), tri.GetPoint3());
            drawLine(tri.GetPoint3(), tri.GetPoint1());
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            rec = null;
            rec = null;
            canvas.Children.Clear();
            p2d = generate.getPoint();
            tri = generate.GetTriangle();
            drawTriangle(tri);
            l2.Content = tri.getPerimeter() - tri.getPerimeter() % 1;
            l3.Content = tri.getArea() - tri.getArea() % 1;
            l1.Content = tri.GetPoint1() + " " + tri.GetPoint2() + " " + tri.GetPoint3();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tri = null;
            rec = null;
            canvas.Children.Clear();
            rec = generate.GetRectangle();
            drawRectangle(rec);
            l2.Content = rec.getPerimeter() - rec.getPerimeter() % 1;
            l3.Content = rec.getArea() - rec.getArea() % 1;
            l1.Content = rec.GetPoint1() + " " + rec.GetPoint2() + " " + rec.GetPoint3() + " " + rec.GetPoint4();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tri = null;
            rec = null;
            canvas.Children.Clear();
            rec = generate.GetSquare();
            drawRectangle(rec);
            l2.Content = rec.getPerimeter() - rec.getPerimeter() % 1;
            l3.Content = rec.getArea() - rec.getArea() % 1;
            l1.Content = rec.GetPoint1() + " " + rec.GetPoint2() + " " + rec.GetPoint3() + " " + rec.GetPoint4();
        }

        private void sliderx_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if
              ((tri != null))
            {
                Point2D p1 = tri.GetPoint1();
                Point2D p2 = tri.GetPoint2();
                Point2D p3 = tri.GetPoint3();
                l1.Content = $"{p1} {p2}) {p3}";

                tri.shiftX(sliderx.Value);
                canvas.Children.Clear();
                drawTriangle(tri);
            }
            if (rec != null)
            {
                Point2D p1 = rec.GetPoint1();
                Point2D p2 = rec.GetPoint2();
                Point2D p3 = rec.GetPoint3();
                Point2D p4 = rec.GetPoint4();
                l1.Content = $"{p1} {p2} {p3} {p4}";

                rec.shiftX(sliderx.Value);
                canvas.Children.Clear();
                drawRectangle(rec);
            }
        }

        private void slidery_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (tri != null)
            {
                Point2D p1 = tri.GetPoint1();
                Point2D p2 = tri.GetPoint2();
                Point2D p3 = tri.GetPoint3();
                l1.Content = $"{p1} {p2} {p3}";

                tri.shiftY(slidery.Value);
                canvas.Children.Clear();
                drawTriangle(tri);
            }

            if (rec != null)
            {
                Point2D p1 = rec.GetPoint1();
                Point2D p2 = rec.GetPoint2();
                Point2D p3 = rec.GetPoint3();
                Point2D p4 = rec.GetPoint4();
                l1.Content = $"{p1} {p2} {p3} {p4}";

                rec.shiftY(slidery.Value);
                canvas.Children.Clear();
                drawRectangle(rec);
            }
        }

               //public MainWindow()
        //{
        //    InitializeComponent();
        //    Draw();
        //}

        //private void Draw()
        //{
        //    // создание объекта (экземпляра) класса Line 
        //    Line line = new Line();

        //    // задание цвета линии (красный) с помощью свойства Stroke 
        //    line.Stroke = Brushes.Red;

        //    // задание толщины линии (5) с помощью свойства StrokeThickness 
        //    line.StrokeThickness = 5;

        //    // задание относительных координат начала и конца линии с помощью свойств X1, Y1, X2, Y2 
        //    line.X1 = 10;
        //    line.Y1 = 10;
        //    line.X2 = 50;
        //    line.Y2 = 50;


        //    // добавление линии в холст (линия добавляется в список "дочерних" элементов холста) 
        //    canvas.Children.Add(line);

        //}

    }
}
