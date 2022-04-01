
namespace Lab2
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIntValue = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Button_season_handle = new System.Windows.Forms.Button();
            this.comboBoxSeason = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelparse = new System.Windows.Forms.Label();
            this.textBoxParsing = new System.Windows.Forms.TextBox();
            this.Button_parse = new System.Windows.Forms.Button();
            this.tabControl2.SuspendLayout();
            this.Enums.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Enums);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(788, 438);
            this.tabControl2.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.groupBox1);
            this.Enums.Controls.Add(this.groupBox3);
            this.Enums.Controls.Add(this.groupBox2);
            this.Enums.Location = new System.Drawing.Point(4, 29);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(780, 405);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnumsListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxIntValue);
            this.groupBox1.Controls.Add(this.ValuesListBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 240);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enumerations";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 56);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(155, 164);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enumeration:";
            // 
            // textBoxIntValue
            // 
            this.textBoxIntValue.Location = new System.Drawing.Point(377, 56);
            this.textBoxIntValue.Name = "textBoxIntValue";
            this.textBoxIntValue.ReadOnly = true;
            this.textBoxIntValue.Size = new System.Drawing.Size(108, 27);
            this.textBoxIntValue.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(203, 56);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(148, 164);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Button_season_handle);
            this.groupBox3.Controls.Add(this.comboBoxSeason);
            this.groupBox3.Location = new System.Drawing.Point(393, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Season Handle";
            // 
            // Button_season_handle
            // 
            this.Button_season_handle.Location = new System.Drawing.Point(255, 41);
            this.Button_season_handle.Name = "Button_season_handle";
            this.Button_season_handle.Size = new System.Drawing.Size(105, 29);
            this.Button_season_handle.TabIndex = 5;
            this.Button_season_handle.Text = "Go!";
            this.Button_season_handle.UseVisualStyleBackColor = true;
            this.Button_season_handle.Click += new System.EventHandler(this.Button_season_handle_Click);
            // 
            // comboBoxSeason
            // 
            this.comboBoxSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeason.FormattingEnabled = true;
            this.comboBoxSeason.Location = new System.Drawing.Point(6, 42);
            this.comboBoxSeason.Name = "comboBoxSeason";
            this.comboBoxSeason.Size = new System.Drawing.Size(243, 28);
            this.comboBoxSeason.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelparse);
            this.groupBox2.Controls.Add(this.textBoxParsing);
            this.groupBox2.Controls.Add(this.Button_parse);
            this.groupBox2.Location = new System.Drawing.Point(22, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weekday Parsing";
            // 
            // labelparse
            // 
            this.labelparse.AutoSize = true;
            this.labelparse.Location = new System.Drawing.Point(12, 77);
            this.labelparse.Name = "labelparse";
            this.labelparse.Size = new System.Drawing.Size(0, 20);
            this.labelparse.TabIndex = 0;
            // 
            // textBoxParsing
            // 
            this.textBoxParsing.Location = new System.Drawing.Point(12, 41);
            this.textBoxParsing.Name = "textBoxParsing";
            this.textBoxParsing.Size = new System.Drawing.Size(210, 27);
            this.textBoxParsing.TabIndex = 1;
            // 
            // Button_parse
            // 
            this.Button_parse.Location = new System.Drawing.Point(228, 41);
            this.Button_parse.Name = "Button_parse";
            this.Button_parse.Size = new System.Drawing.Size(117, 29);
            this.Button_parse.TabIndex = 3;
            this.Button_parse.Text = "Parse";
            this.Button_parse.UseVisualStyleBackColor = true;
            this.Button_parse.Click += new System.EventHandler(this.Button_parse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl2.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TextBox textBoxIntValue;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ComboBox comboBoxSeason;
        private System.Windows.Forms.Button Button_parse;
        private System.Windows.Forms.TextBox textBoxParsing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelparse;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_season_handle;
    }
}

