using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по парсингу дня недели.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse(parsingTextBox.Text, out Weekday weekday) && (int)weekday <= 7)
            {
                parseLabel.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }

            else
            {
                parseLabel.Text = "Нет такого дня недели";
            }

            parsingTextBox.Text = "";
        }
    }
}
