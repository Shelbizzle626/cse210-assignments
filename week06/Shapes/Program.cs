using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("blue", 4, 6));
        shapes.Add(new Circle("pink", 3));

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Area: {s.GetArea()}");
        }
    }
}