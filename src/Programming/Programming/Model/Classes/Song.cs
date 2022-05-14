using System;

namespace Programming.Model.Classes
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
                if (value < 0)
                {
                    throw new ArgumentNullException("Error");
                }
                _songDurationSeconds = value;
            }
        }
    }
}