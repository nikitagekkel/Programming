namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Уникальный идентификатор часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Уникальный идентификатор минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Уникальный идентификатор секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает часы в диапазоне от 0 до 23.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Hours), value, 0, 24);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает минуты в диапазоне от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Minutes), value, 0, 60);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды в диапазоне от о до 59.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Seconds), value, 0, 60);
                _seconds = value;
            }
        }
    }
}
