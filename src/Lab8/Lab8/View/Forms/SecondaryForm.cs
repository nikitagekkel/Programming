using Lab8.Model;

namespace Lab8.View.Forms
{
    public partial class SecondaryForm : Form
    {
        public Contact _contact = new(
            "",
            "",
            "");
        public SecondaryForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            SecondaryForm.ActiveForm.Dispose();
        }
    }
}
