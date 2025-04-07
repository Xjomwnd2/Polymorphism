using System;

namespace Shapes
{
    public class Shape
    {
        private string _color;

        public Shape(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetColor(string color)
        {
            _color = color;
        }

        // Virtual method to be overridden by derived classes
        public virtual double GetArea()
        {
            return 0.0; // Base implementation returns 0
        }
    }
}