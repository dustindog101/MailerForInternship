namespace MailerForDereje
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txtattachments = new MetroFramework.Controls.MetroTextBox();
            this.txtNames = new MetroFramework.Controls.MetroTextBox();
            this.txtEmails = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 50);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(900, 258);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroListView1);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 9;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(892, 213);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Statistics";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(890, 209);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 171;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 307;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.txtattachments);
            this.metroTabPage2.Controls.Add(this.txtNames);
            this.metroTabPage2.Controls.Add(this.txtEmails);
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 9;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(892, 213);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Controls";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // txtattachments
            // 
            this.txtattachments.AllowDrop = true;
            // 
            // 
            // 
            this.txtattachments.CustomButton.Image = null;
            this.txtattachments.CustomButton.Location = new System.Drawing.Point(490, 2);
            this.txtattachments.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtattachments.CustomButton.Name = "";
            this.txtattachments.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtattachments.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtattachments.CustomButton.TabIndex = 1;
            this.txtattachments.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtattachments.CustomButton.UseSelectable = true;
            this.txtattachments.CustomButton.Visible = false;
            this.txtattachments.Lines = new string[0];
            this.txtattachments.Location = new System.Drawing.Point(22, 63);
            this.txtattachments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtattachments.MaxLength = 32767;
            this.txtattachments.Name = "txtattachments";
            this.txtattachments.PasswordChar = '\0';
            this.txtattachments.PromptText = "Attachments location";
            this.txtattachments.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtattachments.SelectedText = "";
            this.txtattachments.SelectionLength = 0;
            this.txtattachments.SelectionStart = 0;
            this.txtattachments.ShortcutsEnabled = true;
            this.txtattachments.Size = new System.Drawing.Size(510, 22);
            this.txtattachments.TabIndex = 7;
            this.txtattachments.UseSelectable = true;
            this.txtattachments.WaterMark = "Attachments location";
            this.txtattachments.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtattachments.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNames
            // 
            this.txtNames.AllowDrop = true;
            // 
            // 
            // 
            this.txtNames.CustomButton.Image = null;
            this.txtNames.CustomButton.Location = new System.Drawing.Point(490, 2);
            this.txtNames.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNames.CustomButton.Name = "";
            this.txtNames.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNames.CustomButton.TabIndex = 1;
            this.txtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNames.CustomButton.UseSelectable = true;
            this.txtNames.CustomButton.Visible = false;
            this.txtNames.Lines = new string[0];
            this.txtNames.Location = new System.Drawing.Point(22, 33);
            this.txtNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNames.MaxLength = 32767;
            this.txtNames.Name = "txtNames";
            this.txtNames.PasswordChar = '\0';
            this.txtNames.PromptText = "Names location";
            this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNames.SelectedText = "";
            this.txtNames.SelectionLength = 0;
            this.txtNames.SelectionStart = 0;
            this.txtNames.ShortcutsEnabled = true;
            this.txtNames.Size = new System.Drawing.Size(510, 22);
            this.txtNames.TabIndex = 6;
            this.txtNames.UseSelectable = true;
            this.txtNames.WaterMark = "Names location";
            this.txtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmails
            // 
            this.txtEmails.AllowDrop = true;
            // 
            // 
            // 
            this.txtEmails.CustomButton.Image = null;
            this.txtEmails.CustomButton.Location = new System.Drawing.Point(490, 2);
            this.txtEmails.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmails.CustomButton.Name = "";
            this.txtEmails.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtEmails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmails.CustomButton.TabIndex = 1;
            this.txtEmails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmails.CustomButton.UseSelectable = true;
            this.txtEmails.CustomButton.Visible = false;
            this.txtEmails.Lines = new string[0];
            this.txtEmails.Location = new System.Drawing.Point(22, 6);
            this.txtEmails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmails.MaxLength = 32767;
            this.txtEmails.Name = "txtEmails";
            this.txtEmails.PasswordChar = '\0';
            this.txtEmails.PromptText = "Emails location";
            this.txtEmails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmails.SelectedText = "";
            this.txtEmails.SelectionLength = 0;
            this.txtEmails.SelectionStart = 0;
            this.txtEmails.ShortcutsEnabled = true;
            this.txtEmails.Size = new System.Drawing.Size(510, 22);
            this.txtEmails.TabIndex = 5;
            this.txtEmails.UseSelectable = true;
            this.txtEmails.WaterMark = "Emails location";
            this.txtEmails.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmails.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(634, 98);
            this.metroButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(260, 41);
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "Clear";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(634, 52);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(260, 41);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Stop";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(634, 6);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(260, 41);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Start";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.label1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 9;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 41);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(892, 213);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nothing here for now";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 306);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(877, 22);
            this.progressBar1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 334);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Mailer";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private MetroFramework.Controls.MetroTextBox txtattachments;
        private MetroFramework.Controls.MetroTextBox txtNames;
        private MetroFramework.Controls.MetroTextBox txtEmails;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label label1;
    }
}

