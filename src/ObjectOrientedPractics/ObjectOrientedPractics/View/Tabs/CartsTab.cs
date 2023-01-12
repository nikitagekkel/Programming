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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        public List<Item> _items = new();
        public List<Customer> _customers = new();
        public Customer _curentCustomer;
        public Order _newOrder;
        public PriorityOrder _newPriorityOrder;

        public CartsTab()
        {
            InitializeComponent();
            priceLabel.Text = "0";
        }

        public void UpdateItemsListBox(int index)
        {
            itemsListBox.Items.Clear();
            foreach (var item in _items)
            {
                itemsListBox.Items.Add(item.Name);
            }
            if (-1 <= index && index < itemsListBox.Items.Count)
            {
                itemsListBox.SelectedIndex = index;
            }
        }

        public void UpdateCustomersComboBox()
        {
            customersComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                customersComboBox.Items.Add(customer.FullName);
            }    
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_curentCustomer != null &&
                itemsListBox.SelectedIndex != -1)
            {
                _curentCustomer.Items.Add(
                    _items[itemsListBox.SelectedIndex]);
                priceLabel.Text = _curentCustomer.Cart.Ammount.ToString();
                cartListBox.Items.Add(itemsListBox.SelectedItem);
            }
            itemsListBox.SelectedIndex = -1;
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartListBox.Items.Clear();
            if (customersComboBox.SelectedIndex != -1)
            {
                _curentCustomer = _customers[customersComboBox.SelectedIndex];
                foreach (var item in _curentCustomer.Items)
                {
                    cartListBox.Items.Add(item.Name);
                }
                priceLabel.Text = _curentCustomer.Cart.Ammount.ToString();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_curentCustomer != null &&
                cartListBox.SelectedIndex != -1)
            {
                int index = cartListBox.SelectedIndex;
                _curentCustomer.Items.RemoveAt(
                    index);
                cartListBox.Items.RemoveAt(index);
                priceLabel.Text = _curentCustomer.Cart.Ammount.ToString();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_curentCustomer != null &&
                _curentCustomer.Cart.Items != null)
            {
                if (_curentCustomer.IsPriority == true)
                {
                    _newPriorityOrder = new(
                        _curentCustomer.Cart.Ammount,
                        _curentCustomer.Adress,
                        _curentCustomer.Items,
                        DateTime.UtcNow,
                        _curentCustomer.FullName,
                        "");
                    _curentCustomer.Orders.Add(_newPriorityOrder);
                }    
                else
                {
                    _newOrder = new(
                        _curentCustomer.Cart.Ammount,
                        _curentCustomer.Adress,
                        _curentCustomer.Items,
                        DateTime.UtcNow,
                        _curentCustomer.FullName);
                    _curentCustomer.Orders.Add(_newOrder);
                    
                }
                cartListBox.Items.Clear();
            }
            priceLabel.Text = "0";
        }

        public void RefreshData()
        {
            UpdateCustomersComboBox();
            UpdateItemsListBox(-1);
        }

        private void ClearCartItem_Click(object sender, EventArgs e)
        {
            priceLabel.Text = "0";
            cartListBox.Items.Clear();
            itemsListBox.SelectedIndex = -1;
        }
    }
}
