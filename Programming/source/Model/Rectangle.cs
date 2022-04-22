using System;

namespace Programming.Model
{
    public class Rectangle
    {
        private string _lenght;

        public string Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Error");
                }

                _lenght = value;
            }
        }
    }
}
