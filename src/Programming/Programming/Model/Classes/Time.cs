﻿using System;

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
                    throw new ArgumentNullException("Error");
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
                    throw new ArgumentNullException("Error");
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
                    throw new ArgumentNullException("Error");
                }
                _seconds = value;
            }
        }
    }
}
