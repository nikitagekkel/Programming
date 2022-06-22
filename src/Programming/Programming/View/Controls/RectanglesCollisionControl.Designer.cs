
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            this.heigthPanelTextBox = new System.Windows.Forms.TextBox();
            this.selectedHeightLabel = new System.Windows.Forms.Label();
            this.widthPanelTextBox = new System.Windows.Forms.TextBox();
            this.selectedWidthLabel = new System.Windows.Forms.Label();
            this.yPanelTextBox = new System.Windows.Forms.TextBox();
            this.xPanelTextBox = new System.Windows.Forms.TextBox();
            this.idPanelTextBox = new System.Windows.Forms.TextBox();
            this.selectedYLabel = new System.Windows.Forms.Label();
            this.selectedXLabel = new System.Windows.Forms.Label();
            this.selectedIdLabel = new System.Windows.Forms.Label();
            this.selectedRectangleLabel = new System.Windows.Forms.Label();
            this.removeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.addButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.selectedRectanglesLabel = new System.Windows.Forms.Label();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.rectanglesPanelListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.removeButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heigthPanelTextBox
            // 
            this.heigthPanelTextBox.Location = new System.Drawing.Point(75, 424);
            this.heigthPanelTextBox.Name = "heigthPanelTextBox";
            this.heigthPanelTextBox.Size = new System.Drawing.Size(125, 27);
            this.heigthPanelTextBox.TabIndex = 31;
            this.heigthPanelTextBox.TextChanged += new System.EventHandler(this.HeightPanelTextBox_TextChanged);
            // 
            // selectedHeightLabel
            // 
            this.selectedHeightLabel.AutoSize = true;
            this.selectedHeightLabel.Location = new System.Drawing.Point(7, 424);
            this.selectedHeightLabel.Name = "selectedHeightLabel";
            this.selectedHeightLabel.Size = new System.Drawing.Size(57, 20);
            this.selectedHeightLabel.TabIndex = 26;
            this.selectedHeightLabel.Text = "Height:";
            // 
            // widthPanelTextBox
            // 
            this.widthPanelTextBox.Location = new System.Drawing.Point(75, 391);
            this.widthPanelTextBox.Name = "widthPanelTextBox";
            this.widthPanelTextBox.Size = new System.Drawing.Size(125, 27);
            this.widthPanelTextBox.TabIndex = 30;
            this.widthPanelTextBox.TextChanged += new System.EventHandler(this.WidthPanelTextBox_TextChanged);
            // 
            // selectedWidthLabel
            // 
            this.selectedWidthLabel.AutoSize = true;
            this.selectedWidthLabel.Location = new System.Drawing.Point(12, 391);
            this.selectedWidthLabel.Name = "selectedWidthLabel";
            this.selectedWidthLabel.Size = new System.Drawing.Size(52, 20);
            this.selectedWidthLabel.TabIndex = 25;
            this.selectedWidthLabel.Text = "Width:";
            // 
            // yPanelTextBox
            // 
            this.yPanelTextBox.Location = new System.Drawing.Point(75, 358);
            this.yPanelTextBox.Name = "yPanelTextBox";
            this.yPanelTextBox.Size = new System.Drawing.Size(125, 27);
            this.yPanelTextBox.TabIndex = 29;
            this.yPanelTextBox.TextChanged += new System.EventHandler(this.YPanelTextBox_TextChanged);
            // 
            // xPanelTextBox
            // 
            this.xPanelTextBox.Location = new System.Drawing.Point(75, 325);
            this.xPanelTextBox.Name = "xPanelTextBox";
            this.xPanelTextBox.Size = new System.Drawing.Size(125, 27);
            this.xPanelTextBox.TabIndex = 28;
            this.xPanelTextBox.TextChanged += new System.EventHandler(this.XPanelTextBox_TextChanged);
            // 
            // idPanelTextBox
            // 
            this.idPanelTextBox.Location = new System.Drawing.Point(75, 292);
            this.idPanelTextBox.Name = "idPanelTextBox";
            this.idPanelTextBox.ReadOnly = true;
            this.idPanelTextBox.Size = new System.Drawing.Size(125, 27);
            this.idPanelTextBox.TabIndex = 27;
            // 
            // selectedYLabel
            // 
            this.selectedYLabel.AutoSize = true;
            this.selectedYLabel.Location = new System.Drawing.Point(44, 358);
            this.selectedYLabel.Name = "selectedYLabel";
            this.selectedYLabel.Size = new System.Drawing.Size(20, 20);
            this.selectedYLabel.TabIndex = 24;
            this.selectedYLabel.Text = "Y:";
            // 
            // selectedXLabel
            // 
            this.selectedXLabel.AutoSize = true;
            this.selectedXLabel.Location = new System.Drawing.Point(43, 325);
            this.selectedXLabel.Name = "selectedXLabel";
            this.selectedXLabel.Size = new System.Drawing.Size(21, 20);
            this.selectedXLabel.TabIndex = 23;
            this.selectedXLabel.Text = "X:";
            // 
            // selectedIdLabel
            // 
            this.selectedIdLabel.AutoSize = true;
            this.selectedIdLabel.Location = new System.Drawing.Point(44, 292);
            this.selectedIdLabel.Name = "selectedIdLabel";
            this.selectedIdLabel.Size = new System.Drawing.Size(25, 20);
            this.selectedIdLabel.TabIndex = 22;
            this.selectedIdLabel.Text = "Id:";
            // 
            // selectedRectangleLabel
            // 
            this.selectedRectangleLabel.AutoSize = true;
            this.selectedRectangleLabel.Location = new System.Drawing.Point(7, 269);
            this.selectedRectangleLabel.Name = "selectedRectangleLabel";
            this.selectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.selectedRectangleLabel.TabIndex = 21;
            this.selectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // removeButtonPictureBox
            // 
            this.removeButtonPictureBox.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.removeButtonPictureBox.Location = new System.Drawing.Point(224, 200);
            this.removeButtonPictureBox.Name = "removeButtonPictureBox";
            this.removeButtonPictureBox.Size = new System.Drawing.Size(34, 34);
            this.removeButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeButtonPictureBox.TabIndex = 20;
            this.removeButtonPictureBox.TabStop = false;
            this.removeButtonPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveButtonPictureBox_MouseClick);
            this.removeButtonPictureBox.MouseEnter += new System.EventHandler(this.RemoveButtonPictureBox_MouseEnter);
            this.removeButtonPictureBox.MouseLeave += new System.EventHandler(this.RemoveButtonPictureBox_MouseLeave);
            // 
            // addButtonPictureBox
            // 
            this.addButtonPictureBox.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.addButtonPictureBox.Location = new System.Drawing.Point(7, 200);
            this.addButtonPictureBox.Name = "addButtonPictureBox";
            this.addButtonPictureBox.Size = new System.Drawing.Size(34, 34);
            this.addButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addButtonPictureBox.TabIndex = 19;
            this.addButtonPictureBox.TabStop = false;
            this.addButtonPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddButtonPictureBox_MouseClick);
            this.addButtonPictureBox.MouseEnter += new System.EventHandler(this.AddButtonPictureBox_MouseEnter);
            this.addButtonPictureBox.MouseLeave += new System.EventHandler(this.AddButtonPictureBox_MouseLeave);
            // 
            // selectedRectanglesLabel
            // 
            this.selectedRectanglesLabel.AutoSize = true;
            this.selectedRectanglesLabel.Location = new System.Drawing.Point(7, 7);
            this.selectedRectanglesLabel.Name = "selectedRectanglesLabel";
            this.selectedRectanglesLabel.Size = new System.Drawing.Size(84, 20);
            this.selectedRectanglesLabel.TabIndex = 18;
            this.selectedRectanglesLabel.Text = "Rectangles:";
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasPanel.Location = new System.Drawing.Point(278, 7);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(425, 524);
            this.canvasPanel.TabIndex = 17;
            // 
            // rectanglesPanelListBox
            // 
            this.rectanglesPanelListBox.FormattingEnabled = true;
            this.rectanglesPanelListBox.ItemHeight = 20;
            this.rectanglesPanelListBox.Location = new System.Drawing.Point(7, 30);
            this.rectanglesPanelListBox.Name = "rectanglesPanelListBox";
            this.rectanglesPanelListBox.Size = new System.Drawing.Size(251, 164);
            this.rectanglesPanelListBox.TabIndex = 16;
            this.rectanglesPanelListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesPanelListBox_SelectedIndexChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heigthPanelTextBox);
            this.Controls.Add(this.selectedHeightLabel);
            this.Controls.Add(this.widthPanelTextBox);
            this.Controls.Add(this.selectedWidthLabel);
            this.Controls.Add(this.yPanelTextBox);
            this.Controls.Add(this.xPanelTextBox);
            this.Controls.Add(this.idPanelTextBox);
            this.Controls.Add(this.selectedYLabel);
            this.Controls.Add(this.selectedXLabel);
            this.Controls.Add(this.selectedIdLabel);
            this.Controls.Add(this.selectedRectangleLabel);
            this.Controls.Add(this.removeButtonPictureBox);
            this.Controls.Add(this.addButtonPictureBox);
            this.Controls.Add(this.selectedRectanglesLabel);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.rectanglesPanelListBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(710, 538);
            ((System.ComponentModel.ISupportInitialize)(this.removeButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox heigthPanelTextBox;
        private System.Windows.Forms.Label selectedHeightLabel;
        private System.Windows.Forms.TextBox widthPanelTextBox;
        private System.Windows.Forms.Label selectedWidthLabel;
        private System.Windows.Forms.TextBox yPanelTextBox;
        private System.Windows.Forms.TextBox xPanelTextBox;
        private System.Windows.Forms.TextBox idPanelTextBox;
        private System.Windows.Forms.Label selectedYLabel;
        private System.Windows.Forms.Label selectedXLabel;
        private System.Windows.Forms.Label selectedIdLabel;
        private System.Windows.Forms.Label selectedRectangleLabel;
        private System.Windows.Forms.PictureBox removeButtonPictureBox;
        private System.Windows.Forms.PictureBox addButtonPictureBox;
        private System.Windows.Forms.Label selectedRectanglesLabel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.ListBox rectanglesPanelListBox;
    }
}
