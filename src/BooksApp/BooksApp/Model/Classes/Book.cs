using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Model.Classes
{
    public class Book
    {
        private string _title;

        private int _releaseYear;

        private int _pagesNumber;

        public string Author { get; set; }

        public string Genre { get; set; }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 100)
                {
                    throw new ArgumentException("Number of pages must be less than 100");
                }
                _title = value;
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
                if (value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Release year must be less than today's year");
                }
                _releaseYear = value;
            }
        }

        public int PagesNumber
        {
            get
            {
                return _pagesNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Number of pages must be more than 0");
                }
                _pagesNumber = value;
            }
        }

        public Book(
            string title,
            int releaseYear,
            string author,
            int pagesNumber,
            string genre)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Author = author;
            PagesNumber = pagesNumber;
            Genre = genre;
        }
    }
}
