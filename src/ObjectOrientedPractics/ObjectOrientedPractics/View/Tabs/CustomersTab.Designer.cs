
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.adressControl = new ObjectOrientedPractics.View.Controls.AdressControl();
            this.isPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.discountsListBox = new System.Windows.Forms.ListBox();
            this.addDiscountButton = new System.Windows.Forms.Button();
            this.removeDiscountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButton.Location = new System.Drawing.Point(103, 452);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 40);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Location = new System.Drawing.Point(3, 452);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 40);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // customersLabel
            // 
            this.customersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersLabel.AutoSize = true;
            this.customersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customersLabel.Location = new System.Drawing.Point(3, 0);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(84, 20);
            this.customersLabel.TabIndex = 5;
            this.customersLabel.Text = "Customers";
            // 
            // customersListBox
            // 
            this.customersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 20;
            this.customersListBox.Location = new System.Drawing.Point(3, 23);
            this.customersListBox.Name = "customersListBox";
            this.customersListBox.Size = new System.Drawing.Size(294, 424);
            this.customersListBox.TabIndex = 4;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fullNameLabel.Location = new System.Drawing.Point(308, 59);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.fullNameLabel.TabIndex = 12;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(308, 26);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 20);
            this.idLabel.TabIndex = 11;
            this.idLabel.Text = "ID:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameTextBox.Location = new System.Drawing.Point(393, 56);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(275, 27);
            this.fullNameTextBox.TabIndex = 14;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.Location = new System.Drawing.Point(393, 23);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(275, 27);
            this.idTextBox.TabIndex = 13;
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedCustomerLabel.Location = new System.Drawing.Point(303, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(139, 20);
            this.selectedCustomerLabel.TabIndex = 0;
            this.selectedCustomerLabel.Text = "Selected Customer";
            // 
            // adressControl
            // 
            this.adressControl.Adress = null;
            this.adressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adressControl.Location = new System.Drawing.Point(308, 120);
            this.adressControl.Name = "adressControl";
            this.adressControl.Size = new System.Drawing.Size(600, 159);
            this.adressControl.TabIndex = 16;
            // 
            // isPriorityCheckBox
            // 
            this.isPriorityCheckBox.AutoSize = true;
            this.isPriorityCheckBox.Location = new System.Drawing.Point(308, 89);
            this.isPriorityCheckBox.Name = "isPriorityCheckBox";
            this.isPriorityCheckBox.Size = new System.Drawing.Size(92, 24);
            this.isPriorityCheckBox.TabIndex = 17;
            this.isPriorityCheckBox.Text = "Is Priority";
            this.isPriorityCheckBox.UseVisualStyleBackColor = true;
            this.isPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
            // 
            // discountsLabel
            // 
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.discountsLabel.Location = new System.Drawing.Point(308, 282);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(78, 20);
            this.discountsLabel.TabIndex = 18;
            this.discountsLabel.Text = "Discounts";
            // 
            // discountsListBox
            // 
            this.discountsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsListBox.FormattingEnabled = true;
            this.discountsListBox.ItemHeight = 20;
            this.discountsListBox.Location = new System.Drawing.Point(308, 305);
            this.discountsListBox.Name = "discountsListBox";
            this.discountsListBox.Size = new System.Drawing.Size(360, 104);
            this.discountsListBox.TabIndex = 19;
            // 
            // addDiscountButton
            // 
            this.addDiscountButton.Location = new System.Drawing.Point(308, 412);
            this.addDiscountButton.Name = "addDiscountButton";
            this.addDiscountButton.Size = new System.Drawing.Size(94, 35);
            this.addDiscountButton.TabIndex = 20;
            this.addDiscountButton.Text = "Add";
            this.addDiscountButton.UseVisualStyleBackColor = true;
            this.addDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // removeDiscountButton
            // 
            this.removeDiscountButton.Location = new System.Drawing.Point(408, 412);
            this.removeDiscountButton.Name = "removeDiscountButton";
            this.removeDiscountButton.Size = new System.Drawing.Size(94, 35);
            this.removeDiscountButton.TabIndex = 21;
            this.removeDiscountButton.Text = "Remove";
            this.removeDiscountButton.UseVisualStyleBackColor = true;
            this.removeDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeDiscountButton);
            this.Controls.Add(this.addDiscountButton);
            this.Controls.Add(this.discountsListBox);
            this.Controls.Add(this.discountsLabel);
            this.Controls.Add(this.isPriorityCheckBox);
            this.Controls.Add(this.adressControl);
            this.Controls.Add(this.selectedCustomerLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.customersLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.customersListBox);
            this.Controls.Add(this.fullNameLabel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(908, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private Controls.AdressControl adressControl;
        private System.Windows.Forms.CheckBox isPriorityCheckBox;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.ListBox discountsListBox;
        private System.Windows.Forms.Button addDiscountButton;
        private System.Windows.Forms.Button removeDiscountButton;
    }
}
