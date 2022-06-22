using Programming.Model.Classes;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные песни.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Уникальный идентификатор продолжительности песни в секундах.
        /// </summary>
        private int _songDurationSeconds;

        /// <summary>
        /// Возвращает и задает название песни. Состоит только из строки.
        /// </summary>
        public string SongName { get; set; }

        /// <summary>
        /// Возвращает и задает имя исполнителя. Состоит только из строки.
        /// </summary>
        public string SongArtistName { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность песни. Состоит только из положиьтельных цифр.
        /// </summary>
        public int SongDurationMinutes
        {
            get
            {
                return _songDurationSeconds;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(SongDurationMinutes), value);
                _songDurationSeconds = value;
            }
        }
    }
}