﻿using System;

namespace Programming.Model.Classes
{
    public class Journey
    {
        private int _flightTimeMinutes;

        public string DeparturePoint { get; set; }

        public string DestinationPoint { get; set; }

        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Error, time can't be negative");
                }
                _flightTimeMinutes = value;
            }
        }
    }
}
