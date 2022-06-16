using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using System.Collections.Generic;
using Programming.Model.Geometry;
using Programming.Properties;

namespace Programming
{
    public partial class MainForm : Form
    {
        private List<Rectangle> _rectangles = new();

        private List<Movie> _movies = new();

        private List<Rectangle> _rectanglesP = new();

        private List<Panel> _rectanglePanels = new();

        private Rectangle _currentRectangle;

        private Rectangle _currentPanelRectangle;

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
                _rectangles.Add(RectangleFactory.Randomazie());
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
            heigthRectangleTextBox.Text = _currentRectangle.Heigth.ToString();
            widthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            colorRectangleTextBox.Text = _currentRectangle.Color;
            idRectangleTextBox.Text = _currentRectangle.Id.ToString();
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
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
                _currentRectangle.Heigth = Convert.ToDouble(heigthRectangleTextBox.Text);
                heigthRectangleTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                heigthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(widthRectangleTextBox.Text);
                widthRectangleTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                widthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
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

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglesP.Count; i++)
            {
                canvasPanel.Controls[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectanglesP.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectanglesP.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectanglesP[i], _rectanglesP[j]))
                    {
                        canvasPanel.Controls[i].BackColor = System.Drawing.Color.LightPink;
                        canvasPanel.Controls[j].BackColor = System.Drawing.Color.LightPink;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private static Panel InitPanel(Rectangle rectangle)
        {
            Panel rectanglePanel = new();
            rectanglePanel.Width = (int)rectangle.Width;
            rectanglePanel.Height = (int)rectangle.Heigth;
            rectanglePanel.Location = new(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            return rectanglePanel;
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = rectanglesPanelListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            rectanglesPanelListBox.Items[index] = string.Format(
                    "{0}:(X={1}; Y={2}; W={3}; H={4})", rectangle.Id,
                    rectangle.Center.X,
                    rectangle.Center.Y,
                    rectangle.Width,
                    rectangle.Heigth);
        }

        private void ClearRectangleInfo()
        {
            idPanelTextBox.Clear();
            xPanelTextBox.Clear();
            yPanelTextBox.Clear();
            widthPanelTextBox.Clear();
            heigthPanelTextBox.Clear();
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedItem == null) return;
            _currentPanelRectangle = _rectanglesP[rectanglesPanelListBox.SelectedIndex];
            idPanelTextBox.Text = _currentPanelRectangle.Id.ToString();
            xPanelTextBox.Text = _currentPanelRectangle.Center.X.ToString();
            yPanelTextBox.Text = _currentPanelRectangle.Center.Y.ToString();
            widthPanelTextBox.Text = _currentPanelRectangle.Width.ToString();
            heigthPanelTextBox.Text = _currentPanelRectangle.Heigth.ToString();
        }

        private void AddButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            _currentPanelRectangle = RectangleFactory.Randomazie(canvasPanel.Size.Width, canvasPanel.Size.Height);
            _rectanglesP.Add(_currentPanelRectangle);
            rectanglesPanelListBox.Items.Add(string.Format(
                    "{0}:(X={1}; Y={2}; W={3}; H={4})", _currentPanelRectangle.Id,
                    _currentPanelRectangle.Center.X,
                    _currentPanelRectangle.Center.Y,
                    _currentPanelRectangle.Width,
                    _currentPanelRectangle.Heigth));
            Panel panel = InitPanel(_currentPanelRectangle);
            _rectanglePanels.Add(panel);
            canvasPanel.Controls.Add(panel);
            rectanglesPanelListBox.SelectedIndex = _rectanglesP.Count - 1;
            FindCollisions();
        }

        private void RemoveButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (rectanglesPanelListBox.SelectedItem == null) return;
            int index = rectanglesPanelListBox.SelectedIndex;
            _rectanglesP.RemoveAt(index);
            rectanglesPanelListBox.Items.RemoveAt(index);
            rectanglesPanelListBox.ClearSelected();
            ClearRectangleInfo();
            canvasPanel.Controls.RemoveAt(index);
            _rectanglePanels.RemoveAt(index);
            FindCollisions();
        }

        private void XPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                _currentPanelRectangle.Center.X = Convert.ToInt32(xPanelTextBox.Text);
                xPanelTextBox.BackColor = System.Drawing.Color.White;

                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Location =
                    new System.Drawing.Point(_currentPanelRectangle.Center.X, _currentPanelRectangle.Center.Y);

                FindCollisions();
                UpdateRectangleInfo(_currentPanelRectangle);
            }
            catch
            {
                xPanelTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void YPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;
            try
            {
                _currentPanelRectangle.Center.Y = Convert.ToInt32(yPanelTextBox.Text);
                yPanelTextBox.BackColor = System.Drawing.Color.White;

                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Location =
                    new System.Drawing.Point(_currentPanelRectangle.Center.X, _currentPanelRectangle.Center.Y);

                FindCollisions();
                UpdateRectangleInfo(_currentPanelRectangle);
            }
            catch
            {
                yPanelTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void WidthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;
            try
            {
                _currentPanelRectangle.Width = Convert.ToDouble(widthPanelTextBox.Text);
                widthPanelTextBox.BackColor = System.Drawing.Color.White;

                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Width =
                    (int)_currentPanelRectangle.Width;

                FindCollisions();
                UpdateRectangleInfo(_currentPanelRectangle);
            }
            catch
            {
                widthPanelTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void HeigthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;
            try
            {
                _currentPanelRectangle.Heigth = Convert.ToDouble(heigthPanelTextBox.Text);
                heigthPanelTextBox.BackColor = System.Drawing.Color.White;

                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Height =
                    (int)_currentPanelRectangle.Heigth;

                FindCollisions();
                UpdateRectangleInfo(_currentPanelRectangle);
            }
            catch
            {
                heigthPanelTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }
    }
}