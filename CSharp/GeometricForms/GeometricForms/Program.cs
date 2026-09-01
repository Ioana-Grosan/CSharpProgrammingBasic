namespace OOP_Principles
{
    class Program
    {
        public static void Main()
        {
            Circle circle = new Circle(2.03);
            Square square = new Square(3.4);
            Triangle trinagle = new Triangle(7.2,4.6);
            var perimeter = circle.Perimeter();
            var area = circle.Area();
            Console.WriteLine("Circle size: " +perimeter + " , " + area);
            var squarePerimeter = square.Perimeter();
            var SquareArea = square.Area();
            Console.WriteLine("Square side: " + squarePerimeter + " , " + SquareArea);
            var TrianglePerimeter= trinagle.Perimeter();
            var TraingleArea = trinagle.Area();
            Console.WriteLine("Triangle ground, height: " + TrianglePerimeter + " , " + TraingleArea);

        }

    }

    public abstract class Form
    {


        public abstract double Area();
        public abstract double Perimeter();

    }

    public class Circle : Form
    {
        public double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double Area()
        {
            return 3.14159 * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14159 * radius;
        }
    }
    public class Square : Form
    {
        public double side;
        public Square(double l)
        {
            side = l;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }

      public class Triangle : Form
        {

            public double ground;
            public double height;
            public Triangle(double g, double h)
            {
                ground = g;
                height = h;
            }
            public override double Area()
            {
                return 0.5 * ground * height;
            }

            public override double Perimeter()
            {
                double side = Math.Sqrt(Math.Pow(ground / 2, 2) + Math.Pow(height,2));
               return ground + 2* side;
            }
        }

   
}

