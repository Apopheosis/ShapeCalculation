using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;

namespace ShapeCalculation
{

    /*public abstract class Shape
    {
        protected double area;
        
        public double Area()
        {
            return this.area;
        }
    }

    public class Triangle : Shape
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.area = Shapes.Area(this.a, this.b, this.c);
        }

        
    }

    public class Circle : Shape
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
            this.area = Shapes.Area(r);
        }
    }*/
    
    public class Shapes
    {

        public static double Area(double r)
        {
            return Circle(r);
        }

        public static double Area(double a, double b, double c)
        {
            if ((a * a) + (b * b) == (c * c))
            {
                return RectangularTriangle(a, b);
            }
            return Triangle(a, b, c);
        }

        static double RectangularTriangle(double a, double b)
        {
            return 0.5 * a * b;
        }
        
        static double Circle(double r)
        {
            return Math.PI * r * r;
        }

        static double Triangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}