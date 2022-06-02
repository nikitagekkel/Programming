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
                Validator.AssertOnPositiveValue(nameof(Timing), value);
                _movieDurationMinutes = value;
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
                Validator.AssertValueInRange(nameof(YearRealese), value, 1900, DateTime.Now.Year);
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
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
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
