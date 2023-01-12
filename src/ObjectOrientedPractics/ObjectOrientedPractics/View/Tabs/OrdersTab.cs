using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public List<Customer> _customers = new();
        public List<Order> _orders = new();
        public Order _curentOrder;

        public OrdersTab()
        {
            InitializeComponent();

            var statuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in statuses)
            {
                statusComboBox.Items.Add(status);
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
            }
        }

        private void statusComboBox_DropDownClosed(object sender, EventArgs e)
        {
            _curentOrder.Status = (OrderStatus)statusComboBox.SelectedItem;
            int index = ordersDataGridView.SelectedRows[0].Index;
            UpdateOrders();
            ordersDataGridView.Rows[index].Selected = true;
        }
    }
}
