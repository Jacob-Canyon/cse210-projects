using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 4);
       
        Circle circle = new Circle("blue",6);

        Rectangle rectangle = new Rectangle("green",6,3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Area: {area} Color: {color}");
        }
    }
}