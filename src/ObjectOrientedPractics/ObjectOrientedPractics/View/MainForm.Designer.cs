
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
            this.tabControl.SuspendLayout();
            this.itemsPage.SuspendLayout();
            this.customerPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.itemsPage);
            this.tabControl.Controls.Add(this.customerPage);
            this.tabControl.Location = new System.Drawing.Point(3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(772, 537);
            this.tabControl.TabIndex = 0;
            // 
            // itemsPage
            // 
            this.itemsPage.Controls.Add(this.itemsTab);
            this.itemsPage.Location = new System.Drawing.Point(4, 29);
            this.itemsPage.Name = "itemsPage";
            this.itemsPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsPage.Size = new System.Drawing.Size(764, 504);
            this.itemsPage.TabIndex = 0;
            this.itemsPage.Text = "Items";
            this.itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab.Location = new System.Drawing.Point(3, 3);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(758, 498);
            this.itemsTab.TabIndex = 0;
            // 
            // customerPage
            // 
            this.customerPage.Controls.Add(this.customersTab);
            this.customerPage.Location = new System.Drawing.Point(4, 29);
            this.customerPage.Name = "customerPage";
            this.customerPage.Padding = new System.Windows.Forms.Padding(3);
            this.customerPage.Size = new System.Drawing.Size(764, 504);
            this.customerPage.TabIndex = 1;
            this.customerPage.Text = "Customers";
            this.customerPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            this.customersTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersTab.Location = new System.Drawing.Point(3, 3);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(758, 498);
            this.customersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 540);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.itemsPage.ResumeLayout(false);
            this.customerPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage itemsPage;
        private System.Windows.Forms.TabPage customerPage;
        private View.Tabs.ItemsTab itemsTab;
        private View.Tabs.CustomersTab customersTab;
    }
}

