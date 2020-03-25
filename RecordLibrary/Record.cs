using System;

namespace RecordLibrary
{
    public class Record
    {
        private string _title;
        private string _artist;
        private int _releaseYear;

        public string Title
        {
            get => _title;
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Error Record title","Record title can not be empty");
                _title = value;
            }
        }

        public string Artist
        {
            get => _artist;
            set
            {
                if (String.IsNullOrWhiteSpace(value)) throw new ArgumentNullException("Error Artist Name","Artist name can not be empty");
                _artist = value;
            }
        }

        public int ReleaseYear
        {
            get => _releaseYear;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Error Release Year Negative", "Value cant be a negative number");
                _releaseYear = value;
            }
        }
    }
}
