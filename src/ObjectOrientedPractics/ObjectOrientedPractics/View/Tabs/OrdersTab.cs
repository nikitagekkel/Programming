using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public List<Customer> _customers = new();
        public List<Order> _orders = new();
        public Order _curentOrder;
        PriorityOrder _selectedPriorityOrder;
        private readonly string[] _deliveryTime =
{
            "9:00 - 11:00",
            "11:00 - 13:00",
            "13:00 - 15:00",
            "15:00 - 17:00",
            "17:00 - 19:00",
            "19:00 - 21:00"
        };
        public OrdersTab()
        {
            InitializeComponent();

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

        public void UpdateOrders()
        {
            _orders.Clear();
            ordersDataGridView.Rows.Clear();
            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    _orders.Add(order);
                }
            }
            for (int i = 0; i < _orders.Count; i++)
            {
                ordersDataGridView.Rows.Add();
                ordersDataGridView.Rows[i].Cells[0].Value = _orders[i].Id.ToString();
                ordersDataGridView.Rows[i].Cells[1].Value = _orders[i].CreationDate.ToString();
                ordersDataGridView.Rows[i].Cells[2].Value = _orders[i].FullName;
                ordersDataGridView.Rows[i].Cells[3].Value = _orders[i].Adress.Index.ToString();
                ordersDataGridView.Rows[i].Cells[4].Value = _orders[i].Ammount.ToString();
                ordersDataGridView.Rows[i].Cells[5].Value = _orders[i].Status.ToString();
            }
        }

        private void OrdersDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count > 0)
            {
                int index = ordersDataGridView.SelectedRows[0].Index;
                _curentOrder = _orders[index];
                idTextBox.Text = _curentOrder.Id.ToString();
                createdTextBox.Text = _curentOrder.CreationDate.ToString();
                statusComboBox.SelectedItem = _curentOrder.Status;
                adressControl.Adress = _curentOrder.Adress;
                adressControl.UpdateAdressTextBoxesInfo();
                itemsListBox.Items.Clear();
                foreach(Item item in _curentOrder.Items)
                {
                    itemsListBox.Items.Add(item.Name);
                }

                if (_curentOrder is PriorityOrder)
                {
                    _selectedPriorityOrder = (PriorityOrder)_curentOrder;
                    priorityOrderPanel.Visible= true;
                    deliveryTimeComboBox.SelectedItem = _selectedPriorityOrder.DeliveryTime;
                }
                else
                {
                    priorityOrderPanel.Visible = false;
                }
            }
        }

        private void StatusComboBox_DropDownClosed(object sender, EventArgs e)
        {
            _curentOrder.Status = (OrderStatus)statusComboBox.SelectedItem;
            int index = ordersDataGridView.SelectedRows[0].Index;
            UpdateOrders();
            ordersDataGridView.Rows[index].Selected = true;
        }

        private void DeliveryTimeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            _selectedPriorityOrder.DeliveryTime = (string)deliveryTimeComboBox.SelectedItem;
        }
    }
}
