using Lab8.Model;

namespace Lab8.View.Forms
{
    public partial class MainForm : Form
    {
        public Contact _contact = new(
            "",
            "",
            "");
        SecondaryForm firstSecondaryForm = new();
        SecondaryForm secondSecondaryForm = new();
        public MainForm()
        {
            InitializeComponent();
            firstSecondaryForm.Show();
            secondSecondaryForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Dispose();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.FullName = fullNameTextBox.Text;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.PhoneNumber = phoneNumberTextBox.Text;
        }

        private void AdressTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.Adress = adressTextBox.Text;
        }

        private void Contact_ContactChanged(object sender, EventArgs e)
        {
            firstSecondaryForm._contact = _contact;
            secondSecondaryForm._contact = _contact;
        }
    }
}
