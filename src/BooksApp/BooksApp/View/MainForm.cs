using BooksApp.Model.Classes;
using BooksApp.Model.Enumerations;
using BooksApp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BooksApp
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список книг.
        /// </summary>
        private List<Book> _books = new();

        /// <summary>
        /// Текущая книга.
        /// </summary>
        private Book _currentBook;

        /// <summary>
        /// Стандартный цвет фона.
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет фона при возникновении ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Реализует обработку формы и создание экземпляра класса <see cref="Book"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            var genres = Enum.GetValues(typeof(Genre));
            foreach (var genre in genres)
            {
                genreComboBox.Items.Add(genre);
            }

            _books = Serializer.Deserialize();
            UpdateListBox(-1);
        }

        /// <summary>
        /// Создает и форматирует элемент типа string из переданного элемента
        /// класса <see cref="Book"/>.
        /// </summary>
        /// <param name="book">Книга.</param>
        /// <returns>
        /// Возвращает созданный элемент.
        /// </returns>
        private static string GetBookInfo(Book book)
        {
            string bookInfo = ($"{book.Title}/{book.Author}/{book.Genre}");
            return bookInfo;
        }

        /// <summary>
        /// Форматирует переданный элемент в <see cref="GetBookInfo(Book)"/>
        /// и обновляет информацию о нем в ListBox.
        /// </summary>
        /// <param name="book">Книга.</param>
        private void UpdateBookInfo(Book book)
        {
            int index = booksListBox.SelectedIndex;
            if (index == -1) return;

            booksListBox.Items[index] = GetBookInfo(book);
        }

        /// <summary>
        /// Очищает и заново добавляет элементы списка <see cref="_books"/> в ListBox.
        /// </summary>
        /// <param name="index">Индекс переданного элемента.</param>
        private void UpdateListBox(int index)
        {
            List<Book> books = _books;
            booksListBox.Items.Clear();
            foreach (var book in books)
            {
                booksListBox.Items.Add(GetBookInfo(book));
            }

            if (-1 <= index && index < booksListBox.Items.Count)
            {
                booksListBox.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Сортирует элементы списка <see cref="_books"/>.
        /// </summary>
        private void SortBooks()
        {
            _books = (from book in _books
                      orderby book.Title
                      select book).ToList();
            UpdateListBox(-1);
        }

        /// <summary>
        /// Очищает информацию о выбранном элементе во всех TextBox.
        /// </summary>
        private void ClearBookInfo()
        {
            titleBookTextBox.Clear();
            releaseYearTextBox.Clear();
            authorTextBox.Clear();
            pagesNumberTextBox.Clear();
            genreComboBox.ResetText();
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksListBox.SelectedItem == null) return;

            _currentBook = _books[booksListBox.SelectedIndex];
            if (_currentBook.Genre == "")
            {
                genreComboBox.SelectedIndex = -1;
            }
            titleBookTextBox.Text = _currentBook.Title;
            releaseYearTextBox.Text = _currentBook.ReleaseYear.ToString();
            authorTextBox.Text = _currentBook.Author;
            pagesNumberTextBox.Text = _currentBook.PagesNumber.ToString();
            genreComboBox.Text = _currentBook.Genre;
        }

        private void AddButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            booksListBox.SelectedIndex = -1;
            Book _newBook = new("", 0, "", 1, "");
            _books.Add(_newBook);
            SortBooks();
            UpdateListBox(_books.IndexOf(_newBook));
            booksListBox.SelectedIndex = _books.IndexOf(_newBook);
            genreComboBox.SelectedIndex = -1;
        }

        private void RemoveButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (booksListBox.SelectedItem == null) return;
            int index = booksListBox.SelectedIndex;
            _books.RemoveAt(index);
            booksListBox.Items.RemoveAt(index);
            ClearBookInfo();
        }

        private void TitleBookTextBox_TextChanged(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1) return;

            try
            {
                _currentBook.Title = titleBookTextBox.Text;
                titleBookTextBox.BackColor = _correctColor;
                SortBooks();
                UpdateListBox(_books.IndexOf(_currentBook));
                UpdateBookInfo(_currentBook);
            }

            catch
            {
                titleBookTextBox.BackColor = _errorColor;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1) return;

            try
            {
                _currentBook.ReleaseYear = Convert.ToInt32(releaseYearTextBox.Text);
                releaseYearTextBox.BackColor = _correctColor;
                UpdateBookInfo(_currentBook);
            }

            catch
            {
                releaseYearTextBox.BackColor = _errorColor;
            }
        }

        private void AuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1) return;

            try
            {
                _currentBook.Author = authorTextBox.Text;
                authorTextBox.BackColor = _correctColor;
                SortBooks();
                UpdateBookInfo(_currentBook);
                UpdateListBox(_books.IndexOf(_currentBook));
            }

            catch
            {
                authorTextBox.BackColor = _errorColor;
            }
        }

        private void PagesNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1) return;

            try
            {
                _currentBook.PagesNumber = Convert.ToInt32(pagesNumberTextBox.Text);
                pagesNumberTextBox.BackColor = _correctColor;
                UpdateBookInfo(_currentBook);
            }

            catch
            {
                pagesNumberTextBox.BackColor = _errorColor;
            }
        }

        private void GenreComboBox_TextChanged(object sender, EventArgs e)
        {
            if (booksListBox.SelectedIndex == -1) return;

            _currentBook.Genre = genreComboBox.Text;
            UpdateBookInfo(_currentBook);
        }

        private void AddButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.add_24x24;
        }

        private void AddButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.add_24x24_uncolor;
        }

        private void RemoveButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.remove_24x24;
        }

        private void RemoveButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.remove_24x24_uncolor;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.Serialize(_books);
        }
    }
}
