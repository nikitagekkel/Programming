namespace Programming.Model.Geometry
{
    public class Flight
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
                Validator.AssertOnPositiveValue(nameof(FlightTimeMinutes), value);
                _flightTimeMinutes = value;
            }
        }
    }
}
