namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.priceLabel = new System.Windows.Forms.Label();
            this.ammountLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.orderItemsLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.createdLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.selectedOrderLabel = new System.Windows.Forms.Label();
            this.adressControl = new ObjectOrientedPractics.View.Controls.AdressControl();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.clearOrderItem = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(-37, 476);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(29, 35);
            this.priceLabel.TabIndex = 27;
            this.priceLabel.Text = "0";
            // 
            // ammountLabel
            // 
            this.ammountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ammountLabel.AutoSize = true;
            this.ammountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ammountLabel.Location = new System.Drawing.Point(0, 422);
            this.ammountLabel.Name = "ammountLabel";
            this.ammountLabel.Size = new System.Drawing.Size(85, 20);
            this.ammountLabel.TabIndex = 26;
            this.ammountLabel.Text = "Ammount:";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(5, 326);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(746, 84);
            this.itemsListBox.TabIndex = 25;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // orderItemsLabel
            // 
            this.orderItemsLabel.AutoSize = true;
            this.orderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.orderItemsLabel.Location = new System.Drawing.Point(5, 303);
            this.orderItemsLabel.Name = "orderItemsLabel";
            this.orderItemsLabel.Size = new System.Drawing.Size(93, 20);
            this.orderItemsLabel.TabIndex = 24;
            this.orderItemsLabel.Text = "Order Items";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(75, 94);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(151, 28);
            this.statusComboBox.TabIndex = 23;
            this.statusComboBox.DropDownClosed += new System.EventHandler(this.StatusComboBox_DropDownClosed);
            // 
            // createdTextBox
            // 
            this.createdTextBox.Location = new System.Drawing.Point(75, 61);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.ReadOnly = true;
            this.createdTextBox.Size = new System.Drawing.Size(151, 27);
            this.createdTextBox.TabIndex = 22;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(75, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(151, 27);
            this.idTextBox.TabIndex = 21;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(5, 97);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 20);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "Status:";
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Location = new System.Drawing.Point(5, 64);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(64, 20);
            this.createdLabel.TabIndex = 19;
            this.createdLabel.Text = "Created:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(5, 33);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(27, 20);
            this.idLabel.TabIndex = 18;
            this.idLabel.Text = "ID:";
            // 
            // selectedOrderLabel
            // 
            this.selectedOrderLabel.AutoSize = true;
            this.selectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedOrderLabel.Location = new System.Drawing.Point(5, 0);
            this.selectedOrderLabel.Name = "selectedOrderLabel";
            this.selectedOrderLabel.Size = new System.Drawing.Size(111, 20);
            this.selectedOrderLabel.TabIndex = 17;
            this.selectedOrderLabel.Text = "Selected Order";
            // 
            // adressControl
            // 
            this.adressControl.Adress = null;
            this.adressControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adressControl.Location = new System.Drawing.Point(3, 133);
            this.adressControl.Name = "adressControl";
            this.adressControl.Size = new System.Drawing.Size(748, 166);
            this.adressControl.TabIndex = 16;
            // 
            // priceLabel1
            // 
            this.priceLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel1.AutoSize = true;
            this.priceLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel1.Location = new System.Drawing.Point(0, 442);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(29, 35);
            this.priceLabel1.TabIndex = 28;
            this.priceLabel1.Text = "0";
            // 
            // clearOrderItem
            // 
            this.clearOrderItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearOrderItem.Location = new System.Drawing.Point(644, 484);
            this.clearOrderItem.Name = "clearOrderItem";
            this.clearOrderItem.Size = new System.Drawing.Size(107, 40);
            this.clearOrderItem.TabIndex = 31;
            this.clearOrderItem.Text = "Clear Order";
            this.clearOrderItem.UseVisualStyleBackColor = true;
            this.clearOrderItem.Click += new System.EventHandler(this.ClearOrderItem_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Location = new System.Drawing.Point(127, 480);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(110, 40);
            this.removeItemButton.TabIndex = 30;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addItemButton.Location = new System.Drawing.Point(2, 480);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(103, 40);
            this.addItemButton.TabIndex = 29;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // optionsLabel
            // 
            this.optionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsLabel.Location = new System.Drawing.Point(465, 0);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(120, 20);
            this.optionsLabel.TabIndex = 32;
            this.optionsLabel.Text = "Priority Options";
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(465, 20);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(103, 20);
            this.deliveryTimeLabel.TabIndex = 33;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(591, 12);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(151, 28);
            this.deliveryTimeComboBox.TabIndex = 34;
            this.deliveryTimeComboBox.DropDownClosed += new System.EventHandler(this.DeliveryTimeComboBox_DropDownClosed);
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deliveryTimeComboBox);
            this.Controls.Add(this.deliveryTimeLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.clearOrderItem);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.priceLabel1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.ammountLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.orderItemsLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.createdTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.createdLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.selectedOrderLabel);
            this.Controls.Add(this.adressControl);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(754, 524);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label ammountLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label orderItemsLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label selectedOrderLabel;
        private Controls.AdressControl adressControl;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Button clearOrderItem;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
    }
}
