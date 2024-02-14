using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 2.0));
        shapes.Add(new Rectangle("blue", 2.0, 3.0));
        shapes.Add(new Circle("green", 4.0));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape color: {shape.GetShapeColor()}");
            Console.WriteLine($"Shape area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}