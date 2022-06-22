using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные фильма.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Уникальный идентификатор продолжительности фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Уникальный идентификатор года выхода фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Уникальный идентификатор рейтинга фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает название фильма. Состоит из строки.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма. Состоит из строки.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма. Состоит только из положительного числа.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает год выхода фильма. Состоит из года в диапазоне
        /// от 1900 и до сегодняшнего.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Состоит из цифр в диапазоне от 0 до 10.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из
        /// букв.</param>
        /// <param name="genre">Жанр. Должен состоять только из
        /// букв.</param>
        /// <param name="duration">Продолжительность фильма. Должна состоять
        /// только из цифр.</param>
        /// <param name="yearRealese">Год выхода фильма. Состоит только из цифр,
        /// в диапазоне от 1900 до сегодняшенго года</param>
        /// <param name="rating">Рейтинг фильма. Состоит только из цифр,
        /// в диапазоне от 0 10.</param>
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
