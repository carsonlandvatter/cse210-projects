using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2, "red");

        Circle circle = new Circle(4, "blue");

        Rectangle rectangle = new Rectangle(2, 4, "yellow");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            shape.DisplayMessage();
        }
    }
}