using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        private static int _allRectanglesCount;

        public int Id { get; }

        public string Color { get; set; }

        public string Name { get; set; }

        public Point2D Center { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Length), value);
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }

        public Rectangle(
            double length,
            double width,
            string color,
            string name,
            Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Name = name;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }
    }
}
