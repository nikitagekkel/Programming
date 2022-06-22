
namespace Programming.View.Controls
{
    partial class WeekdayParsingControl
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
            this.parsingGroupBox = new System.Windows.Forms.GroupBox();
            this.parseLabel = new System.Windows.Forms.Label();
            this.parseButton = new System.Windows.Forms.Button();
            this.typeValueLabel = new System.Windows.Forms.Label();
            this.parsingTextBox = new System.Windows.Forms.TextBox();
            this.parsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // parsingGroupBox
            // 
            this.parsingGroupBox.Controls.Add(this.parseLabel);
            this.parsingGroupBox.Controls.Add(this.parseButton);
            this.parsingGroupBox.Controls.Add(this.typeValueLabel);
            this.parsingGroupBox.Controls.Add(this.parsingTextBox);
            this.parsingGroupBox.Location = new System.Drawing.Point(8, 8);
            this.parsingGroupBox.Name = "parsingGroupBox";
            this.parsingGroupBox.Size = new System.Drawing.Size(347, 145);
            this.parsingGroupBox.TabIndex = 2;
            this.parsingGroupBox.TabStop = false;
            this.parsingGroupBox.Text = "Weekday Parsing";
            // 
            // parseLabel
            // 
            this.parseLabel.AutoSize = true;
            this.parseLabel.Location = new System.Drawing.Point(11, 100);
            this.parseLabel.Name = "parseLabel";
            this.parseLabel.Size = new System.Drawing.Size(0, 20);
            this.parseLabel.TabIndex = 0;
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(233, 67);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(105, 31);
            this.parseButton.TabIndex = 3;
            this.parseButton.Text = "Parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // typeValueLabel
            // 
            this.typeValueLabel.AutoSize = true;
            this.typeValueLabel.Location = new System.Drawing.Point(11, 40);
            this.typeValueLabel.Name = "typeValueLabel";
            this.typeValueLabel.Size = new System.Drawing.Size(158, 20);
            this.typeValueLabel.TabIndex = 6;
            this.typeValueLabel.Text = "Type value for parsing:";
            // 
            // parsingTextBox
            // 
            this.parsingTextBox.Location = new System.Drawing.Point(11, 67);
            this.parsingTextBox.Name = "parsingTextBox";
            this.parsingTextBox.Size = new System.Drawing.Size(214, 27);
            this.parsingTextBox.TabIndex = 1;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parsingGroupBox);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(347, 145);
            this.parsingGroupBox.ResumeLayout(false);
            this.parsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox parsingGroupBox;
        private System.Windows.Forms.Label parseLabel;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Label typeValueLabel;
        private System.Windows.Forms.TextBox parsingTextBox;
    }
}
