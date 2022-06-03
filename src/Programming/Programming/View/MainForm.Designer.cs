
namespace Programming
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.enumsTabPage = new System.Windows.Forms.TabPage();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.enumsListBox = new System.Windows.Forms.ListBox();
            this.intValueLabel = new System.Windows.Forms.Label();
            this.сhooseValueLabel = new System.Windows.Forms.Label();
            this.enumerationLabel = new System.Windows.Forms.Label();
            this.intValueTextBox = new System.Windows.Forms.TextBox();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.seasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseSeasonLabel = new System.Windows.Forms.Label();
            this.seasonComboBox = new System.Windows.Forms.ComboBox();
            this.seasonHandleButton = new System.Windows.Forms.Button();
            this.parsingGroupBox = new System.Windows.Forms.GroupBox();
            this.parseLabel = new System.Windows.Forms.Label();
            this.parseButton = new System.Windows.Forms.Button();
            this.typeValueLabel = new System.Windows.Forms.Label();
            this.parsingTextBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.FindMoviesButton = new System.Windows.Forms.Button();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.YearRealeseLabel = new System.Windows.Forms.Label();
            this.TimingLabel = new System.Windows.Forms.Label();
            this.timingTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.yearRealseTextBox = new System.Windows.Forms.TextBox();
            this.ClassesGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.coordinateYTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FindRectanglesButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.lenghtTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.coordinateXTextBox = new System.Windows.Forms.TextBox();
            this.MainTabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.seasonHandleGroupBox.SuspendLayout();
            this.parsingGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ClassesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.enumsTabPage);
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(719, 559);
            this.MainTabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.Controls.Add(this.EnumsGroupBox);
            this.enumsTabPage.Controls.Add(this.seasonHandleGroupBox);
            this.enumsTabPage.Controls.Add(this.parsingGroupBox);
            this.enumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enumsTabPage.Size = new System.Drawing.Size(711, 526);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            this.enumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.enumsListBox);
            this.EnumsGroupBox.Controls.Add(this.intValueLabel);
            this.EnumsGroupBox.Controls.Add(this.сhooseValueLabel);
            this.EnumsGroupBox.Controls.Add(this.enumerationLabel);
            this.EnumsGroupBox.Controls.Add(this.intValueTextBox);
            this.EnumsGroupBox.Controls.Add(this.valuesListBox);
            this.EnumsGroupBox.Location = new System.Drawing.Point(7, 12);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(707, 361);
            this.EnumsGroupBox.TabIndex = 5;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // enumsListBox
            // 
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
            this.intValueTextBox.Location = new System.Drawing.Point(365, 56);
            this.intValueTextBox.Name = "intValueTextBox";
            this.intValueTextBox.ReadOnly = true;
            this.intValueTextBox.Size = new System.Drawing.Size(149, 27);
            this.intValueTextBox.TabIndex = 2;
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.ItemHeight = 20;
            this.valuesListBox.Location = new System.Drawing.Point(189, 56);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.ScrollAlwaysVisible = true;
            this.valuesListBox.Size = new System.Drawing.Size(156, 284);
            this.valuesListBox.TabIndex = 1;
            this.valuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // seasonHandleGroupBox
            // 
            this.seasonHandleGroupBox.Controls.Add(this.chooseSeasonLabel);
            this.seasonHandleGroupBox.Controls.Add(this.seasonComboBox);
            this.seasonHandleGroupBox.Controls.Add(this.seasonHandleButton);
            this.seasonHandleGroupBox.Location = new System.Drawing.Point(361, 379);
            this.seasonHandleGroupBox.Name = "seasonHandleGroupBox";
            this.seasonHandleGroupBox.Size = new System.Drawing.Size(353, 145);
            this.seasonHandleGroupBox.TabIndex = 2;
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
            // parsingGroupBox
            // 
            this.parsingGroupBox.Controls.Add(this.parseLabel);
            this.parsingGroupBox.Controls.Add(this.parseButton);
            this.parsingGroupBox.Controls.Add(this.typeValueLabel);
            this.parsingGroupBox.Controls.Add(this.parsingTextBox);
            this.parsingGroupBox.Location = new System.Drawing.Point(7, 379);
            this.parsingGroupBox.Name = "parsingGroupBox";
            this.parsingGroupBox.Size = new System.Drawing.Size(347, 145);
            this.parsingGroupBox.TabIndex = 1;
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ClassesGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 526);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RatingLabel);
            this.groupBox1.Controls.Add(this.movieListBox);
            this.groupBox1.Controls.Add(this.FindMoviesButton);
            this.groupBox1.Controls.Add(this.ratingTextBox);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.GenreLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.YearRealeseLabel);
            this.groupBox1.Controls.Add(this.TimingLabel);
            this.groupBox1.Controls.Add(this.timingTextBox);
            this.groupBox1.Controls.Add(this.genreTextBox);
            this.groupBox1.Controls.Add(this.yearRealseTextBox);
            this.groupBox1.Location = new System.Drawing.Point(363, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 355);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectangles";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(196, 237);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(55, 20);
            this.RatingLabel.TabIndex = 11;
            this.RatingLabel.Text = "Rating:";
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
            // FindMoviesButton
            // 
            this.FindMoviesButton.Location = new System.Drawing.Point(196, 301);
            this.FindMoviesButton.Name = "FindMoviesButton";
            this.FindMoviesButton.Size = new System.Drawing.Size(125, 29);
            this.FindMoviesButton.TabIndex = 7;
            this.FindMoviesButton.Text = "Find";
            this.FindMoviesButton.UseVisualStyleBackColor = true;
            this.FindMoviesButton.Click += new System.EventHandler(this.FindMoviesButton_Click);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(196, 260);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(125, 27);
            this.ratingTextBox.TabIndex = 10;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(196, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(196, 76);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(196, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 27);
            this.nameTextBox.TabIndex = 3;
            // 
            // YearRealeseLabel
            // 
            this.YearRealeseLabel.AutoSize = true;
            this.YearRealeseLabel.Location = new System.Drawing.Point(196, 184);
            this.YearRealeseLabel.Name = "YearRealeseLabel";
            this.YearRealeseLabel.Size = new System.Drawing.Size(95, 20);
            this.YearRealeseLabel.TabIndex = 9;
            this.YearRealeseLabel.Text = "Year Realese:";
            // 
            // TimingLabel
            // 
            this.TimingLabel.AutoSize = true;
            this.TimingLabel.Location = new System.Drawing.Point(196, 129);
            this.TimingLabel.Name = "TimingLabel";
            this.TimingLabel.Size = new System.Drawing.Size(123, 20);
            this.TimingLabel.TabIndex = 6;
            this.TimingLabel.Text = "Timing(Seconds):";
            // 
            // timingTextBox
            // 
            this.timingTextBox.Location = new System.Drawing.Point(196, 152);
            this.timingTextBox.Name = "timingTextBox";
            this.timingTextBox.Size = new System.Drawing.Size(125, 27);
            this.timingTextBox.TabIndex = 1;
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(196, 99);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(125, 27);
            this.genreTextBox.TabIndex = 2;
            // 
            // yearRealseTextBox
            // 
            this.yearRealseTextBox.Location = new System.Drawing.Point(196, 207);
            this.yearRealseTextBox.Name = "yearRealseTextBox";
            this.yearRealseTextBox.Size = new System.Drawing.Size(125, 27);
            this.yearRealseTextBox.TabIndex = 8;
            // 
            // ClassesGroupBox
            // 
            this.ClassesGroupBox.Controls.Add(this.label2);
            this.ClassesGroupBox.Controls.Add(this.coordinateYTextBox);
            this.ClassesGroupBox.Controls.Add(this.label1);
            this.ClassesGroupBox.Controls.Add(this.coordinateXTextBox);
            this.ClassesGroupBox.Controls.Add(this.FindRectanglesButton);
            this.ClassesGroupBox.Controls.Add(this.ColorLabel);
            this.ClassesGroupBox.Controls.Add(this.WidthLabel);
            this.ClassesGroupBox.Controls.Add(this.LenghtLabel);
            this.ClassesGroupBox.Controls.Add(this.lenghtTextBox);
            this.ClassesGroupBox.Controls.Add(this.widthTextBox);
            this.ClassesGroupBox.Controls.Add(this.colorTextBox);
            this.ClassesGroupBox.Controls.Add(this.rectanglesListBox);
            this.ClassesGroupBox.Location = new System.Drawing.Point(8, 11);
            this.ClassesGroupBox.Name = "ClassesGroupBox";
            this.ClassesGroupBox.Size = new System.Drawing.Size(331, 355);
            this.ClassesGroupBox.TabIndex = 0;
            this.ClassesGroupBox.TabStop = false;
            this.ClassesGroupBox.Text = "Rectangles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coordinate Y:";
            // 
            // coordinateYTextBox
            // 
            this.coordinateYTextBox.Location = new System.Drawing.Point(187, 260);
            this.coordinateYTextBox.Name = "coordinateYTextBox";
            this.coordinateYTextBox.Size = new System.Drawing.Size(125, 27);
            this.coordinateYTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Coorditane X:";
            // 
            // FindRectanglesButton
            // 
            this.FindRectanglesButton.Location = new System.Drawing.Point(187, 301);
            this.FindRectanglesButton.Name = "FindRectanglesButton";
            this.FindRectanglesButton.Size = new System.Drawing.Size(125, 29);
            this.FindRectanglesButton.TabIndex = 7;
            this.FindRectanglesButton.Text = "Find";
            this.FindRectanglesButton.UseVisualStyleBackColor = true;
            this.FindRectanglesButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(187, 132);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 20);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(187, 79);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Width:";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(187, 26);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(57, 20);
            this.LenghtLabel.TabIndex = 4;
            this.LenghtLabel.Text = "Lenght:";
            // 
            // lenghtTextBox
            // 
            this.lenghtTextBox.Location = new System.Drawing.Point(187, 49);
            this.lenghtTextBox.Name = "lenghtTextBox";
            this.lenghtTextBox.Size = new System.Drawing.Size(125, 27);
            this.lenghtTextBox.TabIndex = 3;
            this.lenghtTextBox.TextChanged += new System.EventHandler(this.LenghtTextBox_TextChanged);
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(187, 102);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(125, 27);
            this.widthTextBox.TabIndex = 2;
            this.widthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(187, 155);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(125, 27);
            this.colorTextBox.TabIndex = 1;
            // 
            // rectanglesListBox
            // 
            this.rectanglesListBox.FormattingEnabled = true;
            this.rectanglesListBox.ItemHeight = 20;
            this.rectanglesListBox.Location = new System.Drawing.Point(11, 26);
            this.rectanglesListBox.Name = "rectanglesListBox";
            this.rectanglesListBox.Size = new System.Drawing.Size(156, 304);
            this.rectanglesListBox.TabIndex = 0;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // coordinateXTextBox
            // 
            this.coordinateXTextBox.Location = new System.Drawing.Point(187, 207);
            this.coordinateXTextBox.Name = "coordinateXTextBox";
            this.coordinateXTextBox.Size = new System.Drawing.Size(125, 27);
            this.coordinateXTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 571);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Demo";
            this.MainTabControl.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.seasonHandleGroupBox.ResumeLayout(false);
            this.seasonHandleGroupBox.PerformLayout();
            this.parsingGroupBox.ResumeLayout(false);
            this.parsingGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ClassesGroupBox.ResumeLayout(false);
            this.ClassesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage enumsTabPage;
        private System.Windows.Forms.TextBox intValueTextBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox parsingTextBox;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.Label parseLabel;
        private System.Windows.Forms.GroupBox seasonHandleGroupBox;
        private System.Windows.Forms.GroupBox parsingGroupBox;
        private System.Windows.Forms.Label сhooseValueLabel;
        private System.Windows.Forms.Label enumerationLabel;
        private System.Windows.Forms.Label intValueLabel;
        private System.Windows.Forms.Button seasonHandleButton;
        private System.Windows.Forms.Label typeValueLabel;
        private System.Windows.Forms.Label chooseSeasonLabel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox ClassesGroupBox;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Button FindRectanglesButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.TextBox lenghtTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FindMoviesButton;
        private System.Windows.Forms.Label TimingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox timingTextBox;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Label YearRealeseLabel;
        private System.Windows.Forms.TextBox yearRealseTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coordinateYTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coordinateXTextBox;
    }
}

