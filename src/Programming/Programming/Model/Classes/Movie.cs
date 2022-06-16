using System;

namespace Programming.Model.Geometry
{
    public class Movie
    {
        private int _duration;

        private int _releaseYear;

        private double _rating;

        public string Name { get; set; }

        public string Genre { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                _duration = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
                _rating = value;
            }
        }

        public Movie(
            string name,
            string genre,
            int duration,
            int yearRealese,
            double rating)
        {
            Name = name;
            Genre = genre;
            _duration = duration;
            _releaseYear = yearRealese;
            _rating = rating;
        }
    }
}
