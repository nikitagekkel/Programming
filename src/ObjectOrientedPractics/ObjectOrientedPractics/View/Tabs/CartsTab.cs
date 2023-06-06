using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Хранит список товаров
        /// </summary>
        public List<Item> _items = new();

        /// <summary>
        /// Хранит список покупателей
        /// </summary>
        public List<Customer> _customers = new();

        /// <summary>
        /// Хранит значение текущего выбранного покупателя
        /// </summary>
        public Customer _curentCustomer;

        /// <summary>
        /// Хранит значение текущего выбранного заказа
        /// </summary>
        public Order _newOrder;

        /// <summary>
        /// Хранит значение текущего выбранного приоритетного заказа
        /// </summary>
        public PriorityOrder _newPriorityOrder;

        public CartsTab()
        {
            InitializeComponent();
            priceLabel.Text = "0";
        }

        /// <summary>
        /// Обновляет данные элемента ItemsListBox
        /// </summary>
        /// <param name="index">Индекс фокусировки на элементе</param>
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

        /// <summary>
        /// Обновляет данные элемента CustomersComboBox
        /// </summary>
        public void UpdateCustomersComboBox()
        {
            customersComboBox.Items.Clear();
            foreach (var customer in _customers)
            {
                customersComboBox.Items.Add(customer.FullName);
            }    
        }

        /// <summary>
        /// Обновляет данные о скидке на корзину
        /// </summary>
        private void UpdateDiscountDigit()
        {
            double discountAmount = 0;
            for (int i = 0; i < discountsListBox.Items.Count; i++)
            {
                if (discountsListBox.GetItemChecked(i))
                {
                    discountAmount += _curentCustomer.Discounts[i].Calculate(_curentCustomer.Cart.Items);
                }
            }
            discountsListBox.Text = discountAmount.ToString();
            if (_curentCustomer.Cart.Ammount == 0)
            {
                totalPriceLabel.Text = _curentCustomer.Cart.Ammount.ToString();
                discountAmmountPriceLabel.Text = discountAmount.ToString();
                return;
            }
            totalPriceLabel.Text = (_curentCustomer.Cart.Ammount - discountAmount).ToString();
            discountAmmountPriceLabel.Text = discountAmount.ToString();
        }

        /// <summary>
        /// Обновляет элемент DiscountCheckedListBox
        /// </summary>
        private void UpdateDiscountCheckedListBox()
        {
            discountsListBox.Items.Clear();
            if (_curentCustomer != null &&
                _curentCustomer.Discounts.Count > 0)
            {
                foreach (var discount in _curentCustomer.Discounts)
                {
                    discountsListBox.Items.Add(discount.Info, true);
                }
            }
        }

        /// <summary>
        /// Очищает все цены на форме
        /// </summary>
        public void UpdatePrices()
        {
            priceLabel.Text = "0";
            discountAmmountPriceLabel.Text = "0";
            totalPriceLabel.Text = "0";
        }

        /// <summary>
        /// Обновляет все обновляемые данные на форме
        /// </summary>
        public void RefreshData()
        {
            UpdateCustomersComboBox();
            UpdateDiscountCheckedListBox();
            UpdateItemsListBox(-1);
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
                UpdateDiscountDigit();
            }
            itemsListBox.SelectedIndex = -1;
        }

        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cartListBox.Items.Clear();
            if (customersComboBox.SelectedIndex != -1)
            {
                _curentCustomer = _customers[customersComboBox.SelectedIndex];
                UpdateDiscountCheckedListBox();
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
                UpdateDiscountDigit();
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (_curentCustomer != null &&
                _curentCustomer.Cart.Items != null)
            {
                double discountAmount = 0;
                for (int i = 0; i < discountsListBox.Items.Count; i++)
                {
                    if (discountsListBox.GetItemChecked(i))
                    {
                        discountAmount +=
                            _curentCustomer.Discounts[i].Calculate(_curentCustomer.Cart.Items);
                    }
                }

                if (_curentCustomer.IsPriority == true)
                {
                    _newPriorityOrder = new(
                        _curentCustomer.Cart.Ammount - discountAmount,
                        _curentCustomer.Adress,
                        _curentCustomer.Items,
                        DateTime.UtcNow,
                        _curentCustomer.FullName,
                        "");
                    _newPriorityOrder.DiscountAmount = discountAmount;
                    _curentCustomer.Orders.Add(_newPriorityOrder);
                }    
                else
                {
                    _newOrder = new(
                        _curentCustomer.Cart.Ammount - discountAmount,
                        _curentCustomer.Adress,
                        _curentCustomer.Items,
                        DateTime.UtcNow,
                        _curentCustomer.FullName);
                    _newOrder.DiscountAmount = discountAmount;
                    _curentCustomer.Orders.Add(_newOrder);
                }

                for (int i = 0; i < discountsListBox.Items.Count; i++)
                {
                    if (discountsListBox.GetItemChecked(i))
                    {
                        _curentCustomer.Discounts[i].Apply(_curentCustomer.Cart.Items);
                    }
                    _curentCustomer.Discounts[i].Update(_curentCustomer.Cart.Items);
                }
                UpdateDiscountCheckedListBox();
                cartListBox.Items.Clear();
            }
            UpdatePrices();
        }

        private void ClearCartItem_Click(object sender, EventArgs e)
        {
            UpdatePrices();
            cartListBox.Items.Clear();
            itemsListBox.SelectedIndex = -1;
        }

        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountDigit();
        }
    }
}
