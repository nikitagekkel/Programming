using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private Item _currentItem;

        /// <summary>
        /// Цвет фона строки без ошибок.
        /// </summary>
        private Color _correctColor = Color.White;

        /// <summary>
        /// Цвет фона строки с ошибками.
        /// </summary>
        private Color _errorColor = Color.LightPink;

        public List<Item> _items = new();

        public ItemsTab()
        {
            InitializeComponent();
            _items = ItemSerializer.Deserialize();
            UpdateListBox(-1);
        }

        private void UpdateListBox(int index)
        {
            List<Item> items = _items;
            itemsListBox.Items.Clear();
            foreach (var item in items)
            {
                itemsListBox.Items.Add(item.Name);
            }
            if (-1 <= index && index < itemsListBox.Items.Count)
            {
                itemsListBox.SelectedIndex = index;
            }
        }

        private void UpdateTextBoxesInfo(Item item)
        {
            idTextBox.Text = item.Id.ToString();
            costTextBox.Text = item.Cost.ToString();
            nameTextBox.Text = item.Name;
            infoTextBox.Text = item.Info;
        }

        private void ClearTextBoxes()
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                idTextBox.Clear();
                costTextBox.Clear();
                nameTextBox.Clear();
                infoTextBox.Clear();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("none", "none", 0);
            _items.Add(_currentItem);
            UpdateListBox(_items.IndexOf(_currentItem));
            UpdateTextBoxesInfo(_currentItem);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _currentItem = _items[itemsListBox.SelectedIndex];
            UpdateTextBoxesInfo(_currentItem);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (itemsListBox.Items.Count == 0) return;

            int index = itemsListBox.SelectedIndex;
            if (index == -1) return;

            _items.RemoveAt(index);
            itemsListBox.Items.RemoveAt(index);
            ClearTextBoxes();
            costTextBox.BackColor = _correctColor;
            nameTextBox.BackColor = _correctColor;
            infoTextBox.BackColor = _correctColor;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Convert.ToDouble(costTextBox.Text);
                costTextBox.BackColor = _correctColor;
            }
            catch(Exception ex)
            {
                costTextBox.BackColor = _errorColor;
                costToolTip.SetToolTip(costTextBox, ex.Message);
                if (_items.Count == 0)
                {
                    costTextBox.BackColor = _correctColor;
                }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = nameTextBox.Text;
                nameTextBox.BackColor = _correctColor;
                UpdateListBox(_items.IndexOf(_currentItem));
            }
            catch
            {
                nameTextBox.BackColor = _errorColor;
            }
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = infoTextBox.Text;
                infoTextBox.BackColor = _correctColor;
            }
            catch
            {
                infoTextBox.BackColor = _errorColor;
            }
        }
    }
}
