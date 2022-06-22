using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению
    /// перечисления времен года.
    /// </summary>
    public partial class SeansonHandleControl : UserControl
    {
        /// <summary>
        /// Добавление элементов перечисления времен года в элемент comboBox.
        /// </summary>
        public SeansonHandleControl()
        {
            InitializeComponent();

            var seasons = Enum.GetValues(typeof(Season));
            foreach (var season in seasons)
            {
                seasonComboBox.Items.Add(season);
            }
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            switch ((Season)seasonComboBox.SelectedItem)
            {
                case Season.Spring:
                    MessageBox.Show("Ура! Тепло!");
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    MessageBox.Show("Красота! Золотая пора!");
                    break;
            }

            seasonComboBox.SelectedItem = null;
        }
    }
}
