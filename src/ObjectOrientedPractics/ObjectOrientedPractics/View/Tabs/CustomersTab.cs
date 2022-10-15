﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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
        /// Реализует обработку формы, десериализацию экземпляра класса <see cref="Customer"/>
        /// и функцию <see cref="UpdateListBox(int)"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            _customers = CustomerSerializer.Deserialize();
            UpdateListBox(-1);
        }

        /// <summary>
        /// Добавляет все поля <see cref="Customer.FullName"/>
        /// элемента списка <see cref="_customers"/>
        /// в <see cref="customersListBox"/>
        /// и фокусирует элемент индекса <see cref="Index"/>
        /// </summary>
        /// <param name="index">Индекс фокусируемого элемента</param>
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
            adressTextBox.Text = customer.Adress;
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