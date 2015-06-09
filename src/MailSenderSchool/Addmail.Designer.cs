namespace MailSenderSchool
{
    partial class Addmail
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
            this.FinishButton = new MailSenderSchool.CustomButton();
            this.EmailTextBox = new System.Windows.Forms.RichTextBox();
            this.AddToXMLCheck = new System.Windows.Forms.CheckBox();
            this.EnterMailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishButton
            // 
            this.FinishButton.DisplayFocusCues = false;
            this.FinishButton.Enabled = false;
            this.FinishButton.Location = new System.Drawing.Point(150, 83);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(122, 23);
            this.FinishButton.TabIndex = 0;
            this.FinishButton.Text = "Add to Recipients List";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(94, 25);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(178, 20);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.Text = "";
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // AddToXMLCheck
            // 
            this.AddToXMLCheck.AutoSize = true;
            this.AddToXMLCheck.Location = new System.Drawing.Point(175, 60);
            this.AddToXMLCheck.Name = "AddToXMLCheck";
            this.AddToXMLCheck.Size = new System.Drawing.Size(97, 17);
            this.AddToXMLCheck.TabIndex = 2;
            this.AddToXMLCheck.Text = "Add to xml also";
            this.AddToXMLCheck.UseVisualStyleBackColor = true;
            // 
            // EnterMailLabel
            // 
            this.EnterMailLabel.AutoSize = true;
            this.EnterMailLabel.Location = new System.Drawing.Point(12, 28);
            this.EnterMailLabel.Name = "EnterMailLabel";
            this.EnterMailLabel.Size = new System.Drawing.Size(62, 13);
            this.EnterMailLabel.TabIndex = 3;
            this.EnterMailLabel.Text = "Enter e-mail";
            // 
            // Addmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.EnterMailLabel);
            this.Controls.Add(this.AddToXMLCheck);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.FinishButton);
            this.Name = "Addmail";
            this.Text = "Addmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton FinishButton;
        private System.Windows.Forms.CheckBox AddToXMLCheck;
        private System.Windows.Forms.Label EnterMailLabel;
        public System.Windows.Forms.RichTextBox EmailTextBox;
    }
}