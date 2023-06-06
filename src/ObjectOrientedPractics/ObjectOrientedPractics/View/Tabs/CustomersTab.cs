using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.View.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private Customer _currentCustomer;

        /// <summary>
        /// Цвет фона строки не содержащую ошибку
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет фона строки содержащую ошибку
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Список покупателей
        /// </summary>
        public List<Customer> _customers = new();

        /// <summary>
        /// Реализует обработку элемента Control
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляет все поля <see cref="Customer.FullName"/>
        /// элемента списка <see cref="_customers"/>
        /// в <see cref="customersListBox"/>
        /// и фокусирует элемент индекса <see cref="Index"/>
        /// </summary>
        /// <param name="index">Индекс фокусируемого элемента</param>
        public void UpdateListBox(int index)
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

        /// <summary>
        /// Обновляет все элементы типа <see cref="TextBox"/>,
        /// добавляя в них текст из полей переданного элемента
        /// <see cref="Customer"/>
        /// </summary>
        /// <param name="customer">Элемент класса <see cref="Customer"/></param>
        private void UpdateTextBoxesInfo(Customer customer)
        {
            idTextBox.Text = customer.Id.ToString();
            fullNameTextBox.Text = customer.FullName;
            adressControl.Adress = customer.Adress;
            adressControl.UpdateAdressTextBoxesInfo();
        }

        /// <summary>
        /// Обновляет элемент DiscountsListBox
        /// </summary>
        private void UpdateDiscountsListBox()
        {
            discountsListBox.Items.Clear();

            foreach (var discount in _currentCustomer.Discounts)
            {
                discountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Удаляет текст из всех элементов формы
        /// типа <see cref="TextBox"/>
        /// </summary>
        private void ClearTextBoxes()
        {
            if (customersListBox.SelectedIndex == -1)
            {
                idTextBox.Clear();
                fullNameTextBox.Clear();
                adressControl.ClearTextBoxes();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Adress _newAdress = new(0, "None", "None", "None", "None", "None");
            adressControl.Adress = _newAdress;
            List<Item> _items = new();
            List<Order> _orders = new();
            bool isPriority = false;
            if (isPriorityCheckBox.Checked)
            {
                isPriority = true;
            }
            _currentCustomer = new Customer(_items, _orders, "none", 
                _newAdress, isPriority);
            _customers.Add(_currentCustomer);
            UpdateListBox(_customers.IndexOf(_currentCustomer));
            UpdateTextBoxesInfo(_currentCustomer);
            adressControl.UpdateAdressTextBoxesInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customersListBox.SelectedIndex == -1)
            {
                return;
            }

            _currentCustomer = _customers[customersListBox.SelectedIndex];
            adressControl.Adress = _currentCustomer.Adress;
            if (_currentCustomer.IsPriority)
            {
                isPriorityCheckBox.Checked = true;
            }
            else
            {
                isPriorityCheckBox.Checked = false;
            }
            UpdateTextBoxesInfo(_currentCustomer);
            adressControl.UpdateAdressTextBoxesInfo();
            UpdateDiscountsListBox();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (customersListBox.Items.Count == 0) return;

            int index = customersListBox.SelectedIndex;
            if (index == -1) return;

            _customers.RemoveAt(index);
            customersListBox.Items.RemoveAt(index);
            ClearTextBoxes();
            adressControl.ClearTextBoxes();
            fullNameTextBox.BackColor = _correctColor;
            adressControl.SetCorrectColor();
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

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                if (isPriorityCheckBox.Checked == true)
                {
                    _currentCustomer.IsPriority = true;
                }
                else
                {
                    _currentCustomer.IsPriority = false;
                }
            }
            
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscountForm = new();
            if (addDiscountForm.ShowDialog() == DialogResult.OK)
            {
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PointsDiscount) continue;
                    if (((PercentDiscount)discount).Category ==
                        addDiscountForm.PercentDiscount.Category) return;
                }
                _currentCustomer.Discounts.Add(addDiscountForm.PercentDiscount);
                UpdateDiscountsListBox();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            int index = discountsListBox.SelectedIndex;
            if (index == -1) return;
            if (index == 0) return;
            _currentCustomer.Discounts.RemoveAt(index);
            UpdateDiscountsListBox();
        }
    }
}
