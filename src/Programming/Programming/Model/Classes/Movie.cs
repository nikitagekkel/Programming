using System;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private int _movieDurationMinutes;
        private int _movieYearRealese;
        private double _movieRating;

        public string MovieName { get; set; }

        public string MovieGenre { get; set; }

        public int Timing
        {
            get
            {
                return _movieDurationMinutes;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Error");
                }
                _movieDurationMinutes= value;
            }
        }

        public int YearRealese
        {
            get
            {
                return _movieYearRealese;
            }
            set
            {
                if (value < 1900 ^ value > DateTime.Now.Year)
                {
                    throw new ArgumentNullException("Error");
                }
                _movieYearRealese = value;
            }
        }

        public double Rating
        {
            get
            {
                return _movieRating;
            }
            set
            {
                if (value < 0 ^ value > 10)
                {
                    throw new ArgumentNullException("Error");
                }
                _movieRating = value;
            }
        }
    }
}
