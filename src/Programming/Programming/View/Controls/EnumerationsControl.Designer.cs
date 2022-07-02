
namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.enumsGroupBox = new System.Windows.Forms.GroupBox();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.intValueLabel = new System.Windows.Forms.Label();
            this.сhooseValueLabel = new System.Windows.Forms.Label();
            this.enumerationLabel = new System.Windows.Forms.Label();
            this.intValueTextBox = new System.Windows.Forms.TextBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.enumsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enumsGroupBox
            // 
            this.enumsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumsGroupBox.Controls.Add(this.enumsListBox);
            this.enumsGroupBox.Controls.Add(this.intValueLabel);
            this.enumsGroupBox.Controls.Add(this.сhooseValueLabel);
            this.enumsGroupBox.Controls.Add(this.enumerationLabel);
            this.enumsGroupBox.Controls.Add(this.intValueTextBox);
            this.enumsGroupBox.Controls.Add(this.valuesListBox);
            this.enumsGroupBox.Location = new System.Drawing.Point(8, 8);
            this.enumsGroupBox.Name = "enumsGroupBox";
            this.enumsGroupBox.Size = new System.Drawing.Size(699, 361);
            this.enumsGroupBox.TabIndex = 6;
            this.enumsGroupBox.TabStop = false;
            this.enumsGroupBox.Text = "Enumerations";
            // 
            // enumsListBox
            // 
            this.enumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.enumsListBox.FormattingEnabled = true;
            this.enumsListBox.ItemHeight = 20;
            this.enumsListBox.Location = new System.Drawing.Point(11, 56);
            this.enumsListBox.Name = "enumsListBox";
            this.enumsListBox.ScrollAlwaysVisible = true;
            this.enumsListBox.Size = new System.Drawing.Size(156, 284);
            this.enumsListBox.TabIndex = 0;
            this.enumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // intValueLabel
            // 
            this.intValueLabel.AutoSize = true;
            this.intValueLabel.Location = new System.Drawing.Point(365, 33);
            this.intValueLabel.Name = "intValueLabel";
            this.intValueLabel.Size = new System.Drawing.Size(68, 20);
            this.intValueLabel.TabIndex = 5;
            this.intValueLabel.Text = "Int value:";
            // 
            // сhooseValueLabel
            // 
            this.сhooseValueLabel.AutoSize = true;
            this.сhooseValueLabel.Location = new System.Drawing.Point(189, 33);
            this.сhooseValueLabel.Name = "сhooseValueLabel";
            this.сhooseValueLabel.Size = new System.Drawing.Size(100, 20);
            this.сhooseValueLabel.TabIndex = 4;
            this.сhooseValueLabel.Text = "Choose value:";
            // 
            // enumerationLabel
            // 
            this.enumerationLabel.AutoSize = true;
            this.enumerationLabel.Location = new System.Drawing.Point(11, 33);
            this.enumerationLabel.Name = "enumerationLabel";
            this.enumerationLabel.Size = new System.Drawing.Size(149, 20);
            this.enumerationLabel.TabIndex = 3;
            this.enumerationLabel.Text = "Choose enumeration:";
            // 
            // intValueTextBox
            // 
            this.intValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intValueTextBox.Location = new System.Drawing.Point(365, 56);
            this.intValueTextBox.Name = "intValueTextBox";
            this.intValueTextBox.ReadOnly = true;
            this.intValueTextBox.Size = new System.Drawing.Size(149, 27);
            this.intValueTextBox.TabIndex = 2;
            // 
            // valuesListBox
            // 
            this.valuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ItemHeight = 20;
            this.valuesListBox.Location = new System.Drawing.Point(189, 56);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.ScrollAlwaysVisible = true;
            this.valuesListBox.Size = new System.Drawing.Size(156, 284);
            this.valuesListBox.TabIndex = 1;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enumsGroupBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(699, 361);
            this.Load += new System.EventHandler(this.EnumerationControl_Load);
            this.enumsGroupBox.ResumeLayout(false);
            this.enumsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enumsGroupBox;
        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.Label intValueLabel;
        private System.Windows.Forms.Label сhooseValueLabel;
        private System.Windows.Forms.Label enumerationLabel;
        private System.Windows.Forms.TextBox intValueTextBox;
        private System.Windows.Forms.ListBox valuesListBox;
    }
}
