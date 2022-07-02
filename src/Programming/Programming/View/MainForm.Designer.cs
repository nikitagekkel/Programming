
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
            this.seansonHandleControl1 = new Programming.View.Controls.SeansonHandleControl();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.enumerationControl1 = new Programming.View.Controls.EnumerationsControl();
            this.classesTabPage = new System.Windows.Forms.TabPage();
            this.moviesControl1 = new Programming.View.Controls.MoviesControl();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.rectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.mainTabControl.SuspendLayout();
            this.enumsTabPage.SuspendLayout();
            this.classesTabPage.SuspendLayout();
            this.rectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.enumsTabPage);
            this.mainTabControl.Controls.Add(this.classesTabPage);
            this.mainTabControl.Controls.Add(this.rectanglesTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(731, 571);
            this.mainTabControl.TabIndex = 0;
            // 
            // enumsTabPage
            // 
            this.enumsTabPage.Controls.Add(this.seansonHandleControl1);
            this.enumsTabPage.Controls.Add(this.weekdayParsingControl1);
            this.enumsTabPage.Controls.Add(this.enumerationControl1);
            this.enumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.enumsTabPage.Name = "enumsTabPage";
            this.enumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.enumsTabPage.Size = new System.Drawing.Size(723, 538);
            this.enumsTabPage.TabIndex = 0;
            this.enumsTabPage.Text = "Enums";
            this.enumsTabPage.UseVisualStyleBackColor = true;
            // 
            // seansonHandleControl1
            // 
            this.seansonHandleControl1.Location = new System.Drawing.Point(358, 374);
            this.seansonHandleControl1.Name = "seansonHandleControl1";
            this.seansonHandleControl1.Size = new System.Drawing.Size(357, 164);
            this.seansonHandleControl1.TabIndex = 5;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(3, 374);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(361, 161);
            this.weekdayParsingControl1.TabIndex = 4;
            // 
            // enumerationControl1
            // 
            this.enumerationControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enumerationControl1.Location = new System.Drawing.Point(3, 3);
            this.enumerationControl1.Name = "enumerationControl1";
            this.enumerationControl1.Size = new System.Drawing.Size(717, 370);
            this.enumerationControl1.TabIndex = 3;
            // 
            // classesTabPage
            // 
            this.classesTabPage.Controls.Add(this.moviesControl1);
            this.classesTabPage.Controls.Add(this.rectanglesControl1);
            this.classesTabPage.Location = new System.Drawing.Point(4, 29);
            this.classesTabPage.Name = "classesTabPage";
            this.classesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.classesTabPage.Size = new System.Drawing.Size(723, 538);
            this.classesTabPage.TabIndex = 1;
            this.classesTabPage.Text = "Classes";
            this.classesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(370, 6);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(350, 362);
            this.moviesControl1.TabIndex = 10;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 6);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(352, 448);
            this.rectanglesControl1.TabIndex = 9;
            // 
            // rectanglesTabPage
            // 
            this.rectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.rectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.rectanglesTabPage.Name = "rectanglesTabPage";
            this.rectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rectanglesTabPage.Size = new System.Drawing.Size(723, 538);
            this.rectanglesTabPage.TabIndex = 2;
            this.rectanglesTabPage.Text = "Rectangles";
            this.rectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(717, 532);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 571);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Demo";
            this.mainTabControl.ResumeLayout(false);
            this.enumsTabPage.ResumeLayout(false);
            this.classesTabPage.ResumeLayout(false);
            this.rectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage enumsTabPage;
        private System.Windows.Forms.TabPage classesTabPage;
        private System.Windows.Forms.TabPage rectanglesTabPage;
        private View.Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Controls.EnumerationsControl enumerationControl1;
        private View.Controls.WeekdayParsingControl weekdayParsingControl1;
        private View.Controls.SeansonHandleControl seansonHandleControl1;
        private View.Controls.RectanglesControl rectanglesControl1;
        private View.Controls.MoviesControl moviesControl1;
    }
}

