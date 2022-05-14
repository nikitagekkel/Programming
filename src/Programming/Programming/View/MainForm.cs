using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Clases;
using System.Collections.Generic;

namespace Programming
{
    public partial class MainForm : Form
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;
        
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
                Array colors = Enum.GetValues(typeof(Colour));
                Colour randomColor = (Colour)colors.GetValue(rnd.Next(colors.Length));
                _currentRectangle = new Rectangle(newHeight, newWidth, randomColor.ToString());
                _rectangles.Add(_currentRectangle);
            }
            
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
            RectanglesListBox.DataSource = _rectangles;
        }
    }
}