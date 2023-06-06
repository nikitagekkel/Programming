using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Хранит данные о скидке
        /// </summary>
        public PercentDiscount PercentDiscount { get; set; }

        /// <summary>
        /// Добавляет категории скидок в форму
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            var categoryValues = Enum.GetValues(typeof(Category));
            foreach (var value in categoryValues)
            {
                categoryComboBox.Items.Add(value);
            }
            categoryComboBox.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex == -1)
            {
                return;
            }

            PercentDiscount = new PercentDiscount((Category)categoryComboBox.SelectedIndex);
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
