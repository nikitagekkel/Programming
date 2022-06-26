using BooksApp.Model.Enumerations;
using BooksApp.Properties;
using System;
using System.Windows.Forms;

namespace Separate_Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var genres = Enum.GetValues(typeof(Genre));
            foreach (var genre in genres)
            {
                genreComboBox.Items.Add(genre);
            }
        }

        private void AddButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.add_24x24;
        }

        private void AddButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.add_24x24_uncolor;
        }

        private void RemoveButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.remove_24x24;
        }

        private void RemoveButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.remove_24x24_uncolor;
        }
    }
}
