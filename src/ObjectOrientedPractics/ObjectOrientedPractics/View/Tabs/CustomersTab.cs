using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private Customer _currentCustomer;

        /// <summary>
        /// Цвет фона строки без ошибок.
        /// </summary>
        private Color _correctColor = Color.White;

        /// <summary>
        /// Цвет фона строки с ошибками.
        /// </summary>
        private Color _errorColor = Color.LightPink;

        public List<Customer> _customers = new();
        public CustomersTab()
        {
            InitializeComponent();
            _customers = CustomerSerializer.Deserialize();
            UpdateListBox(-1);
        }

        private void UpdateListBox(int index)
        {
            List<Customer> customers = _customers;
            customersListBox.Items.Clear();
            foreach (var customer in customers)
            {
                customersListBox.Items.Add(customer.FullName);
            }
            if (-1 <= index && index < customersListBox.Items.Count)
            {
                customersListBox.SelectedIndex = index;
            }
        }

        private void UpdateTextBoxesInfo(Customer customer)
        {
            idTextBox.Text = customer.Id.ToString();
            fullNameTextBox.Text = customer.FullName;
            adressTextBox.Text = customer.Adress;
        }

        private void ClearTextBoxes()
        {
            if (customersListBox.SelectedIndex == -1)
            {
                idTextBox.Clear();
                fullNameTextBox.Clear();
                adressTextBox.Clear();
                adressTextBox.Clear();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer("none", "none");
            _customers.Add(_currentCustomer);
            UpdateListBox(_customers.IndexOf(_currentCustomer));
            UpdateTextBoxesInfo(_currentCustomer);
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex == -1)
            {
                return;
            }

            _currentCustomer = _customers[customersListBox.SelectedIndex];
            UpdateTextBoxesInfo(_currentCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.Items.Count == 0) return;

            int index = customersListBox.SelectedIndex;
            if (index == -1) return;

            _customers.RemoveAt(index);
            customersListBox.Items.RemoveAt(index);
            ClearTextBoxes();
            fullNameTextBox.BackColor = _correctColor;
            adressTextBox.BackColor = _correctColor;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.FullName = fullNameTextBox.Text;
                fullNameTextBox.BackColor = _correctColor;
                UpdateListBox(_customers.IndexOf(_currentCustomer));
            }
            catch
            {
                fullNameTextBox.BackColor = _errorColor;
            }
        }

        private void AdressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Adress = adressTextBox.Text;
                adressTextBox.BackColor = _correctColor;
            }
            catch
            {
                adressTextBox.BackColor = _errorColor;
            }
        }
    }
}
