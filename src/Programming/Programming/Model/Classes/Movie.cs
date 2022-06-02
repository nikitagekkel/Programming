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
                    throw new ArgumentException("Error, duration can't be negative");
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
                    throw new ArgumentException("Error, year realise can be only from 1900 to now year");
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
                    throw new ArgumentException("Error, rating can't be lesser than 0");
                }
                _movieRating = value;
            }
        }
        public Movie(string movieName, string movieGenre, int timing, int yearRealese, double rating)
        {
            MovieName = movieName;
            MovieGenre = movieGenre;
            _movieDurationMinutes = timing;
            _movieYearRealese = yearRealese;
            _movieRating = rating;
        }
    }
}
