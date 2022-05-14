using System;

namespace Programming.Model.Clases
{
    public class Rectangle
    {
        private double _lenght;
        private double _width;
        
        public string Color { get; set; }

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
                    throw new ArgumentNullException("Error");
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
                    throw new ArgumentNullException("Error");
                }
                _lenght = value;
            }
        }
        public Rectangle (double height, double width, string color)
        {
            _width = width;
            _lenght = height;
            Color = color;
        }
    }
}
