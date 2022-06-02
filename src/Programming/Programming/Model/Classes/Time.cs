using System;

namespace Programming.Model.Classes
{
    public class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value < 0 ^ value > 23)
                {
                    throw new ArgumentException("Error, hours can be only from 0 to 23");
                }
                _hours = value;
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value < 0 ^ value > 60)
                {
                    throw new ArgumentException("Error, minutes can be only from 0 to 59");
                }
                _minutes = value;
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value < 0 ^ value > 60)
                {
                    throw new ArgumentException("Error, seconds can be only from 0 to 63");
                }
                _seconds = value;
            }
        }
    }
}
