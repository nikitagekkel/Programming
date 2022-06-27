
namespace BooksApp
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
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.addButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.removeButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.pagesNumberLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.pagesNumberTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.yearReleaseLabel = new System.Windows.Forms.Label();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.titleBookTextBox = new System.Windows.Forms.TextBox();
            this.editButtonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButtonPictureBox)).BeginInit();
            this.mainGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButtonPictureBox)).BeginInit();
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
            this.booksListBox.Size = new System.Drawing.Size(263, 404);
            this.booksListBox.TabIndex = 0;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.BooksListBox_SelectedIndexChanged);
            // 
            // addButtonPictureBox
            // 
            this.addButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButtonPictureBox.Image = global::BooksApp.Properties.Resources.add_24x24_uncolor;
            this.addButtonPictureBox.Location = new System.Drawing.Point(12, 422);
            this.addButtonPictureBox.Name = "addButtonPictureBox";
            this.addButtonPictureBox.Size = new System.Drawing.Size(33, 35);
            this.addButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addButtonPictureBox.TabIndex = 1;
            this.addButtonPictureBox.TabStop = false;
            this.addButtonPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddButtonPictureBox_MouseClick);
            this.addButtonPictureBox.MouseEnter += new System.EventHandler(this.AddButtonPictureBox_MouseEnter);
            this.addButtonPictureBox.MouseLeave += new System.EventHandler(this.AddButtonPictureBox_MouseLeave);
            // 
            // removeButtonPictureBox
            // 
            this.removeButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeButtonPictureBox.Image = global::BooksApp.Properties.Resources.remove_24x24_uncolor;
            this.removeButtonPictureBox.Location = new System.Drawing.Point(90, 422);
            this.removeButtonPictureBox.Name = "removeButtonPictureBox";
            this.removeButtonPictureBox.Size = new System.Drawing.Size(33, 35);
            this.removeButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeButtonPictureBox.TabIndex = 2;
            this.removeButtonPictureBox.TabStop = false;
            this.removeButtonPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveButtonPictureBox_MouseClick);
            this.removeButtonPictureBox.MouseEnter += new System.EventHandler(this.RemoveButtonPictureBox_MouseEnter);
            this.removeButtonPictureBox.MouseLeave += new System.EventHandler(this.RemoveButtonPictureBox_MouseLeave);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainGroupBox.Controls.Add(this.genreLabel);
            this.mainGroupBox.Controls.Add(this.genreComboBox);
            this.mainGroupBox.Controls.Add(this.pagesNumberLabel);
            this.mainGroupBox.Controls.Add(this.authorLabel);
            this.mainGroupBox.Controls.Add(this.pagesNumberTextBox);
            this.mainGroupBox.Controls.Add(this.authorTextBox);
            this.mainGroupBox.Controls.Add(this.yearReleaseLabel);
            this.mainGroupBox.Controls.Add(this.releaseYearTextBox);
            this.mainGroupBox.Controls.Add(this.bookTitleLabel);
            this.mainGroupBox.Controls.Add(this.titleBookTextBox);
            this.mainGroupBox.Location = new System.Drawing.Point(281, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(507, 230);
            this.mainGroupBox.TabIndex = 3;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Selected Book";
            // 
            // genreLabel
            // 
            this.genreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(83, 161);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(51, 20);
            this.genreLabel.TabIndex = 7;
            this.genreLabel.Text = "Genre:";
            // 
            // genreComboBox
            // 
            this.genreComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(140, 158);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(100, 28);
            this.genreComboBox.TabIndex = 6;
            this.genreComboBox.TextChanged += new System.EventHandler(this.GenreComboBox_TextChanged);
            // 
            // pagesNumberLabel
            // 
            this.pagesNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pagesNumberLabel.AutoSize = true;
            this.pagesNumberLabel.Location = new System.Drawing.Point(8, 128);
            this.pagesNumberLabel.Name = "pagesNumberLabel";
            this.pagesNumberLabel.Size = new System.Drawing.Size(126, 20);
            this.pagesNumberLabel.TabIndex = 5;
            this.pagesNumberLabel.Text = "Number of Pages:";
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(77, 95);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(57, 20);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author:";
            // 
            // pagesNumberTextBox
            // 
            this.pagesNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pagesNumberTextBox.Location = new System.Drawing.Point(140, 125);
            this.pagesNumberTextBox.Name = "pagesNumberTextBox";
            this.pagesNumberTextBox.Size = new System.Drawing.Size(56, 27);
            this.pagesNumberTextBox.TabIndex = 4;
            this.pagesNumberTextBox.TextChanged += new System.EventHandler(this.PagesNumberTextBox_TextChanged);
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.Location = new System.Drawing.Point(140, 92);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(313, 27);
            this.authorTextBox.TabIndex = 4;
            this.authorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // yearReleaseLabel
            // 
            this.yearReleaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.yearReleaseLabel.AutoSize = true;
            this.yearReleaseLabel.Location = new System.Drawing.Point(39, 62);
            this.yearReleaseLabel.Name = "yearReleaseLabel";
            this.yearReleaseLabel.Size = new System.Drawing.Size(95, 20);
            this.yearReleaseLabel.TabIndex = 3;
            this.yearReleaseLabel.Text = "Release Year:";
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.releaseYearTextBox.Location = new System.Drawing.Point(140, 59);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(56, 27);
            this.releaseYearTextBox.TabIndex = 2;
            this.releaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Location = new System.Drawing.Point(55, 29);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(79, 20);
            this.bookTitleLabel.TabIndex = 1;
            this.bookTitleLabel.Text = "Book Title:";
            // 
            // titleBookTextBox
            // 
            this.titleBookTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBookTextBox.Location = new System.Drawing.Point(140, 26);
            this.titleBookTextBox.Name = "titleBookTextBox";
            this.titleBookTextBox.Size = new System.Drawing.Size(313, 27);
            this.titleBookTextBox.TabIndex = 0;
            this.titleBookTextBox.TextChanged += new System.EventHandler(this.TitleBookTextBox_TextChanged);
            // 
            // editButtonPictureBox
            // 
            this.editButtonPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editButtonPictureBox.Image = global::BooksApp.Properties.Resources.edit_24x24_uncolor;
            this.editButtonPictureBox.Location = new System.Drawing.Point(51, 422);
            this.editButtonPictureBox.Name = "editButtonPictureBox";
            this.editButtonPictureBox.Size = new System.Drawing.Size(33, 35);
            this.editButtonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.editButtonPictureBox.TabIndex = 4;
            this.editButtonPictureBox.TabStop = false;
            this.editButtonPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditButtonPictureBox_MouseClick);
            this.editButtonPictureBox.MouseEnter += new System.EventHandler(this.EditButtonPictureBox_MouseEnter);
            this.editButtonPictureBox.MouseLeave += new System.EventHandler(this.EditButtonPictureBox_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.editButtonPictureBox);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.removeButtonPictureBox);
            this.Controls.Add(this.addButtonPictureBox);
            this.Controls.Add(this.booksListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BooksApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.addButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeButtonPictureBox)).EndInit();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editButtonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.PictureBox addButtonPictureBox;
        private System.Windows.Forms.PictureBox removeButtonPictureBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.TextBox titleBookTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label pagesNumberLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.TextBox pagesNumberTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label yearReleaseLabel;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.PictureBox editButtonPictureBox;
    }
}

