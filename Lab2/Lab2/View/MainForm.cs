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
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void Enums_Click(object sender, EventArgs e)
        {

        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            string selected = EnumsListBox.SelectedItem.ToString();
            string[] colour = Enum.GetNames(typeof(Colour));
            string[] company = Enum.GetNames(typeof(Company));
            string[] education = Enum.GetNames(typeof(Education));
            string[] genre = Enum.GetNames(typeof(Genre));
            string[] season = Enum.GetNames(typeof(Season));
            string[] weekday = Enum.GetNames(typeof(Weekday));
            switch (selected)
            {
                case "Colour":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(colour);
                    break;
                case "Company":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(company);
                    break;
                case "Education":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(education);
                    break;
                case "Genre":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(genre);
                    break;
                case "Season":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(season);
                    break;
                case "Weekday":
                    ValuesListBox.Items.Clear();
                    ValuesListBox.Items.AddRange(weekday);
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
