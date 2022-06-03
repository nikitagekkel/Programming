using System;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _innerRadius;
        private double _outerRadius;
        public Point2D Center { get; set; }
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if (value < 0 || InnerRadius > OuterRadius)
                {
                    throw new ArgumentException("Error");
                }
                _innerRadius = value;
            }
        }
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                if (value < 0 || OuterRadius < InnerRadius)
                {
                    throw new ArgumentException("Error");
                }
                _outerRadius = value;
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2);
            }
        }
        public Ring (double innerRadius, double outerRadius)
        {
            _innerRadius = innerRadius;
            _outerRadius = outerRadius;
        }
    }
}
