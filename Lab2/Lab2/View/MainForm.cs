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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var items = Enum.GetValues(typeof(MyEnums));
            foreach (var item in items)
            {
                EnumsListBox.Items.Add(item);
            }
            EnumsListBox.SelectedIndex = 0;

            var itemsbox = Enum.GetValues(typeof(Season));
            foreach (var item in itemsbox)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelparse.Text = "";
            
            switch ((MyEnums)EnumsListBox.SelectedItem)
            {
                case MyEnums.Colour:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colour));
                    break;
                case MyEnums.Company:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Company));
                    break;
                case MyEnums.Education:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Education));
                    break;
                case MyEnums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case MyEnums.Season:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case MyEnums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            textBox1.Text = ((int)item).ToString();
        }

        private void Parse_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(textBox2.Text, out weekday))
            {
                labelparse.Text = $"Это день недели ({weekday} = {(int)weekday})";
            }
            else
            {
                labelparse.Text = "Нет такого дня недели";
            }
            textBox2.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Season)comboBox1.SelectedItem)
            {
                case Season.Весна:
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Зима:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Лето:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Осень:
                    BackColor = System.Drawing.ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
        private void Enums_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelparse_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
