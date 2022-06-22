using Programming.Model.Classes;

namespace Programming.Model.Classes
/// <summary>
/// Хранит данные об авиарейсе.
/// </summary>
{
    public class Flight
    {
        /// <summary>
        /// Уникальный идентификатор времени полета в минутах.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Возвращает и задает место вылета. Состоит из строки.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает место призлета.
        /// </summary>
        public string DestinationPoint { get; set; }

        /// <summary>
        /// Возвращает и задает время полета в минутах. Состоит из
        /// положительного числа.
        /// </summary>
        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTimeMinutes), value);
                _flightTimeMinutes = value;
            }
        }
    }
}
