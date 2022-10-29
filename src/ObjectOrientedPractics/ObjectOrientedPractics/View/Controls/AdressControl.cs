using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AdressControl : UserControl
    {
        /// <summary>
        /// Цвет фона строки не содержащую ошибку
        /// </summary>
        private readonly Color _correctColor = Color.White;

        /// <summary>
        /// Цвет фона строки содержащую ошибки
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        private Adress _adress;

        public Adress Adress
        {
            get
            {
                return _adress;
            }
            set
            {
                _adress = value;
            }
        }

        public AdressControl()
        {
            InitializeComponent();
        }
        public void UpdateAdressTextBoxesInfo()
        {
            postIndexTextBox.Text = _adress.Index.ToString();
            countyTextBox.Text = _adress.Country;
            cityTextBox.Text = _adress.City;
            streetTextBox.Text = _adress.Street;
            buildingTextBox.Text = _adress.Building;
            apartmentTextBox.Text = _adress.Apartment;
        }

        public void ClearTextBoxes()
        {
            postIndexTextBox.Clear();
            countyTextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            buildingTextBox.Clear();
            apartmentTextBox.Clear();
        }

        public void SetCorrectColor()
        {
            postIndexTextBox.BackColor = _correctColor;
            countyTextBox.BackColor = _correctColor;
            cityTextBox.BackColor = _correctColor;
            streetTextBox.BackColor = _correctColor;
            buildingTextBox.BackColor = _correctColor;
            apartmentTextBox.BackColor = _correctColor;
        }
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _adress.Index = Convert.ToInt32(postIndexTextBox.Text);
                postIndexTextBox.BackColor = _correctColor;
            }
            catch
            {
                postIndexTextBox.BackColor = _errorColor;
            }
        }

        private void CountyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _adress.Country = countyTextBox.Text;
                countyTextBox.BackColor = _correctColor;
            }
            catch
            {
                countyTextBox.BackColor = _errorColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _adress.City = cityTextBox.Text;
                cityTextBox.BackColor = _correctColor;
            }
            catch
            {
                cityTextBox.BackColor = _errorColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _adress.Street = streetTextBox.Text;
                streetTextBox.BackColor = _correctColor;
            }
            catch
            {
                streetTextBox.BackColor = _errorColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _adress.Building = buildingTextBox.Text;
                buildingTextBox.BackColor = _correctColor;
            }
            catch
            {
                buildingTextBox.BackColor = _errorColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _adress.Apartment = apartmentTextBox.Text;
                apartmentTextBox.BackColor = _correctColor;
            }
            catch
            {
                apartmentTextBox.BackColor = _errorColor;
            }
        }
    }
}
