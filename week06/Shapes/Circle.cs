using System;

namespace Shapes
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(string color, double radius) : base(color)
        {
            _radius = radius;
        }

        // Override the GetArea method for Circle
        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}