
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.enumsTabPage = new System.Windows.Forms.TabPage();
            this.enumsGroupBox = new System.Windows.Forms.GroupBox();
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
            this.classesGroupBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.findRectanglesButton = new System.Windows.Forms.Button();
            this.yLabel = new System.Windows.Forms.Label();
            this.coordinateYTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.coordinateXTextBox = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lenghtTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.rectanglesListBox = new System.Windows.Forms.ListBox();
            this.mainTabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.enumsGroupBox.SuspendLayout();
            this.seasonHandleGroupBox.SuspendLayout();
            this.parsingGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.moviesGroupBox.SuspendLayout();
            this.classesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.enumsTabPage);
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(719, 559);
            this.mainTabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.Controls.Add(this.enumsGroupBox);
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
            // enumsGroupBox
            // 
            this.enumsGroupBox.Controls.Add(this.enumsListBox);
            this.enumsGroupBox.Controls.Add(this.intValueLabel);
            this.enumsGroupBox.Controls.Add(this.сhooseValueLabel);
            this.enumsGroupBox.Controls.Add(this.enumerationLabel);
            this.enumsGroupBox.Controls.Add(this.intValueTextBox);
            this.enumsGroupBox.Controls.Add(this.valuesListBox);
            this.enumsGroupBox.Location = new System.Drawing.Point(7, 12);
            this.enumsGroupBox.Name = "enumsGroupBox";
            this.enumsGroupBox.Size = new System.Drawing.Size(691, 361);
            this.enumsGroupBox.TabIndex = 5;
            this.enumsGroupBox.TabStop = false;
            this.enumsGroupBox.Text = "Enumerations";
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
            this.seasonHandleGroupBox.Size = new System.Drawing.Size(337, 145);
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
            this.tabPage1.Controls.Add(this.moviesGroupBox);
            this.tabPage1.Controls.Add(this.classesGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 526);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Classes";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.moviesGroupBox.Location = new System.Drawing.Point(363, 12);
            this.moviesGroupBox.Name = "moviesGroupBox";
            this.moviesGroupBox.Size = new System.Drawing.Size(331, 355);
            this.moviesGroupBox.TabIndex = 8;
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
            this.durationLabel.Size = new System.Drawing.Size(135, 20);
            this.durationLabel.TabIndex = 6;
            this.durationLabel.Text = "Duration(Seconds):";
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
            this.releaseYearTextBox.TextChanged += new System.EventHandler(this.RealeseYearTextBox_TextChanged);
            // 
            // classesGroupBox
            // 
            this.classesGroupBox.Controls.Add(this.idLabel);
            this.classesGroupBox.Controls.Add(this.idTextBox);
            this.classesGroupBox.Controls.Add(this.findRectanglesButton);
            this.classesGroupBox.Controls.Add(this.yLabel);
            this.classesGroupBox.Controls.Add(this.coordinateYTextBox);
            this.classesGroupBox.Controls.Add(this.xLabel);
            this.classesGroupBox.Controls.Add(this.coordinateXTextBox);
            this.classesGroupBox.Controls.Add(this.colorLabel);
            this.classesGroupBox.Controls.Add(this.widthLabel);
            this.classesGroupBox.Controls.Add(this.lengthLabel);
            this.classesGroupBox.Controls.Add(this.lenghtTextBox);
            this.classesGroupBox.Controls.Add(this.widthTextBox);
            this.classesGroupBox.Controls.Add(this.colorTextBox);
            this.classesGroupBox.Controls.Add(this.rectanglesListBox);
            this.classesGroupBox.Location = new System.Drawing.Point(7, 12);
            this.classesGroupBox.Name = "classesGroupBox";
            this.classesGroupBox.Size = new System.Drawing.Size(331, 413);
            this.classesGroupBox.TabIndex = 0;
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
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(187, 313);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(125, 27);
            this.idTextBox.TabIndex = 12;
            // 
            // findRectanglesButton
            // 
            this.findRectanglesButton.Location = new System.Drawing.Point(187, 363);
            this.findRectanglesButton.Name = "findRectanglesButton";
            this.findRectanglesButton.Size = new System.Drawing.Size(125, 27);
            this.findRectanglesButton.TabIndex = 7;
            this.findRectanglesButton.Text = "Find";
            this.findRectanglesButton.UseVisualStyleBackColor = true;
            this.findRectanglesButton.Click += new System.EventHandler(this.FindRectanglesButton_Click);
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
            // coordinateYTextBox
            // 
            this.coordinateYTextBox.Location = new System.Drawing.Point(187, 260);
            this.coordinateYTextBox.Name = "coordinateYTextBox";
            this.coordinateYTextBox.ReadOnly = true;
            this.coordinateYTextBox.Size = new System.Drawing.Size(125, 27);
            this.coordinateYTextBox.TabIndex = 10;
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
            // coordinateXTextBox
            // 
            this.coordinateXTextBox.Location = new System.Drawing.Point(187, 207);
            this.coordinateXTextBox.Name = "coordinateXTextBox";
            this.coordinateXTextBox.ReadOnly = true;
            this.coordinateXTextBox.Size = new System.Drawing.Size(125, 27);
            this.coordinateXTextBox.TabIndex = 8;
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
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(187, 26);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(57, 20);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length:";
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
            this.rectanglesListBox.Size = new System.Drawing.Size(156, 364);
            this.rectanglesListBox.TabIndex = 0;
            this.rectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 571);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Demo";
            this.mainTabControl.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.enumsGroupBox.ResumeLayout(false);
            this.enumsGroupBox.PerformLayout();
            this.seasonHandleGroupBox.ResumeLayout(false);
            this.seasonHandleGroupBox.PerformLayout();
            this.parsingGroupBox.ResumeLayout(false);
            this.parsingGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.moviesGroupBox.ResumeLayout(false);
            this.moviesGroupBox.PerformLayout();
            this.classesGroupBox.ResumeLayout(false);
            this.classesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage enumsTabPage;
        private System.Windows.Forms.TextBox intValueTextBox;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.ListBox enumsListBox;
        private System.Windows.Forms.ComboBox seasonComboBox;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.TextBox parsingTextBox;
        private System.Windows.Forms.GroupBox enumsGroupBox;
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
        private System.Windows.Forms.GroupBox classesGroupBox;
        private System.Windows.Forms.ListBox rectanglesListBox;
        private System.Windows.Forms.Button findRectanglesButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lenghtTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.GroupBox moviesGroupBox;
        private System.Windows.Forms.Button findMoviesButton;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Label realeaseYearLabel;
        private System.Windows.Forms.TextBox releaseYearTextBox;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox coordinateYTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox coordinateXTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

