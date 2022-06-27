using System;

namespace BooksApp.Model.Classes
{
    /// <summary>
    /// Хранит книгу и ее данные.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Уникальный идентификатор названия книги.
        /// </summary>
        private string _title;

        /// <summary>
        /// Уникальный идентификатор года выпуска книги.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Уникальный идентификатор количества страниц книги.
        /// </summary>
        private int _pagesNumber;

        /// <summary>
        /// Возвращает и задает автора книги.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает жанр книги. 
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает название книги.
        /// Длина названия не может быть больше 100 символов.
        /// </summary>
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
                    throw new ArgumentException("Title's length must be less than 100");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выпуска книги.
        /// Год выпуска не может превыщать текущий год. 
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if (value > DateTime.Now.Year || value < 0)
                {
                    throw new ArgumentException("Release year must be less than today's year");
                }
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество странци книги.
        /// Количество страниц не может быть меньше 0.
        /// </summary>
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

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Book"/>.
        /// </summary>
        /// <param name="title">Название.
        /// Длина названия не должна превышать 100 символов.</param>
        /// <param name="releaseYear">Год выпуска.
        /// Год выпуска не должен быть больше текущего года.</param>
        /// <param name="author">Автор.</param>
        /// <param name="pagesNumber">Количество страниц.
        /// Количество страниц должно быть строго положительным.</param>
        /// <param name="genre">Жанр.</param>
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
