using System;
using Learning05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing square, rectangle, and circle");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("green", 3,4));
        shapes.Add(new Circle("blue", 2));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}