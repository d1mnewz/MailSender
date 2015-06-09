namespace MailSenderSchool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MailBodyBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngLang = new System.Windows.Forms.ToolStripMenuItem();
            this.ukrLang = new System.Windows.Forms.ToolStripMenuItem();
            this.RusLang = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SenderPasswordBox = new System.Windows.Forms.TextBox();
            this.SenderEmailBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AttachGroupBox = new System.Windows.Forms.GroupBox();
            this.AttachmentsBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RecipientsBox = new System.Windows.Forms.ListBox();
            this.sendButton = new MailSenderSchool.CustomButton();
            this.LoadMailPwButton = new MailSenderSchool.CustomButton();
            this.AddMailButton = new MailSenderSchool.CustomButton();
            this.LoadMailButton = new MailSenderSchool.CustomButton();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AttachGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MailBodyBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Body";
            // 
            // MailBodyBox
            // 
            this.MailBodyBox.EnableAutoDragDrop = true;
            this.MailBodyBox.Location = new System.Drawing.Point(3, 16);
            this.MailBodyBox.Name = "MailBodyBox";
            this.MailBodyBox.Size = new System.Drawing.Size(652, 196);
            this.MailBodyBox.TabIndex = 0;
            this.MailBodyBox.Text = "";
            this.MailBodyBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newToolStripMenuItem.Text = "&Clear all";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(156, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLogToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // openLogToolStripMenuItem
            // 
            this.openLogToolStripMenuItem.Name = "openLogToolStripMenuItem";
            this.openLogToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openLogToolStripMenuItem.Text = "Open Log";
            this.openLogToolStripMenuItem.Click += new System.EventHandler(this.openLogToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // EngLang
            // 
            this.EngLang.Enabled = false;
            this.EngLang.Name = "EngLang";
            this.EngLang.Size = new System.Drawing.Size(124, 22);
            this.EngLang.Text = "English";
            // 
            // ukrLang
            // 
            this.ukrLang.Name = "ukrLang";
            this.ukrLang.Size = new System.Drawing.Size(124, 22);
            this.ukrLang.Text = "Ukrainian";
            // 
            // RusLang
            // 
            this.RusLang.Name = "RusLang";
            this.RusLang.Size = new System.Drawing.Size(124, 22);
            this.RusLang.Text = "Russian";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 100);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.LoadMailPwButton);
            this.tabPage1.Controls.Add(this.SenderPasswordBox);
            this.tabPage1.Controls.Add(this.SenderEmailBox);
            this.tabPage1.Controls.Add(this.PasswordLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mail Content";
            // 
            // SenderPasswordBox
            // 
            this.SenderPasswordBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SenderPasswordBox.Location = new System.Drawing.Point(99, 42);
            this.SenderPasswordBox.Name = "SenderPasswordBox";
            this.SenderPasswordBox.Size = new System.Drawing.Size(100, 20);
            this.SenderPasswordBox.TabIndex = 3;
            this.SenderPasswordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SenderEmailBox
            // 
            this.SenderEmailBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SenderEmailBox.Location = new System.Drawing.Point(99, 13);
            this.SenderEmailBox.Name = "SenderEmailBox";
            this.SenderEmailBox.Size = new System.Drawing.Size(100, 20);
            this.SenderEmailBox.TabIndex = 2;
            this.SenderEmailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 45);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(90, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Sender Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sender Email";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.AddMailButton);
            this.tabPage2.Controls.Add(this.RecipientsBox);
            this.tabPage2.Controls.Add(this.LoadMailButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recipients";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Controls.Add(this.AttachGroupBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subjectBox);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 328);
            this.panel1.TabIndex = 6;
            // 
            // AttachGroupBox
            // 
            this.AttachGroupBox.Controls.Add(this.AttachmentsBox);
            this.AttachGroupBox.Location = new System.Drawing.Point(679, 249);
            this.AttachGroupBox.Name = "AttachGroupBox";
            this.AttachGroupBox.Size = new System.Drawing.Size(90, 73);
            this.AttachGroupBox.TabIndex = 9;
            this.AttachGroupBox.TabStop = false;
            this.AttachGroupBox.Text = "Attach!";
            // 
            // AttachmentsBox
            // 
            this.AttachmentsBox.BackColor = System.Drawing.Color.SeaShell;
            this.AttachmentsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttachmentsBox.Location = new System.Drawing.Point(6, 17);
            this.AttachmentsBox.Name = "AttachmentsBox";
            this.AttachmentsBox.ReadOnly = true;
            this.AttachmentsBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.AttachmentsBox.Size = new System.Drawing.Size(75, 50);
            this.AttachmentsBox.TabIndex = 7;
            this.AttachmentsBox.Text = "";
            this.toolTip1.SetToolTip(this.AttachmentsBox, "Drop your attachments here!");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(325, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(374, 84);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(296, 20);
            this.subjectBox.TabIndex = 1;
            this.subjectBox.TextChanged += new System.EventHandler(this.subjectBox_TextChanged);
            // 
            // RecipientsBox
            // 
            this.RecipientsBox.FormattingEnabled = true;
            this.RecipientsBox.Location = new System.Drawing.Point(6, 3);
            this.RecipientsBox.Name = "RecipientsBox";
            this.RecipientsBox.ScrollAlwaysVisible = true;
            this.RecipientsBox.Size = new System.Drawing.Size(200, 69);
            this.RecipientsBox.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.DisplayFocusCues = false;
            this.sendButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sendButton.Location = new System.Drawing.Point(685, 196);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 47);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // LoadMailPwButton
            // 
            this.LoadMailPwButton.DisplayFocusCues = false;
            this.LoadMailPwButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoadMailPwButton.Location = new System.Drawing.Point(224, 13);
            this.LoadMailPwButton.Name = "LoadMailPwButton";
            this.LoadMailPwButton.Size = new System.Drawing.Size(63, 49);
            this.LoadMailPwButton.TabIndex = 4;
            this.LoadMailPwButton.Text = "Load Default";
            this.LoadMailPwButton.UseVisualStyleBackColor = true;
            // 
            // AddMailButton
            // 
            this.AddMailButton.DisplayFocusCues = false;
            this.AddMailButton.Location = new System.Drawing.Point(212, 48);
            this.AddMailButton.Name = "AddMailButton";
            this.AddMailButton.Size = new System.Drawing.Size(75, 23);
            this.AddMailButton.TabIndex = 3;
            this.AddMailButton.Text = "Add E-mail";
            this.AddMailButton.UseVisualStyleBackColor = true;
            this.AddMailButton.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // LoadMailButton
            // 
            this.LoadMailButton.DisplayFocusCues = false;
            this.LoadMailButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LoadMailButton.Location = new System.Drawing.Point(212, 3);
            this.LoadMailButton.Name = "LoadMailButton";
            this.LoadMailButton.Size = new System.Drawing.Size(75, 42);
            this.LoadMailButton.TabIndex = 1;
            this.LoadMailButton.Text = "Load default";
            this.LoadMailButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(769, 367);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SchoolMailSender";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AttachGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox MailBodyBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox SenderPasswordBox;
        private System.Windows.Forms.TextBox SenderEmailBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem openLogToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox AttachmentsBox;
        private System.Windows.Forms.GroupBox AttachGroupBox;
        private System.Windows.Forms.ToolStripMenuItem EngLang;
        private System.Windows.Forms.ToolStripMenuItem ukrLang;
        private System.Windows.Forms.ToolStripMenuItem RusLang;
        private CustomButton LoadMailPwButton;
        private CustomButton LoadMailButton;
        private CustomButton sendButton;
        private CustomButton AddMailButton;
        public System.Windows.Forms.ListBox RecipientsBox;
    }
}

