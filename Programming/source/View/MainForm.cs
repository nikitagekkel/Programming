using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Model;

namespace Lab2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            var items = Enum.GetValues(typeof(Enums));
            foreach (var item in items)
            {
                listBoxEnums.Items.Add(item);
            }

            listBoxEnums.SelectedIndex = 0;

            var itemsbox = Enum.GetValues(typeof(Season));
            foreach (var item in itemsbox)
            {
                comboBoxSeason.Items.Add(item);
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelParse.Text = "";
            switch ((Enums)listBoxEnums.SelectedItem)
            {
                case Model.Enums.Colour:
                    listBoxValues.DataSource = Enum.GetValues(typeof(Colour));
                    break;
                case Model.Enums.Company:
                    listBoxValues.DataSource = Enum.GetValues(typeof(Company));
                    break;
                case Model.Enums.Education:
                    listBoxValues.DataSource = Enum.GetValues(typeof(Education));
                    break;
                case Model.Enums.Genre:
                    listBoxValues.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Model.Enums.Season:
                    listBoxValues.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case Model.Enums.Weekday:
                    listBoxValues.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBoxValues.SelectedItem;
            textBoxIntValue.Text = ((int)item).ToString();
        }

        private void Button_parse_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(textBoxParsing.Text, out weekday))
            {
                labelParse.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }
            else
            {
                labelParse.Text = "Нет такого дня недели";
            }
            textBoxParsing.Text = "";
        }

        private void Button_season_handle_Click(object sender, EventArgs e)
        {
            switch ((Season)comboBoxSeason.SelectedItem)
            {
                case Season.Spring:
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}
