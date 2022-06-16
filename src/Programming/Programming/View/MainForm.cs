using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using System.Collections.Generic;
using Programming.Model.Classes;
using Programming.Properties;

namespace Programming
{
    public partial class MainForm : Form
    {
        private List<Rectangle> _rectangles = new();

        private List<Movie> _movies = new();

        private List<Rectangle> _panelRectangles = new();

        private Rectangle _currentRectangle;

        private Rectangle _panelCurrentRectangle;

        private Movie _currentMovie;
        
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
                Random rnd = new();
                double newHeight = rnd.Next(1, 10);
                double newWidth = rnd.Next(1, 10);
                int newX = rnd.Next(1, 10);
                int newY = rnd.Next(1, 10);
                Point2D newCenter = new(newX, newY);
                Array colour = Enum.GetValues(typeof(Colour));
                Colour randomColor = (Colour)colour.GetValue(rnd.Next(colour.Length));
                Rectangle _generatedRectangle = new(
                    newHeight, newWidth, randomColor.ToString(), newCenter);
                _rectangles.Add(_generatedRectangle);
            }

            _movies.Add(new Movie("Driver", "Action", 140, 2011, 7.8));
            _movies.Add(new Movie("Snatch", "Action", 144, 2000, 8.3));

            foreach (Rectangle rectangle in _rectangles)
            {
                rectanglesListBox.Items.Add(string.Format("Rectangle {0}", rectangle.Id));
            }

            foreach (Movie movie in _movies)
            {
                movieListBox.Items.Add(movie.Name);
            }
        }


        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = 0;
            int maxIndex = 0;
            foreach (Rectangle rectangle in _rectangles)
            {
                if (rectangle.Width > maxWidth)
                {
                    maxWidth = rectangle.Width;
                    maxIndex = _rectangles.IndexOf(rectangle);
                }
            }
            return maxIndex;
        }
        
        private int FindMovieWithMaxRating()
        {
            double maxRating = 0;
            int maxIndex = 0;
            foreach (Movie movie in _movies)
            {
                if (movie.Rating > maxRating)
                {
                    maxRating = movie.Rating;
                    maxIndex = _movies.IndexOf(movie);
                }
            }
            return maxIndex;
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
            _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
            heigthTextBox.Text = _currentRectangle.Heigth.ToString();
            widthTextBox.Text = _currentRectangle.Width.ToString();
            colorTextBox.Text = _currentRectangle.Color;
            idTextBox.Text = _currentRectangle.Id.ToString();
            coordinateXTextBox.Text = _currentRectangle.Center.X.ToString();
            coordinateYTextBox.Text = _currentRectangle.Center.Y.ToString();
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

        private void HeigthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Heigth = Convert.ToDouble(heigthTextBox.Text);
                heigthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                heigthTextBox.BackColor = System.Drawing.Color.LightPink;
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

        private void RealeseYearTextBox_TextChanged(object sender, EventArgs e)
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
        private void FindRectanglesButton_Click(object sender, EventArgs e)
        {
            rectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

        private void AddButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_add_24x24;
        }

        private void AddButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_remove_24x24;
        }

        private void RemoveButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddButtonPictureBox_Click(object sender, EventArgs e)
        {
            Random rnd = new();
            double newHeight = rnd.Next(1, 10);
            double newWidth = rnd.Next(1, 10);
            int newX = rnd.Next(1, 10);
            int newY = rnd.Next(1, 10);
            Point2D newCenter = new(newX, newY);
            Array color = Enum.GetValues(typeof(Colour));
            Colour randomColor = (Colour)color.GetValue(rnd.Next(color.Length));
            Rectangle generatedRectangle = new(
                newHeight, newWidth, randomColor.ToString(), newCenter);
            _panelRectangles.Add(generatedRectangle);

            panelRectanglesListBox.Items.Clear();
            foreach (Rectangle rectangle in _panelRectangles)
            {
                string selectedRectangle = string.Format(
                    "{0}:(X={1}; Y={2}; W={3}; H={4})", rectangle.Id, rectangle.Center.X, rectangle.Center.Y, rectangle.Width, rectangle.Heigth);
                panelRectanglesListBox.Items.Add(selectedRectangle);
            }
            panelRectanglesListBox.SetSelected(_panelRectangles.Count - 1, true);
        }

        private void PanelRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = panelRectanglesListBox.SelectedIndex;
            if (index >= 0)
            {
                _panelCurrentRectangle = _panelRectangles[index];
                panelHeigthTextBox.Text = _panelCurrentRectangle.Heigth.ToString();
                panelWidthTextBox.Text = _panelCurrentRectangle.Width.ToString();
                panelIdTextBox.Text = _panelCurrentRectangle.Id.ToString();
                panelCoordinateXTextBox.Text = _panelCurrentRectangle.Center.X.ToString();
                panelCoordinateYTextBox.Text = _panelCurrentRectangle.Center.Y.ToString();
            }
        }
    }
}