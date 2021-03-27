using System;
using questionOne;

namespace questionTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape;
            double area = 0;
            int i = 0;
            while(i<10)
            {
                shape = ShapeFactory.GetShape(new Random().Next(0, 3));
                if (shape.Judge())
                {
                    area += shape.Area();
                    i++;
                    Console.WriteLine(shape.Area());
                }
            }

            Console.WriteLine(area);
        }
    }

    public class ShapeFactory
    {
        private static Random random = new Random();
        public static Shape GetShape(int key)
        {
            switch (key)
            {
                case 0: return new Rectangle((random.Next(1, 10) + random.NextDouble()),
                    (random.Next(1, 10) + random.NextDouble()));
                case 1: return new Square(random.Next(1, 10) + random.NextDouble());
                case 2: return new Triangle((random.Next(1, 10) + random.NextDouble()),
                    (random.Next(1, 10) + random.NextDouble()),
                    (random.Next(1, 10) + random.NextDouble()));
            }
            return new Rectangle(0, 0);
        }
    }

}
