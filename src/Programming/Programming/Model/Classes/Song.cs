namespace Programming.Model.Geometry
{
    public class Song
    {
        private int _songDurationSeconds;

        public string SongName { get; set; }

        public string SongArtistName { get; set; }

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