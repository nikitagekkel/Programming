
namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.classesGroupBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idRectangleTextBox = new System.Windows.Forms.TextBox();
            this.findRectangleButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.Label();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heigthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.widthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.colorRectangleTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.classesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classesGroupBox
            // 
            this.classesGroupBox.Controls.Add(this.idLabel);
            this.classesGroupBox.Controls.Add(this.idRectangleTextBox);
            this.classesGroupBox.Controls.Add(this.findRectangleButton);
            this.classesGroupBox.Controls.Add(this.yLabel);
            this.classesGroupBox.Controls.Add(this.YRectangleTextBox);
            this.classesGroupBox.Controls.Add(this.xLabel);
            this.classesGroupBox.Controls.Add(this.XRectangleTextBox);
            this.classesGroupBox.Controls.Add(this.colorLabel);
            this.classesGroupBox.Controls.Add(this.widthLabel);
            this.classesGroupBox.Controls.Add(this.heightLabel);
            this.classesGroupBox.Controls.Add(this.heigthRectangleTextBox);
            this.classesGroupBox.Controls.Add(this.widthRectangleTextBox);
            this.classesGroupBox.Controls.Add(this.colorRectangleTextBox);
            this.classesGroupBox.Controls.Add(this.rectanglesListBox);
            this.classesGroupBox.Location = new System.Drawing.Point(8, 8);
            this.classesGroupBox.Name = "classesGroupBox";
            this.classesGroupBox.Size = new System.Drawing.Size(331, 406);
            this.classesGroupBox.TabIndex = 1;
            this.classesGroupBox.TabStop = false;
            this.classesGroupBox.Text = "Rectangles";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(187, 290);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 20);
            this.idLabel.TabIndex = 13;
            this.idLabel.Text = "Id:";
            // 
            // idRectangleTextBox
            // 
            this.idRectangleTextBox.Location = new System.Drawing.Point(187, 313);
            this.idRectangleTextBox.Name = "idRectangleTextBox";
            this.idRectangleTextBox.ReadOnly = true;
            this.idRectangleTextBox.Size = new System.Drawing.Size(125, 27);
            this.idRectangleTextBox.TabIndex = 12;
            // 
            // findRectangleButton
            // 
            this.findRectangleButton.Location = new System.Drawing.Point(187, 361);
            this.findRectangleButton.Name = "findRectangleButton";
            this.findRectangleButton.Size = new System.Drawing.Size(125, 29);
            this.findRectangleButton.TabIndex = 7;
            this.findRectangleButton.Text = "Find";
            this.findRectangleButton.UseVisualStyleBackColor = true;
            this.findRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(187, 237);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(20, 20);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "Y:";
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Location = new System.Drawing.Point(187, 260);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.ReadOnly = true;
            this.YRectangleTextBox.Size = new System.Drawing.Size(125, 27);
            this.YRectangleTextBox.TabIndex = 10;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(187, 185);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(21, 20);
            this.xLabel.TabIndex = 9;
            this.xLabel.Text = "X:";
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Location = new System.Drawing.Point(187, 207);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.ReadOnly = true;
            this.XRectangleTextBox.Size = new System.Drawing.Size(125, 27);
            this.XRectangleTextBox.TabIndex = 8;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(187, 132);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(48, 20);
            this.colorLabel.TabIndex = 6;
            this.colorLabel.Text = "Color:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(187, 79);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(52, 20);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(187, 26);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(57, 20);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Height:";
            // 
            // heigthRectangleTextBox
            // 
            this.heigthRectangleTextBox.Location = new System.Drawing.Point(187, 49);
            this.heigthRectangleTextBox.Name = "heigthRectangleTextBox";
            this.heigthRectangleTextBox.Size = new System.Drawing.Size(125, 27);
            this.heigthRectangleTextBox.TabIndex = 3;
            this.heigthRectangleTextBox.TextChanged += new System.EventHandler(this.HeigthRectangleTextBox_TextChanged);
            // 
            // widthRectangleTextBox
            // 
            this.widthRectangleTextBox.Location = new System.Drawing.Point(187, 102);
            this.widthRectangleTextBox.Name = "widthRectangleTextBox";
            this.widthRectangleTextBox.Size = new System.Drawing.Size(125, 27);
            this.widthRectangleTextBox.TabIndex = 2;
            this.widthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged_1);
            // 
            // colorRectangleTextBox
            // 
            this.colorRectangleTextBox.Location = new System.Drawing.Point(187, 155);
            this.colorRectangleTextBox.Name = "colorRectangleTextBox";
            this.colorRectangleTextBox.Size = new System.Drawing.Size(125, 27);
            this.colorRectangleTextBox.TabIndex = 1;
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.ItemHeight = 20;
            this.rectanglesListBox.Location = new System.Drawing.Point(11, 26);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(156, 364);
            this.rectanglesListBox.TabIndex = 0;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.classesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(331, 406);
            this.classesGroupBox.ResumeLayout(false);
            this.classesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox classesGroupBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idRectangleTextBox;
        private System.Windows.Forms.Button findRectangleButton;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heigthRectangleTextBox;
        private System.Windows.Forms.TextBox widthRectangleTextBox;
        private System.Windows.Forms.TextBox colorRectangleTextBox;
        private System.Windows.Forms.ListBox rectanglesListBox;
    }
}
