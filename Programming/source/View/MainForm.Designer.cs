
namespace Lab2
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControlEnums = new System.Windows.Forms.TabControl();
            this.enumsTabPage = new System.Windows.Forms.TabPage();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.listBoxEnums = new System.Windows.Forms.ListBox();
            this.labeIntValue = new System.Windows.Forms.Label();
            this.labelChooseValue = new System.Windows.Forms.Label();
            this.labelEnumaration = new System.Windows.Forms.Label();
            this.textBoxIntValue = new System.Windows.Forms.TextBox();
            this.listBoxValues = new System.Windows.Forms.ListBox();
            this.groupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.labelChooseSeason = new System.Windows.Forms.Label();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.buttonSeasonHandle = new System.Windows.Forms.Button();
            this.groupBoxParsing = new System.Windows.Forms.GroupBox();
            this.labelParse = new System.Windows.Forms.Label();
            this.buttonParse = new System.Windows.Forms.Button();
            this.labelTypeValue = new System.Windows.Forms.Label();
            this.textBoxParsing = new System.Windows.Forms.TextBox();
            this.tabControlEnums.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.groupBoxSeasonHandle.SuspendLayout();
            this.groupBoxParsing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlEnums
            // 
            this.tabControlEnums.Controls.Add(this.enumsTabPage);
            this.tabControlEnums.Location = new System.Drawing.Point(0, 0);
            this.tabControlEnums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlEnums.Name = "tabControlEnums";
            this.tabControlEnums.SelectedIndex = 0;
            this.tabControlEnums.Size = new System.Drawing.Size(642, 427);
            this.tabControlEnums.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.Controls.Add(this.mainGroupBox);
            this.enumsTabPage.Controls.Add(this.groupBoxSeasonHandle);
            this.enumsTabPage.Controls.Add(this.groupBoxParsing);
            this.enumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.enumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enumsTabPage.Size = new System.Drawing.Size(634, 399);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            this.enumsTabPage.UseVisualStyleBackColor = true;
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.listBoxEnums);
            this.mainGroupBox.Controls.Add(this.labeIntValue);
            this.mainGroupBox.Controls.Add(this.labelChooseValue);
            this.mainGroupBox.Controls.Add(this.labelEnumaration);
            this.mainGroupBox.Controls.Add(this.textBoxIntValue);
            this.mainGroupBox.Controls.Add(this.listBoxValues);
            this.mainGroupBox.Location = new System.Drawing.Point(6, 9);
            this.mainGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainGroupBox.Size = new System.Drawing.Size(619, 271);
            this.mainGroupBox.TabIndex = 5;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Enumerations";
            // 
            // listBoxEnums
            // 
            this.listBoxEnums.FormattingEnabled = true;
            this.listBoxEnums.ItemHeight = 15;
            this.listBoxEnums.Location = new System.Drawing.Point(10, 42);
            this.listBoxEnums.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEnums.Name = "listBoxEnums";
            this.listBoxEnums.ScrollAlwaysVisible = true;
            this.listBoxEnums.Size = new System.Drawing.Size(137, 214);
            this.listBoxEnums.TabIndex = 0;
            this.listBoxEnums.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // labeIntValue
            // 
            this.labeIntValue.AutoSize = true;
            this.labeIntValue.Location = new System.Drawing.Point(319, 25);
            this.labeIntValue.Name = "labeIntValue";
            this.labeIntValue.Size = new System.Drawing.Size(55, 15);
            this.labeIntValue.TabIndex = 5;
            this.labeIntValue.Text = "Int value:";
            // 
            // labelChooseValue
            // 
            this.labelChooseValue.AutoSize = true;
            this.labelChooseValue.Location = new System.Drawing.Point(165, 25);
            this.labelChooseValue.Name = "labelChooseValue";
            this.labelChooseValue.Size = new System.Drawing.Size(81, 15);
            this.labelChooseValue.TabIndex = 4;
            this.labelChooseValue.Text = "Choose value:";
            // 
            // labelEnumaration
            // 
            this.labelEnumaration.AutoSize = true;
            this.labelEnumaration.Location = new System.Drawing.Point(10, 25);
            this.labelEnumaration.Name = "labelEnumaration";
            this.labelEnumaration.Size = new System.Drawing.Size(121, 15);
            this.labelEnumaration.TabIndex = 3;
            this.labelEnumaration.Text = "Choose enumaration:";
            // 
            // textBoxIntValue
            // 
            this.textBoxIntValue.Location = new System.Drawing.Point(319, 42);
            this.textBoxIntValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxIntValue.Name = "textBoxIntValue";
            this.textBoxIntValue.ReadOnly = true;
            this.textBoxIntValue.Size = new System.Drawing.Size(131, 23);
            this.textBoxIntValue.TabIndex = 2;
            // 
            // listBoxValues
            // 
            this.listBoxValues.FormattingEnabled = true;
            this.listBoxValues.ItemHeight = 15;
            this.listBoxValues.Location = new System.Drawing.Point(165, 42);
            this.listBoxValues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxValues.Name = "listBoxValues";
            this.listBoxValues.ScrollAlwaysVisible = true;
            this.listBoxValues.Size = new System.Drawing.Size(137, 214);
            this.listBoxValues.TabIndex = 1;
            this.listBoxValues.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // groupBoxSeasonHandle
            // 
            this.groupBoxSeasonHandle.Controls.Add(this.labelChooseSeason);
            this.groupBoxSeasonHandle.Controls.Add(this.comboBoxSeason);
            this.groupBoxSeasonHandle.Controls.Add(this.buttonSeasonHandle);
            this.groupBoxSeasonHandle.Location = new System.Drawing.Point(316, 284);
            this.groupBoxSeasonHandle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSeasonHandle.Name = "groupBoxSeasonHandle";
            this.groupBoxSeasonHandle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSeasonHandle.Size = new System.Drawing.Size(309, 109);
            this.groupBoxSeasonHandle.TabIndex = 2;
            this.groupBoxSeasonHandle.TabStop = false;
            this.groupBoxSeasonHandle.Text = "Season Handle";
            // 
            // labelChooseSeason
            // 
            this.labelChooseSeason.AutoSize = true;
            this.labelChooseSeason.Location = new System.Drawing.Point(9, 30);
            this.labelChooseSeason.Name = "labelChooseSeason";
            this.labelChooseSeason.Size = new System.Drawing.Size(89, 15);
            this.labelChooseSeason.TabIndex = 7;
            this.labelChooseSeason.Text = "Choose season:";
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(9, 51);
            this.comboBoxSeason.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(188, 23);
            this.comboBoxSeason.TabIndex = 4;
            // 
            // buttonSeasonHandle
            // 
            this.buttonSeasonHandle.Location = new System.Drawing.Point(203, 51);
            this.buttonSeasonHandle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSeasonHandle.Name = "buttonSeasonHandle";
            this.buttonSeasonHandle.Size = new System.Drawing.Size(92, 25);
            this.buttonSeasonHandle.TabIndex = 5;
            this.buttonSeasonHandle.Text = "Go!";
            this.buttonSeasonHandle.UseVisualStyleBackColor = true;
            this.buttonSeasonHandle.Click += new System.EventHandler(this.Button_season_handle_Click);
            // 
            // groupBoxParsing
            // 
            this.groupBoxParsing.Controls.Add(this.labelParse);
            this.groupBoxParsing.Controls.Add(this.buttonParse);
            this.groupBoxParsing.Controls.Add(this.labelTypeValue);
            this.groupBoxParsing.Controls.Add(this.textBoxParsing);
            this.groupBoxParsing.Location = new System.Drawing.Point(6, 284);
            this.groupBoxParsing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxParsing.Name = "groupBoxParsing";
            this.groupBoxParsing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxParsing.Size = new System.Drawing.Size(304, 109);
            this.groupBoxParsing.TabIndex = 1;
            this.groupBoxParsing.TabStop = false;
            this.groupBoxParsing.Text = "Weekday Parsing";
            // 
            // labelParse
            // 
            this.labelParse.AutoSize = true;
            this.labelParse.Location = new System.Drawing.Point(10, 75);
            this.labelParse.Name = "labelParse";
            this.labelParse.Size = new System.Drawing.Size(0, 15);
            this.labelParse.TabIndex = 0;
            // 
            // buttonParse
            // 
            this.buttonParse.Location = new System.Drawing.Point(204, 49);
            this.buttonParse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonParse.Name = "buttonParse";
            this.buttonParse.Size = new System.Drawing.Size(92, 25);
            this.buttonParse.TabIndex = 3;
            this.buttonParse.Text = "Parse";
            this.buttonParse.UseVisualStyleBackColor = true;
            this.buttonParse.Click += new System.EventHandler(this.Button_parse_Click);
            // 
            // labelTypeValue
            // 
            this.labelTypeValue.AutoSize = true;
            this.labelTypeValue.Location = new System.Drawing.Point(10, 30);
            this.labelTypeValue.Name = "labelTypeValue";
            this.labelTypeValue.Size = new System.Drawing.Size(125, 15);
            this.labelTypeValue.TabIndex = 6;
            this.labelTypeValue.Text = "Type value for parsing:";
            // 
            // textBoxParsing
            // 
            this.textBoxParsing.Location = new System.Drawing.Point(10, 50);
            this.textBoxParsing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxParsing.Name = "textBoxParsing";
            this.textBoxParsing.Size = new System.Drawing.Size(188, 23);
            this.textBoxParsing.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 428);
            this.Controls.Add(this.tabControlEnums);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Demo";
            this.tabControlEnums.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.groupBoxSeasonHandle.ResumeLayout(false);
            this.groupBoxSeasonHandle.PerformLayout();
            this.groupBoxParsing.ResumeLayout(false);
            this.groupBoxParsing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEnums;
        private System.Windows.Forms.TabPage enumsTabPage;
        private System.Windows.Forms.TextBox textBoxIntValue;
        private System.Windows.Forms.ListBox listBoxValues;
        private System.Windows.Forms.ListBox listBoxEnums;
        private System.Windows.Forms.ComboBox comboBoxSeason;
        private System.Windows.Forms.Button buttonParse;
        private System.Windows.Forms.TextBox textBoxParsing;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Label labelParse;
        private System.Windows.Forms.GroupBox groupBoxSeasonHandle;
        private System.Windows.Forms.GroupBox groupBoxParsing;
        private System.Windows.Forms.Label labelChooseValue;
        private System.Windows.Forms.Label labelEnumaration;
        private System.Windows.Forms.Label labeIntValue;
        private System.Windows.Forms.Button buttonSeasonHandle;
        private System.Windows.Forms.Label labelTypeValue;
        private System.Windows.Forms.Label labelChooseSeason;
    }
}

