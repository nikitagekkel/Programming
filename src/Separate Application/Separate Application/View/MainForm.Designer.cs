
namespace Separate_Application
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
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.pagesNumberLabel = new System.Windows.Forms.Label();
            this.pagesNumberTextBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.releaseYearLabel = new System.Windows.Forms.Label();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.addButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.removeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.mainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButtonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // booksListBox
            // 
            this.booksListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(12, 12);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(272, 424);
            this.booksListBox.TabIndex = 0;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGroupBox.Controls.Add(this.genreLabel);
            this.mainGroupBox.Controls.Add(this.genreComboBox);
            this.mainGroupBox.Controls.Add(this.pagesNumberLabel);
            this.mainGroupBox.Controls.Add(this.pagesNumberTextBox);
            this.mainGroupBox.Controls.Add(this.authorLabel);
            this.mainGroupBox.Controls.Add(this.authorTextBox);
            this.mainGroupBox.Controls.Add(this.releaseYearLabel);
            this.mainGroupBox.Controls.Add(this.releaseYearTextBox);
            this.mainGroupBox.Controls.Add(this.bookTitleLabel);
            this.mainGroupBox.Controls.Add(this.bookTitleTextBox);
            this.mainGroupBox.Location = new System.Drawing.Point(290, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(498, 202);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Selected Book";
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(85, 161);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(51, 20);
            this.genreLabel.TabIndex = 9;
            this.genreLabel.Text = "Genre:";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(139, 158);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(110, 28);
            this.genreComboBox.TabIndex = 8;
            // 
            // pagesNumberLabel
            // 
            this.pagesNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagesNumberLabel.AutoSize = true;
            this.pagesNumberLabel.Location = new System.Drawing.Point(10, 128);
            this.pagesNumberLabel.Name = "pagesNumberLabel";
            this.pagesNumberLabel.Size = new System.Drawing.Size(126, 20);
            this.pagesNumberLabel.TabIndex = 7;
            this.pagesNumberLabel.Text = "Number of Pages:";
            // 
            // pagesNumberTextBox
            // 
            this.pagesNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pagesNumberTextBox.Location = new System.Drawing.Point(139, 125);
            this.pagesNumberTextBox.Name = "pagesNumberTextBox";
            this.pagesNumberTextBox.Size = new System.Drawing.Size(247, 27);
            this.pagesNumberTextBox.TabIndex = 6;
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(79, 95);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(57, 20);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author:";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Location = new System.Drawing.Point(139, 92);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(247, 27);
            this.authorTextBox.TabIndex = 4;
            // 
            // releaseYearLabel
            // 
            this.releaseYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.releaseYearLabel.AutoSize = true;
            this.releaseYearLabel.Location = new System.Drawing.Point(41, 62);
            this.releaseYearLabel.Name = "releaseYearLabel";
            this.releaseYearLabel.Size = new System.Drawing.Size(95, 20);
            this.releaseYearLabel.TabIndex = 3;
            this.releaseYearLabel.Text = "Realese Year:";
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Location = new System.Drawing.Point(139, 59);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(49, 27);
            this.releaseYearTextBox.TabIndex = 2;
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(57, 29);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(79, 20);
            this.bookTitleLabel.TabIndex = 1;
            this.bookTitleLabel.Text = "Book Title:";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookTitleTextBox.Location = new System.Drawing.Point(139, 26);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(247, 27);
            this.bookTitleTextBox.TabIndex = 0;
            // 
            // addButtonPictureBox
            // 
            this.addButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButtonPictureBox.InitialImage = global::Separate_Application.Properties.Resources.add_24x24_uncolor;
            this.addButtonPictureBox.Location = new System.Drawing.Point(12, 442);
            this.addButtonPictureBox.Name = "addButtonPictureBox";
            this.addButtonPictureBox.Size = new System.Drawing.Size(29, 32);
            this.addButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addButtonPictureBox.TabIndex = 2;
            this.addButtonPictureBox.TabStop = false;
            this.addButtonPictureBox.MouseEnter += new System.EventHandler(this.AddButtonPictureBox_MouseEnter);
            this.addButtonPictureBox.MouseLeave += new System.EventHandler(this.AddButtonPictureBox_MouseLeave);
            // 
            // removeButtonPictureBox
            // 
            this.removeButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButtonPictureBox.Location = new System.Drawing.Point(47, 442);
            this.removeButtonPictureBox.Name = "removeButtonPictureBox";
            this.removeButtonPictureBox.Size = new System.Drawing.Size(29, 32);
            this.removeButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeButtonPictureBox.TabIndex = 3;
            this.removeButtonPictureBox.TabStop = false;
            this.removeButtonPictureBox.MouseEnter += new System.EventHandler(this.RemoveButtonPictureBox_MouseEnter);
            this.removeButtonPictureBox.MouseLeave += new System.EventHandler(this.RemoveButtonPictureBox_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.removeButtonPictureBox);
            this.Controls.Add(this.addButtonPictureBox);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.booksListBox);
            this.Name = "MainForm";
            this.Text = "BooksApp";
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButtonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label pagesNumberLabel;
        private System.Windows.Forms.TextBox pagesNumberTextBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label releaseYearLabel;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.PictureBox addButtonPictureBox;
        private System.Windows.Forms.PictureBox removeButtonPictureBox;
    }
}

