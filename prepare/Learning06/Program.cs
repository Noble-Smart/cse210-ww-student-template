using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create shapes
        Square square = new Square("Red", 5);
        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Circle circle = new Circle("Green", 3);

        // Create list of shapes
        List<Shape> shapes = new List<Shape>
        {
            square,
            rectangle,
            circle
        };

        // Iterate through list and display shape information
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }

        Console.ReadKey();
    }
}