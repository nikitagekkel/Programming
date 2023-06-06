using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список всех товаров
        /// </summary>
        private readonly List<Item> _items = new();

        /// <summary>
        /// Список всех покупателей
        /// </summary>
        private readonly List<Customer> _customers = new();

        private readonly Store _store;

        /// <summary>
        /// Реализует загрузку главной формы и
        /// десериализацию обьектов в класс
        /// <see cref="Store"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _items = ItemSerializer.Deserialize();
            _customers = CustomerSerializer.Deserialize();
            _store = new(_items, _customers);
            customersTab._customers = _store.Customers;
            itemsTab._items = _store.Items;
            cartsTab._customers = _store.Customers;
            cartsTab._items = _store.Items;
            ordersTab._customers = _store.Customers;
            priorityOrdersTab._customers = _store.Customers;

            customersTab.UpdateListBox(-1);
            itemsTab.UpdateListBox(-1);
            cartsTab.UpdateItemsListBox(-1);
            cartsTab.UpdateCustomersComboBox();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ItemSerializer.Serialize(itemsTab._items);
            CustomerSerializer.Serialize(customersTab._customers);
        }

        private void SelectedTabChanged(object sender, System.EventArgs e)
        {
            if (tabControl.SelectedIndex != -1)
            {
                //cartsTab.RefreshData();
                //ordersTab.UpdateOrders();
            }
        }

        private void ItemsTab_ItemsChanged(object sender, System.EventArgs e)
        {
            cartsTab.RefreshData();
            ordersTab.UpdateOrders();
        }
    }
}
