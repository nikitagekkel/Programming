using BooksApp.Model.Classes;
using BooksApp.Model.Enumerations;
using BooksApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksApp
{
    public partial class MainForm : Form
    {
        private List<Book> _books = new();

        private Book _currentBook;

        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.LightPink;

        public MainForm()
        {
            InitializeComponent();

            var genres = Enum.GetValues(typeof(Genre));
            foreach (var genre in genres)
            {
                genreComboBox.Items.Add(genre);
            }
        }

        private static string GetBookInfo(Book book)
        {
            string bookInfo = string.Format(
                "{0} / {1} / {2}",
                book.Title,
                book.Author,
                book.Genre);
            return bookInfo;
        }

        private void UpdateBookInfo(Book book)
        {
            int index = booksListBox.SelectedIndex;

            if (index == -1) return;

            booksListBox.Items[index] = GetBookInfo(book);
        }

        private static List<Book> Sorting(List<Book> books)
        {
            var sortedBooks = from book in books
                              orderby book.Title
                              select book;
            books = sortedBooks.ToList();
            return books;
        }

        private void SortAll()
        {
            booksListBox.Sorted = true;
            _books = Sorting(_books);
        }

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
            titleBookTextBox.Text = _currentBook.Title;
            releaseYearTextBox.Text = _currentBook.ReleaseYear.ToString();
            authorTextBox.Text = _currentBook.Author;
            pagesNumberTextBox.Text = _currentBook.PagesNumber.ToString();
        }

        private void AddButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            string currentTitle = titleBookTextBox.Text;
            int currentreleaseYear = Convert.ToInt32(releaseYearTextBox.Text);
            string currentAuthor = authorTextBox.Text;
            int currentPagesNumber = Convert.ToInt32(pagesNumberTextBox.Text);
            string currentGenre = genreComboBox.Text;
            _currentBook = new(currentTitle, currentreleaseYear, currentAuthor, currentPagesNumber, currentGenre);
            _books.Add(_currentBook);
            booksListBox.Items.Add(GetBookInfo(_currentBook));
        }

        private void EditButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            booksListBox.ClearSelected();
            ClearBookInfo();
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
                _currentBook.Title = Convert.ToString(titleBookTextBox.Text);
                titleBookTextBox.BackColor = _correctColor;
                UpdateBookInfo(_currentBook);
                SortAll();
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
                _currentBook.Author = Convert.ToString(authorTextBox.Text);
                authorTextBox.BackColor = _correctColor;
                UpdateBookInfo(_currentBook);
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

        private void EditButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.edit_24x24;
        }

        private void EditButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.edit_24x24_uncolor;
        }
    }
}
