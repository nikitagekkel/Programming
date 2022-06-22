
namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.moviesGroupBox = new System.Windows.Forms.GroupBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.findMoviesButton = new System.Windows.Forms.Button();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.realeaseYearLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.releaseYearTextBox = new System.Windows.Forms.TextBox();
            this.moviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // moviesGroupBox
            // 
            this.moviesGroupBox.Controls.Add(this.ratingLabel);
            this.moviesGroupBox.Controls.Add(this.movieListBox);
            this.moviesGroupBox.Controls.Add(this.findMoviesButton);
            this.moviesGroupBox.Controls.Add(this.ratingTextBox);
            this.moviesGroupBox.Controls.Add(this.nameLabel);
            this.moviesGroupBox.Controls.Add(this.genreLabel);
            this.moviesGroupBox.Controls.Add(this.nameTextBox);
            this.moviesGroupBox.Controls.Add(this.realeaseYearLabel);
            this.moviesGroupBox.Controls.Add(this.durationLabel);
            this.moviesGroupBox.Controls.Add(this.durationTextBox);
            this.moviesGroupBox.Controls.Add(this.genreTextBox);
            this.moviesGroupBox.Controls.Add(this.releaseYearTextBox);
            this.moviesGroupBox.Location = new System.Drawing.Point(8, 8);
            this.moviesGroupBox.Name = "moviesGroupBox";
            this.moviesGroupBox.Size = new System.Drawing.Size(331, 355);
            this.moviesGroupBox.TabIndex = 9;
            this.moviesGroupBox.TabStop = false;
            this.moviesGroupBox.Text = "Movies";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(187, 237);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(55, 20);
            this.ratingLabel.TabIndex = 11;
            this.ratingLabel.Text = "Rating:";
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.ItemHeight = 20;
            this.movieListBox.Location = new System.Drawing.Point(11, 26);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(156, 304);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // findMoviesButton
            // 
            this.findMoviesButton.Location = new System.Drawing.Point(187, 301);
            this.findMoviesButton.Name = "findMoviesButton";
            this.findMoviesButton.Size = new System.Drawing.Size(125, 29);
            this.findMoviesButton.TabIndex = 7;
            this.findMoviesButton.Text = "Find";
            this.findMoviesButton.UseVisualStyleBackColor = true;
            this.findMoviesButton.Click += new System.EventHandler(this.FindMoviesButton_Click);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(187, 260);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(125, 27);
            this.ratingTextBox.TabIndex = 10;
            this.ratingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(187, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 20);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(187, 76);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(51, 20);
            this.genreLabel.TabIndex = 5;
            this.genreLabel.Text = "Genre:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(187, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 27);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // realeaseYearLabel
            // 
            this.realeaseYearLabel.AutoSize = true;
            this.realeaseYearLabel.Location = new System.Drawing.Point(187, 184);
            this.realeaseYearLabel.Name = "realeaseYearLabel";
            this.realeaseYearLabel.Size = new System.Drawing.Size(95, 20);
            this.realeaseYearLabel.TabIndex = 9;
            this.realeaseYearLabel.Text = "Release Year:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(187, 129);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(132, 20);
            this.durationLabel.TabIndex = 6;
            this.durationLabel.Text = "Duration(Minutes):";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(187, 152);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(125, 27);
            this.durationTextBox.TabIndex = 1;
            this.durationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(187, 99);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(125, 27);
            this.genreTextBox.TabIndex = 2;
            this.genreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // releaseYearTextBox
            // 
            this.releaseYearTextBox.Location = new System.Drawing.Point(187, 207);
            this.releaseYearTextBox.Name = "releaseYearTextBox";
            this.releaseYearTextBox.Size = new System.Drawing.Size(125, 27);
            this.releaseYearTextBox.TabIndex = 8;
            this.releaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moviesGroupBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(331, 355);
            this.moviesGroupBox.ResumeLayout(false);
            this.moviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox moviesGroupBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Button findMoviesButton;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label realeaseYearLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox releaseYearTextBox;
    }
}
