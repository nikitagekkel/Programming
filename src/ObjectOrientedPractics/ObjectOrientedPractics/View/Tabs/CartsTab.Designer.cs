
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.cartLabel = new System.Windows.Forms.Label();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.ammountLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartItem = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.discountsListBox = new System.Windows.Forms.CheckedListBox();
            this.discountAmmountLabel = new System.Windows.Forms.Label();
            this.discountAmmountPriceLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.itemsLabel.Location = new System.Drawing.Point(3, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(49, 20);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // itemsListBox
            // 
            this.itemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(3, 23);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(284, 424);
            this.itemsListBox.TabIndex = 1;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customerLabel.Location = new System.Drawing.Point(293, 23);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(82, 20);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Customer:";
            // 
            // customersComboBox
            // 
            this.customersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(381, 23);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(519, 28);
            this.customersComboBox.TabIndex = 3;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(293, 70);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(39, 20);
            this.cartLabel.TabIndex = 4;
            this.cartLabel.Text = "Cart:";
            // 
            // cartListBox
            // 
            this.cartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.ItemHeight = 20;
            this.cartListBox.Location = new System.Drawing.Point(293, 93);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(380, 184);
            this.cartListBox.TabIndex = 5;
            // 
            // ammountLabel
            // 
            this.ammountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ammountLabel.AutoSize = true;
            this.ammountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ammountLabel.Location = new System.Drawing.Point(293, 280);
            this.ammountLabel.Name = "ammountLabel";
            this.ammountLabel.Size = new System.Drawing.Size(85, 20);
            this.ammountLabel.TabIndex = 6;
            this.ammountLabel.Text = "Ammount:";
            // 
            // createOrderButton
            // 
            this.createOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createOrderButton.Location = new System.Drawing.Point(293, 407);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(103, 40);
            this.createOrderButton.TabIndex = 8;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.Location = new System.Drawing.Point(697, 407);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(110, 40);
            this.removeItemButton.TabIndex = 9;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // clearCartItem
            // 
            this.clearCartItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearCartItem.Location = new System.Drawing.Point(813, 407);
            this.clearCartItem.Name = "clearCartItem";
            this.clearCartItem.Size = new System.Drawing.Size(83, 40);
            this.clearCartItem.TabIndex = 10;
            this.clearCartItem.Text = "Clear Cart";
            this.clearCartItem.UseVisualStyleBackColor = true;
            this.clearCartItem.Click += new System.EventHandler(this.ClearCartItem_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLabel.Location = new System.Drawing.Point(293, 300);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(29, 35);
            this.priceLabel.TabIndex = 11;
            this.priceLabel.Text = "0";
            // 
            // addToCartButton
            // 
            this.addToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addToCartButton.Location = new System.Drawing.Point(3, 453);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(103, 40);
            this.addToCartButton.TabIndex = 12;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // discountsLabel
            // 
            this.discountsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.discountsLabel.Location = new System.Drawing.Point(679, 70);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(82, 20);
            this.discountsLabel.TabIndex = 13;
            this.discountsLabel.Text = "Discounts:";
            // 
            // discountsListBox
            // 
            this.discountsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountsListBox.BackColor = System.Drawing.SystemColors.Window;
            this.discountsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.discountsListBox.FormattingEnabled = true;
            this.discountsListBox.Location = new System.Drawing.Point(679, 93);
            this.discountsListBox.Name = "discountsListBox";
            this.discountsListBox.Size = new System.Drawing.Size(221, 176);
            this.discountsListBox.TabIndex = 14;
            this.discountsListBox.SelectedIndexChanged += new System.EventHandler(this.DiscountsListBox_SelectedIndexChanged);
            // 
            // discountAmmountLabel
            // 
            this.discountAmmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discountAmmountLabel.AutoSize = true;
            this.discountAmmountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.discountAmmountLabel.Location = new System.Drawing.Point(409, 280);
            this.discountAmmountLabel.Name = "discountAmmountLabel";
            this.discountAmmountLabel.Size = new System.Drawing.Size(148, 20);
            this.discountAmmountLabel.TabIndex = 15;
            this.discountAmmountLabel.Text = "Discount ammount:";
            // 
            // discountAmmountPriceLabel
            // 
            this.discountAmmountPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.discountAmmountPriceLabel.AutoSize = true;
            this.discountAmmountPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.discountAmmountPriceLabel.Location = new System.Drawing.Point(409, 300);
            this.discountAmmountPriceLabel.Name = "discountAmmountPriceLabel";
            this.discountAmmountPriceLabel.Size = new System.Drawing.Size(29, 35);
            this.discountAmmountPriceLabel.TabIndex = 16;
            this.discountAmmountPriceLabel.Text = "0";
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalLabel.Location = new System.Drawing.Point(293, 335);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 20);
            this.totalLabel.TabIndex = 17;
            this.totalLabel.Text = "TOTAL:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceLabel.Location = new System.Drawing.Point(293, 355);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(29, 35);
            this.totalPriceLabel.TabIndex = 18;
            this.totalPriceLabel.Text = "0";
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.discountAmmountPriceLabel);
            this.Controls.Add(this.discountAmmountLabel);
            this.Controls.Add(this.discountsListBox);
            this.Controls.Add(this.discountsLabel);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.clearCartItem);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.ammountLabel);
            this.Controls.Add(this.cartListBox);
            this.Controls.Add(this.cartLabel);
            this.Controls.Add(this.customersComboBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.itemsLabel);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(903, 504);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.Label ammountLabel;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartItem;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.CheckedListBox discountsListBox;
        private System.Windows.Forms.Label discountAmmountLabel;
        private System.Windows.Forms.Label discountAmmountPriceLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}
