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
    public partial class ItemsTab : UserControl
    {
        public ItemsTab()
        {
            InitializeComponent();
            itemsLabel.Font = new Font(itemsLabel.Font, FontStyle.Bold);
            selectedItemLabel.Font = new Font(selectedItemLabel.Font, FontStyle.Bold);
        }
    }
}
