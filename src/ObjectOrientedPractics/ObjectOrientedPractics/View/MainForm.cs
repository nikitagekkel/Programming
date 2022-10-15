using ObjectOrientedPractics.Services;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Реализует обработку главной формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ItemSerializer.Serialize(itemsTab._items);
            CustomerSerializer.Serialize(customersTab._customers);
        }
    }
}
