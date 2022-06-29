using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению прямоугольников.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new();

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Цвет фона без ошибок.
        /// </summary>
        private System.Drawing.Color _correctColor =
            System.Drawing.Color.White;

        /// <summary>
        /// Цвет фона с ошибками.
        /// </summary>
        private System.Drawing.Color _errorColor = 
            System.Drawing.Color.LightPink;

        /// <summary>
        /// Создает прямоугольники и добавляет их в элемент ListBox.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                _rectangles.Add(RectangleFactory.Randomize(100, 100));
            }

            foreach (Rectangle rectangle in _rectangles)
            {
                rectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
            }
        }

        /// <summary>
        /// Ищет в списке прямоугольников элемент, с наибольшей шириной.
        /// </summary>
        /// <returns>
        /// Возвращает индекс найденного элемента.
        /// </returns>
        private int FindRectangleWithMaxWidth()
        {
            double maxWidth = 0;
            int maxIndex = 0;

            foreach (Rectangle rectangle in _rectangles)
            {
                if (rectangle.Width > maxWidth)
                {
                    maxWidth = rectangle.Width;
                    maxIndex = _rectangles.IndexOf(rectangle);
                }
            }

            return maxIndex;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[rectanglesListBox.SelectedIndex];
            heigthRectangleTextBox.Text = _currentRectangle.Height.ToString();
            widthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            colorRectangleTextBox.Text = _currentRectangle.Color;
            idRectangleTextBox.Text = _currentRectangle.Id.ToString();
            XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
            YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
        }

        private void HeigthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Height = Convert.ToDouble(heigthRectangleTextBox.Text);
                heigthRectangleTextBox.BackColor = _correctColor;
            }
            catch
            {
                heigthRectangleTextBox.BackColor = _errorColor;
            }
        }

        private void WidthRectangleTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(widthRectangleTextBox.Text);
                widthRectangleTextBox.BackColor = _correctColor;
            }
            catch
            {
                widthRectangleTextBox.BackColor = _errorColor;
            }
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            rectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }
    }
}
