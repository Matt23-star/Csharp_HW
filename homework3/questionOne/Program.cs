using System;

namespace questionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface Shape
    {
        public double Area();
        public bool Judge();
    }

    public class Rectangle : Shape
    {
        protected double a { get; set; }
        protected double b { get; set; }


        public Rectangle(double a,double b)
        {
            this.a = a;
            this.b = b;
        }

        double Shape.Area()
        {
            return a * b;
        }

        bool Shape.Judge()
        {
            if (a != b)
                return true;
            return false;        
        }
    }

    public class Square : Rectangle
    {
        private double side { get; set; }
        public Square(double side) : base( side,side)
        {
            this.side = side;
        }

        double Area()
        {
            return side * side;
        }

        bool Judge()
        {
            if (a == b)
                return true;
            return false;
        }
    }

    public class Triangle:Shape
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        double Shape.Area()
        {
            double p = (a + b + c) / 2;
            return System.Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        bool Shape.Judge()
        {
            double t;
            double[] sides = { a, b, c };
            for (int j = 0;j < 2; j++)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (sides[i] < sides[i + 1])
                    {
                        t = sides[i + 1];
                        sides[i + 1] = sides[i];
                        sides[i] = t;
                    }
                }
            }
            if (sides[0] < (sides[1] + sides[2])
                && sides[2] > (sides[0] - sides[1])
                && sides[1] > (sides[0] - sides[2]))
                return true;
            return false;
        }
    }
}
