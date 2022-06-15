using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _heigth;

        private double _width;

        private static int _allRectanglesCount;

        public int Id { get; }

        public string Color { get; set; }

        public Point2D Center { get; set; }

        public double Heigth
        {
            get
            {
                return _heigth;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Heigth), value);
                _heigth = value;
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
            double heigth,
            double width,
            string color,
            Point2D center)
        {
            Heigth = heigth;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }
    }
}
