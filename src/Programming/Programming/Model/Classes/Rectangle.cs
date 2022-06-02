using System;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _lenght;
        private double _width;
        
        public string Color { get; set; }
        public string Name { get; set; }

        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error, lenght can't be negative");
                }
                _lenght = value;
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
                if (value < 0)
                {
                    throw new ArgumentException("Error, width can't be negative");
                }
                _lenght = value;
            }
        }
        public Rectangle(double height, double width, string color, string name)
        {
            _width = width;
            _lenght = height;
            Color = color;
            Name = name;
        }
    }
}
