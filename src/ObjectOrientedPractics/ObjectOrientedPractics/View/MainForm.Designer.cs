
namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.itemsPage = new System.Windows.Forms.TabPage();
            this.itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customerPage = new System.Windows.Forms.TabPage();
            this.customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.cartTab = new System.Windows.Forms.TabPage();
            this.cartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.ordersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.priorityOrderTab = new System.Windows.Forms.TabPage();
            this.priorityOrdersTab = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.tabControl.SuspendLayout();
            this.itemsPage.SuspendLayout();
            this.customerPage.SuspendLayout();
            this.cartTab.SuspendLayout();
            this.orderTab.SuspendLayout();
            this.priorityOrderTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.itemsPage);
            this.tabControl.Controls.Add(this.customerPage);
            this.tabControl.Controls.Add(this.cartTab);
            this.tabControl.Controls.Add(this.orderTab);
            this.tabControl.Controls.Add(this.priorityOrderTab);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1166, 558);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.SelectedTabChanged);
            // 
            // itemsPage
            // 
            this.itemsPage.Controls.Add(this.itemsTab);
            this.itemsPage.Location = new System.Drawing.Point(4, 29);
            this.itemsPage.Name = "itemsPage";
            this.itemsPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsPage.Size = new System.Drawing.Size(1158, 525);
            this.itemsPage.TabIndex = 0;
            this.itemsPage.Text = "Items";
            this.itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab.Location = new System.Drawing.Point(3, 3);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(1152, 519);
            this.itemsTab.TabIndex = 0;
            this.itemsTab.ItemsChanged += new System.EventHandler<System.EventArgs>(this.ItemsTab_ItemsChanged);
            // 
            // customerPage
            // 
            this.customerPage.Controls.Add(this.customersTab);
            this.customerPage.Location = new System.Drawing.Point(4, 29);
            this.customerPage.Name = "customerPage";
            this.customerPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerPage.Size = new System.Drawing.Size(1158, 525);
            this.customerPage.TabIndex = 1;
            this.customerPage.Text = "Customers";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            this.customersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab.Location = new System.Drawing.Point(3, 3);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(1152, 519);
            this.customersTab.TabIndex = 0;
            // 
            // cartTab
            // 
            this.cartTab.Controls.Add(this.cartsTab);
            this.cartTab.Location = new System.Drawing.Point(4, 29);
            this.cartTab.Name = "cartTab";
            this.cartTab.Size = new System.Drawing.Size(1158, 525);
            this.cartTab.TabIndex = 0;
            this.cartTab.Text = "Cart";
            this.cartTab.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            this.cartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab.Location = new System.Drawing.Point(0, 0);
            this.cartsTab.Name = "cartsTab";
            this.cartsTab.Size = new System.Drawing.Size(1158, 525);
            this.cartsTab.TabIndex = 0;
            // 
            // orderTab
            // 
            this.orderTab.Controls.Add(this.ordersTab);
            this.orderTab.Location = new System.Drawing.Point(4, 29);
            this.orderTab.Name = "orderTab";
            this.orderTab.Padding = new System.Windows.Forms.Padding(3);
            this.orderTab.Size = new System.Drawing.Size(1158, 525);
            this.orderTab.TabIndex = 2;
            this.orderTab.Text = "Orders";
            this.orderTab.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(3, 3);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(1152, 519);
            this.ordersTab.TabIndex = 0;
            // 
            // priorityOrderTab
            // 
            this.priorityOrderTab.Controls.Add(this.priorityOrdersTab);
            this.priorityOrderTab.Location = new System.Drawing.Point(4, 29);
            this.priorityOrderTab.Name = "priorityOrderTab";
            this.priorityOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.priorityOrderTab.Size = new System.Drawing.Size(1158, 525);
            this.priorityOrderTab.TabIndex = 3;
            this.priorityOrderTab.Text = "Priority Orders";
            this.priorityOrderTab.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab
            // 
            this.priorityOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOrdersTab.Location = new System.Drawing.Point(3, 3);
            this.priorityOrdersTab.Name = "priorityOrdersTab";
            this.priorityOrdersTab.Size = new System.Drawing.Size(1152, 519);
            this.priorityOrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 561);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.itemsPage.ResumeLayout(false);
            this.customerPage.ResumeLayout(false);
            this.cartTab.ResumeLayout(false);
            this.orderTab.ResumeLayout(false);
            this.priorityOrderTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage itemsPage;
        private System.Windows.Forms.TabPage customerPage;
        private View.Tabs.CustomersTab customersTab;
        private System.Windows.Forms.TabPage cartTab;
        private View.Tabs.CartsTab cartsTab;
        private System.Windows.Forms.TabPage orderTab;
        private View.Tabs.OrdersTab ordersTab;
        private View.Tabs.ItemsTab itemsTab;
        private System.Windows.Forms.TabPage priorityOrderTab;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab;
    }
}

