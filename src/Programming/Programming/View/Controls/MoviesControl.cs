using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Список фильмов.
        /// </summary>
        private List<Movie> _movies = new();

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Создает элементы списка фильмов и
        /// добавляет их в элемент ListBox.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            _movies.Add(new Movie("Driver", "Action", 140, 2011, 7.8));
            _movies.Add(new Movie("Snatch", "Action", 144, 2000, 8.3));

            foreach (Movie movie in _movies)
            {
                movieListBox.Items.Add(movie.Name);
            }
        }

        /// <summary>
        /// Ищет в списке фильмов элемент, с наибольшим рейтингом.
        /// </summary>
        /// <returns>
        /// Возвращает индекс найденного элемента.
        /// </returns>
        private int FindMovieWithMaxRating()
        {
            double maxRating = 0;
            int index = 0;

            foreach (Movie movie in _movies)
            {
                if (movie.Rating > maxRating)
                {
                    maxRating = movie.Rating;
                    index = _movies.IndexOf(movie);
                }
            }

            return index;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[movieListBox.SelectedIndex];
            nameTextBox.Text = _currentMovie.Name;
            genreTextBox.Text = _currentMovie.Genre;
            durationTextBox.Text = _currentMovie.Duration.ToString();
            releaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            ratingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = nameTextBox.Text;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = genreTextBox.Text;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Duration = Convert.ToInt32(durationTextBox.Text);
                durationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                durationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = Convert.ToInt32(releaseYearTextBox.Text);
                releaseYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                releaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Convert.ToDouble(ratingTextBox.Text);
                ratingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                ratingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            movieListBox.SelectedIndex = FindMovieWithMaxRating();
        }
    }
}
