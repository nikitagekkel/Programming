using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Хранит список покупателей
        /// </summary>
        public List<Customer> _customers = new();

        /// <summary>
        /// Хранит список заказов
        /// </summary>
        public List<PriorityOrder> _orders = new();

        /// <summary>
        /// Хранит данные о выбранном текущем заказе
        /// </summary>
        public PriorityOrder _curentOrder;

        /// <summary>
        /// Хранит данные о случайно выбранном покупателе
        /// </summary>
        public Customer _randomCustomer;

        /// <summary>
        /// Хранит время доставки заказа
        /// </summary>
        private readonly string[] _deliveryTime =
{
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };
        public PriorityOrdersTab()
        {
            InitializeComponent();

            priceLabel.Text = "0";

            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statuses)
            {
                statusComboBox.Items.Add(status);
            }
            foreach (var time in _deliveryTime)
            {
                deliveryTimeComboBox.Items.Add(time);
            }
        }
        
        /// <summary>
        /// Обновляет данные о заказах в ItemsListBox
        /// </summary>
        public void UpdateOrders()
        {
            foreach (Item item in _curentOrder.Items)
            {
                itemsListBox.Items.Add(item.Name);
            }
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (_customers.Count > 0)
            {
                Random rnd = new();
                int randIndex = rnd.Next(_customers.Count);
                _randomCustomer = _customers[randIndex];

                _curentOrder = new PriorityOrder(_randomCustomer.Cart.Ammount,
                    _randomCustomer.Adress,
                    _randomCustomer.Items,
                    DateTime.UtcNow,
                    _randomCustomer.FullName,
                    (string)deliveryTimeComboBox.SelectedItem);
                _orders.Add(_curentOrder);
                UpdateOrders();
                itemsListBox.SelectedIndex = -1;
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = itemsListBox.SelectedIndex;
            if (index != -1)
            {
                _curentOrder = _orders[index];
                idTextBox.Text = _curentOrder.Id.ToString();
                createdTextBox.Text = _curentOrder.CreationDate.ToString();
                statusComboBox.SelectedItem = _curentOrder.Status;
                adressControl.Adress = _curentOrder.Adress;
                deliveryTimeComboBox.SelectedItem = _curentOrder.DeliveryTime;
                adressControl.UpdateAdressTextBoxesInfo();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int index = itemsListBox.SelectedIndex;
            if (index != -1)
            {
                _orders.RemoveAt(index);
                itemsListBox.Items.RemoveAt(index);
                if (index + 1 < itemsListBox.Items.Count)
                {
                    itemsListBox.SelectedIndex = index + 1;
                }
                else if (itemsListBox.Items.Count == 0)
                {
                    itemsListBox.SelectedIndex = -1;
                }
                else
                {
                    itemsListBox.SelectedIndex = itemsListBox.Items.Count - 1;
                }
            }
        }

        private void ClearOrderItem_Click(object sender, EventArgs e)
        {
            _orders.Clear();
            _curentOrder = null;
            itemsListBox.Items.Clear();
        }

        private void DeliveryTimeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (_curentOrder != null)
            {
                _curentOrder.DeliveryTime = (string)deliveryTimeComboBox.SelectedItem;
            }
        }

        private void StatusComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (itemsListBox != null)
            {
                if (_curentOrder != null)
                {
                    _curentOrder.Status = (OrderStatus)statusComboBox.SelectedItem;
                }
            }

        }
    }
}
