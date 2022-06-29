using Programming.Model.Geometry;
using Programming.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению и
    /// визуализации прямоугольников, с обработкой их пересечений.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new();

        /// <summary>
        /// Список прямоугольников на панели.
        /// </summary>
        private List<Panel> _rectanglesPanels = new();

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Зеленый цвет, когда есть коллизия.
        /// </summary>
        private readonly static System.Drawing.Color _rectanglesCollisionedColor =
            System.Drawing.Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Красный цвет, когда нет коллизии.
        /// </summary>
        private readonly static System.Drawing.Color _rectanglesNotCollisionedColor =
            System.Drawing.Color.LightPink;

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

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Создает прямоугольник.
        /// </summary>
        private string GetRectangleInfo(Rectangle rectangle)
        {
            string rectangleInfo = string.Format(
                    "{0}:(X={1}; Y={2}; W={3}; H={4})", rectangle.Id,
                    rectangle.Center.X,
                    rectangle.Center.Y,
                    rectangle.Width,
                    rectangle.Height);
            return rectangleInfo;
        }

        /// <summary>
        /// Иищет пересекающиеся прямоугольники и задает им цвет.
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                canvasPanel.Controls[i].BackColor = _rectanglesCollisionedColor;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        canvasPanel.Controls[i].BackColor = _rectanglesNotCollisionedColor;
                        canvasPanel.Controls[j].BackColor = _rectanglesNotCollisionedColor;
                    }

                    else
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Создает элемент типа panel из прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>
        /// Возвращает созданный элемент.
        /// </returns>
        private static Panel InitPanel(Rectangle rectangle)
        {
            Panel rectanglePanel = new();
            rectanglePanel.Width = (int)rectangle.Width;
            rectanglePanel.Height = (int)rectangle.Height;
            rectanglePanel.Location = new(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = _rectanglesCollisionedColor;
            return rectanglePanel;
        }

        /// <summary>
        /// Находит и обновляет переданный прямоугольник.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = rectanglesPanelListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            rectanglesPanelListBox.Items[index] = GetRectangleInfo(rectangle);
        }

        /// <summary>
        /// Очищает элемент TextBox.
        /// </summary>
        private void ClearRectangleInfo()
        {
            idPanelTextBox.Clear();
            xPanelTextBox.Clear();
            yPanelTextBox.Clear();
            widthPanelTextBox.Clear();
            heigthPanelTextBox.Clear();
        }

        private void AddButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_add_24x24;
        }

        private void AddButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_remove_24x24;
        }

        private void RemoveButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Resources.rectangle_remove_24x24_uncolor;
        }

        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedItem == null) return;

            _currentRectangle = _rectangles[rectanglesPanelListBox.SelectedIndex];
            idPanelTextBox.Text = _currentRectangle.Id.ToString();
            xPanelTextBox.Text = _currentRectangle.Center.X.ToString();
            yPanelTextBox.Text = _currentRectangle.Center.Y.ToString();
            widthPanelTextBox.Text = _currentRectangle.Width.ToString();
            heigthPanelTextBox.Text = _currentRectangle.Height.ToString();
        }

        private void AddButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            _currentRectangle =
                RectangleFactory.Randomize(canvasPanel.Size.Width, canvasPanel.Size.Height);
            _rectangles.Add(_currentRectangle);
            rectanglesPanelListBox.Items.Add(GetRectangleInfo(_currentRectangle));

            Panel panel = InitPanel(_currentRectangle);
            _rectanglesPanels.Add(panel);
            canvasPanel.Controls.Add(panel);
            rectanglesPanelListBox.SelectedIndex = _rectangles.Count - 1;
            FindCollisions();
        }

        private void RemoveButtonPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (rectanglesPanelListBox.SelectedItem == null) return;

            int index = rectanglesPanelListBox.SelectedIndex;
            _rectangles.RemoveAt(index);
            rectanglesPanelListBox.Items.RemoveAt(index);
            rectanglesPanelListBox.ClearSelected();
            ClearRectangleInfo();
            canvasPanel.Controls.RemoveAt(index);
            _rectanglesPanels.RemoveAt(index);
            FindCollisions();
        }

        private void XPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Center.X = Convert.ToInt32(xPanelTextBox.Text);
                xPanelTextBox.BackColor = _correctColor;
                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Location =
                    new System.Drawing.Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }

            catch
            {
                xPanelTextBox.BackColor = _rectanglesNotCollisionedColor;
                return;
            }
        }

        private void YPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Center.Y = Convert.ToInt32(yPanelTextBox.Text);
                yPanelTextBox.BackColor = _correctColor;
                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Location =
                    new System.Drawing.Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }

            catch
            {
                yPanelTextBox.BackColor = _rectanglesNotCollisionedColor;
                return;
            }
        }

        private void WidthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Width = Convert.ToDouble(widthPanelTextBox.Text);
                widthPanelTextBox.BackColor = _correctColor

                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Width =
                    (int)_currentRectangle.Width;

                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }

            catch
            {
                widthPanelTextBox.BackColor = _rectanglesNotCollisionedColor;
                return;
            }
        }

        private void HeightPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (rectanglesPanelListBox.SelectedIndex == -1) return;

            try
            {
                _currentRectangle.Height = Convert.ToDouble(heigthPanelTextBox.Text);
                heigthPanelTextBox.BackColor = _correctColor;
                canvasPanel.Controls[rectanglesPanelListBox.SelectedIndex].Height =
                    (int)_currentRectangle.Height;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }

            catch
            {
                heigthPanelTextBox.BackColor = _rectanglesNotCollisionedColor;
                return;
            }
        }
    }
}