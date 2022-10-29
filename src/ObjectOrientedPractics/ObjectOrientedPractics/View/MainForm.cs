using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private readonly List<Item> _items = new();
        private readonly List<Customer> _customers = new();
        public Store _store;
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
            customersTab.UpdateListBox(-1);
            itemsTab.UpdateListBox(-1);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ItemSerializer.Serialize(itemsTab._items);
            CustomerSerializer.Serialize(customersTab._customers);
        }
    }
}
