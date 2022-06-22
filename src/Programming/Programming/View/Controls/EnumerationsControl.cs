using Programming.Model.Enums;
using System;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению перечислений.
    /// </summary>
    public partial class EnumerationsControl : UserControl
    {
        /// <summary>
        /// Добавляет элементы перечисления в элемент ListBox.
        /// </summary>
        public EnumerationsControl()
        {
            InitializeComponent();

            var enumEnumeration = Enum.GetValues(typeof(Enums));
            foreach (var item in enumEnumeration)
            {
                enumsListBox.Items.Add(item);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void EnumerationControl_Load(object sender, EventArgs e)
        {

        }
    }
}
