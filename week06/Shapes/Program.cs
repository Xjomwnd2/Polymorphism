using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test individual shapes
            Console.WriteLine("Testing individual shapes:");
            
            Square square = new Square("Red", 5.0);
            Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea()}");
            
            Rectangle rectangle = new Rectangle("Blue", 4.0, 6.0);
            Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea()}");
            
            Circle circle = new Circle("Green", 3.0);
            Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea()}");
            
            Console.WriteLine("\nDemonstrating polymorphism with a list of shapes:");
            
            // Create a list of shapes
            List<Shape> shapes = new List<Shape>();
            
            // Add different shapes to the list
            shapes.Add(new Square("Yellow", 2.0));
            shapes.Add(new Rectangle("Purple", 3.0, 5.0));
            shapes.Add(new Circle("Orange", 4.0));
            
            // Iterate through the list and display information
            int index = 1;
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Shape {index} - Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
                index++;
            }
        }
    }
}