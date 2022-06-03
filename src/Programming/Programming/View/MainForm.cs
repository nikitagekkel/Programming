using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using System.Collections.Generic;
using Programming.Model.Classes;

namespace Programming
{
    public partial class MainForm : Form
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private List<Movie> _movies = new List<Movie>();
        private Rectangle _currentRectangle;
        private Rectangle _generatedRectangle;
        private Movie _movieOne;
        private Movie _movieSecond;
        private Movie _currentMovie;
        private int rectangleIndex = 0;
        private int movieIndex = 0;
        
        public MainForm()
        {

            InitializeComponent();
            var enumEnumeration = Enum.GetValues(typeof(Enums));
            foreach (var item in enumEnumeration)
            {
                enumsListBox.Items.Add(item);
            }

            enumsListBox.SelectedIndex = 0;

            var seasons = Enum.GetValues(typeof(Season));
            foreach (var season in seasons)
            {
                seasonComboBox.Items.Add(season);
            }
            
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                double newHeight = rnd.Next(1, 10);
                double newWidth = rnd.Next(1, 10);
                int newX = rnd.Next(1, 10);
                int newY = rnd.Next(1, 10);
                Array colors = Enum.GetValues(typeof(Colour));
                Colour randomColor = (Colour)colors.GetValue(rnd.Next(colors.Length));
                string newName = string.Format("Rectangle {0}", (i+1));
                _generatedRectangle = new Rectangle(newHeight, newWidth, randomColor.ToString(), newName);
                _rectangles.Add(_generatedRectangle);
            }
            foreach (Rectangle rectangle in _rectangles)
            {
                rectanglesListBox.Items.Add(rectangle.Name);
            }

            _movieOne = new Movie("Driver", "Action", 140, 2011, 7.8);
            _movieSecond = new Movie("Snatch", "Action", 144, 2000, 8.3);
            _movies.Add(_movieOne);
            _movies.Add(_movieSecond);

            foreach (Movie movie in _movies)
            {
                movieListBox.Items.Add(movie.MovieName);
            }
        }
        private int FindRectangleWithMaxWidth()
        {
            double maxLenght = 0;
            int maxIndex = 0;
            foreach (Rectangle rectangle in _rectangles)
            {
                if (rectangle.Lenght > maxLenght)
                {
                    maxLenght = rectangle.Lenght;
                    maxIndex = _rectangles.IndexOf(rectangle);
                }
            }
            rectangleIndex = maxIndex;
            return rectangleIndex;
        }
        
        private int FindMovieWithMaxRating()
        {
            double maxRating = 0;
            int maxIndex = 0;
            foreach (Movie movie in _movies)
            {
                maxRating = movie.Rating;
                maxIndex = _movies.IndexOf(movie);
            }
            movieIndex = maxIndex;
            return movieIndex;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parseLabel.Text = "";
            switch ((Enums)enumsListBox.SelectedItem)
            {
                case Model.Enums.Enums.Colour:
                    valuesListBox.DataSource = Enum.GetValues(typeof(Colour));
                    break;
                case Model.Enums.Enums.Company:
                    valuesListBox.DataSource = Enum.GetValues(typeof(Company));
                    break;
                case Model.Enums.Enums.EducationForm:
                    valuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                    break;
                case Model.Enums.Enums.Genre:
                    valuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Model.Enums.Enums.Season:
                    valuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case Model.Enums.Enums.Weekday:
                    valuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = valuesListBox.SelectedItem;
            intValueTextBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(parsingTextBox.Text, out Weekday weekday))
            {
                parseLabel.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }
            else
            {
                parseLabel.Text = "Нет такого дня недели";
            }
            parsingTextBox.Text = "";

        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            switch ((Season)seasonComboBox.SelectedItem)
            {
                case Season.Spring:
                    enumsTabPage.BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    enumsTabPage.BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedRectangleIndex = rectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedRectangleIndex];
            lenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            widthTextBox.Text = _currentRectangle.Width.ToString();
            colorTextBox.Text = _currentRectangle.Color;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Lenght = Convert.ToDouble(lenghtTextBox.Text);
                lenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                lenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(widthTextBox.Text);
                widthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                widthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth();
            rectanglesListBox.SelectedIndex = rectangleIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMovieIndex = movieListBox.SelectedIndex;
            _currentMovie = _movies[selectedMovieIndex];
            nameTextBox.Text = _currentMovie.MovieName;
            genreTextBox.Text = _currentMovie.MovieGenre;
            timingTextBox.Text = _currentMovie.Timing.ToString();
            yearRealseTextBox.Text = _currentMovie.YearRealese.ToString();
            ratingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void FindMoviesButton_Click(object sender, EventArgs e)
        {
            FindMovieWithMaxRating();
            movieListBox.SelectedIndex = movieIndex;
        }
    }
}