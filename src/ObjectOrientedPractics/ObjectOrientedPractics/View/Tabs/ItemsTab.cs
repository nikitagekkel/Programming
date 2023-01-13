using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие, возникающее при смене товаров
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Цвет фона строки не содержащую ошибку
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет фона строки содержащую ошибки
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Текущий выбранный товар
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Список предметов
        /// </summary>
        public List<Item> _items = new();

        /// <summary>
        /// Реализует обработку формы, десериализацию экземпляра класса <see cref="Item"/>
        /// и функцию <see cref="UpdateListBox(int)"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                categoryComboBox.Items.Add(category);
            }
            categoryComboBox.SelectedItem = null;
        }

        /// <summary>
        /// Добавляет все поля <see cref="Item.Name"/>
        /// списка <see cref="_items"/>
        /// в <see cref="itemsListBox"/>
        /// и фокусирует элемент индекса <see cref="Index"/>
        /// </summary>
        /// <param name="index">Индекс фокусируемого элемента</param>
        public void UpdateListBox(int index)
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

        /// <summary>
        /// Обновляет все элементы типа <see cref="TextBox"/>,
        /// добавляя в них текст из полей переданного элемента
        /// <see cref="Item"/>
        /// </summary>
        /// <param name="item">Элемент класса <see cref="Item"/></param>
        private void UpdateBoxesInfo(Item item)
        {
            idTextBox.Text = item.Id.ToString();
            costTextBox.Text = item.Cost.ToString();
            nameTextBox.Text = item.Name;
            infoTextBox.Text = item.Info;
            categoryComboBox.SelectedItem = item.Category;
        }

        /// <summary>
        /// Удаляет текст из всех элементов формы
        /// типа <see cref="TextBox"/>
        /// </summary>
        private void ClearTextBoxes()
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                idTextBox.Clear();
                costTextBox.Clear();
                nameTextBox.Clear();
                infoTextBox.Clear();
                categoryComboBox.SelectedItem = Category.None;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("None", "None", 0, Category.None);
            _items.Add(_currentItem);
            UpdateListBox(_items.IndexOf(_currentItem));
            UpdateBoxesInfo(_currentItem);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _currentItem = _items[itemsListBox.SelectedIndex];
            UpdateBoxesInfo(_currentItem);
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
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Convert.ToDouble(costTextBox.Text);
                costTextBox.BackColor = _correctColor;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                costTextBox.BackColor = _errorColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = nameTextBox.Text;
                nameTextBox.BackColor = _correctColor;
                UpdateListBox(_items.IndexOf(_currentItem));
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                infoTextBox.BackColor = _errorColor;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentItem.Category = (Category)categoryComboBox.SelectedItem;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
