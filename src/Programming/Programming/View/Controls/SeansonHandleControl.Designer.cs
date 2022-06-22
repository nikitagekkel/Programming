
namespace Programming.View.Controls
{
    partial class SeansonHandleControl
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
            this.seasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseSeasonLabel = new System.Windows.Forms.Label();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.seasonHandleButton = new System.Windows.Forms.Button();
            this.seasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // seasonHandleGroupBox
            // 
            this.seasonHandleGroupBox.Controls.Add(this.chooseSeasonLabel);
            this.seasonHandleGroupBox.Controls.Add(this.seasonComboBox);
            this.seasonHandleGroupBox.Controls.Add(this.seasonHandleButton);
            this.seasonHandleGroupBox.Location = new System.Drawing.Point(8, 8);
            this.seasonHandleGroupBox.Name = "seasonHandleGroupBox";
            this.seasonHandleGroupBox.Size = new System.Drawing.Size(345, 145);
            this.seasonHandleGroupBox.TabIndex = 3;
            this.seasonHandleGroupBox.TabStop = false;
            this.seasonHandleGroupBox.Text = "Season Handle";
            // 
            // chooseSeasonLabel
            // 
            this.chooseSeasonLabel.AutoSize = true;
            this.chooseSeasonLabel.Location = new System.Drawing.Point(10, 40);
            this.chooseSeasonLabel.Name = "chooseSeasonLabel";
            this.chooseSeasonLabel.Size = new System.Drawing.Size(110, 20);
            this.chooseSeasonLabel.TabIndex = 7;
            this.chooseSeasonLabel.Text = "Choose season:";
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonComboBox.FormattingEnabled = true;
            this.seasonComboBox.Location = new System.Drawing.Point(10, 68);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.Size = new System.Drawing.Size(214, 28);
            this.seasonComboBox.TabIndex = 4;
            // 
            // seasonHandleButton
            // 
            this.seasonHandleButton.Location = new System.Drawing.Point(232, 68);
            this.seasonHandleButton.Name = "seasonHandleButton";
            this.seasonHandleButton.Size = new System.Drawing.Size(105, 31);
            this.seasonHandleButton.TabIndex = 5;
            this.seasonHandleButton.Text = "Go!";
            this.seasonHandleButton.UseVisualStyleBackColor = true;
            this.seasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // SeansonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seasonHandleGroupBox);
            this.Name = "SeansonHandleControl";
            this.Size = new System.Drawing.Size(345, 145);
            this.seasonHandleGroupBox.ResumeLayout(false);
            this.seasonHandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox seasonHandleGroupBox;
        private System.Windows.Forms.Label chooseSeasonLabel;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Button seasonHandleButton;
    }
}
