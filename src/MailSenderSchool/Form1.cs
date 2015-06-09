using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;
namespace MailSenderSchool
{ 
     // add email validation in tab2 + info about email on click
    public partial class Form1 : Form
    {
        SchoolSender obj = new SchoolSender();

        public Form1()
        {
            InitializeComponent();
            #region Attachments
            this.MailBodyBox.AllowDrop = true;
            this.MailBodyBox.EnableAutoDragDrop = false;
            this.MailBodyBox.DragDrop += MailBodyBox_DragDrop;
            this.MailBodyBox.DragEnter += MailBodyBox_DragEnter;

            this.AttachmentsBox.AllowDrop = true;
            this.AttachmentsBox.DragDrop += AttachmentsBox_DragDrop;
            this.AttachmentsBox.DragEnter += AttachmentsBox_DragEnter;
            #endregion
            #region Buttons
            this.LoadMailButton.BackColor = Color.LightBlue;
            this.LoadMailButton.Click += btn2_Click;
            this.LoadMailPwButton.BackColor = Color.LightBlue;
            this.LoadMailPwButton.Click += btn3_Click;
            this.sendButton.BackColor = Color.LightBlue;
            this.sendButton.Click += btn_Click;
            this.sendButton.Enabled = false;
            //btn.Height = 50;
            //btn.Width = 70;
            //btn.Text = "Send!";
            ////btn.
            //this.panel1.Controls.Add(btn);
            //btn.Location = new Point(this.Width - 100, this.Height - 220);
            //btn.BackColor = Color.LightBlue;
            //btn.Enabled = false;
            //btn.Click += btn_Click;

            //btn2.Height = 50;
            //btn2.Width = 70;
            //btn2.Text = "Load school mails";
            //this.tabPage2.Controls.Add(btn2);
            //btn2.Location = new Point(this.tabPage2.Width - 80, this.tabPage2.Height - 55);
            //btn2.Click += btn2_Click;
            //btn2.BackColor = Color.LightBlue;

            //btn3.BackColor = Color.LightBlue;
            //btn3.Height = 50;
            //btn3.Width = 70;
            //btn3.Text = "Set Default";
            //this.tabPage1.Controls.Add(btn3);
            //btn3.Location = new Point(this.tabPage2.Width - 75, this.tabPage2.Height - 60);
            //btn3.Click += btn3_Click;
            this.AddMailButton.BackColor = Color.LightBlue;
            #endregion
            #region toolTips
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.SetToolTip(this.SenderEmailBox, "Enter Email");
            toolTip1.SetToolTip(this.SenderPasswordBox, "Enter Name");
            toolTip1.SetToolTip(this.RecipientsBox, "Recipients Box");
            #endregion
            this.panel1.Select();
           
        }

        
        

        private void btn2_click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void AttachmentsBox_DragEnter(object sender, DragEventArgs e)
        {

                e.Effect = DragDropEffects.Copy;
            
        }

        void AttachmentsBox_DragDrop(object sender, DragEventArgs e)
        {
            var filename = e.Data.GetData("FileDrop");
            //if (((string[])filename)[0].EndsWith(".bmp") ||
            //    ((string[])filename)[0].EndsWith(".gif") ||
            //    ((string[])filename)[0].EndsWith(".jpg") ||
            //    ((string[])filename)[0].EndsWith(".jpeg") ||
            //    ((string[])filename)[0].EndsWith(".png"))
            //{
                Attachment at = new Attachment(((string[])filename)[0]);
                at.ContentDisposition.Inline = true;
                obj.atts.Add(at);
                MessageBox.Show("Attachment " + ((string[])filename)[0] + " added.", "info");
                return;
            //}
        }

        void MailBodyBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        void MailBodyBox_DragDrop(object sender, DragEventArgs e)
        {
            var filename = e.Data.GetData("FileDrop");
            
            if (filename != null)
            {
                var list = filename as string[];

                if (list != null && !string.IsNullOrWhiteSpace(list[0]))
                {
                    this.MailBodyBox.Clear();
                    this.MailBodyBox.LoadFile(list[0], RichTextBoxStreamType.PlainText);
                }

            }
            //this.MailBodyBox.Text = File.ReadAllText((string)e.Data.GetData(DataFormats.FileDrop)) + "\n";
            //string text = (string)e.Data.GetData("Text");
            //this.MailBodyBox.LoadFile(text, RichTextBoxStreamType.RichText);
        }

        void CheckAll()
        {

                if (this.MailBodyBox.Text == null || this.MailBodyBox.Text == "" || String.IsNullOrWhiteSpace(this.MailBodyBox.Text) == true)
                {
                    this.sendButton.Enabled = false;
                    return;
                }
                else if (this.RecipientsBox.Items.Count == 0)
                {
                   this.sendButton.Enabled = false;
                   return;
                }
                else if (this.SenderEmailBox.Text == "" && this.SenderEmailBox.Text == null)
                {
                    this.sendButton.Enabled = false;
                    return;
                }
                else if (!IsValid(this.SenderEmailBox.Text))
                {
                    this.sendButton.Enabled = false;
                    return;
                }
                else if (this.SenderPasswordBox.Text == null || this.SenderPasswordBox.Text.Length <= 4)
                {
                    this.sendButton.Enabled = false;
                    return;
                }
                else if (this.subjectBox.Text == null || this.subjectBox.Text == "")
                {
                    this.sendButton.Enabled = false;
                    return;
                }
                else
                {
                    this.sendButton.Enabled = true;
                    this.obj.SubjectMail = this.subjectBox.Text;
                    this.obj._senderMail = new MailAddress(this.SenderEmailBox.Text);
                    this.obj.SendPass = this.SenderPasswordBox.Text;
                }
            }
           
            
        
        void btn_Click(object sender, EventArgs e)
        {
            // send mail
            this.obj.FinalText = this.MailBodyBox.Text + "\n Greetings.";
            this.obj.SendMailToAll();
            

        }

        void btn2_Click(object sender, EventArgs e)
        {
            this.obj.Recipients.Clear();
            // set school emails from xml or smth
            var xml = XDocument.Load(@"Recipients/recipients.xml");
            
            var query = from c in xml.Root.Descendants("recipient")
                        select c.Element("email").Value;

            foreach (string name in query)
            {
                if (IsValid(name))
                {
                    this.obj.Recipients.Add(new MailAddress(name));
                }
            }
            LoadRecipients();
        }
       
        public void LoadRecipients()
        {

            this.RecipientsBox.Items.Clear();
            for (int i = 0; i < obj.Recipients.Count; i++)
            //(var str in this.obj.Recipients)
            {

                if (this.obj.Recipients.Last<MailAddress>() != obj.Recipients[i])
                    this.RecipientsBox.Items.Add(obj.Recipients[i]);
                else this.RecipientsBox.Text += obj.Recipients[i];
            }
        }
        void btn3_Click(object sender, EventArgs e)
        {
            this.SenderEmailBox.UseSystemPasswordChar = false;
            this.SenderEmailBox.Text = ConfigurationSettings.AppSettings["Mail"];
            this.SenderPasswordBox.UseSystemPasswordChar = true;
            this.SenderPasswordBox.Text = ConfigurationSettings.AppSettings["PasswordMail"];
           // MessageBox.Show(ConfigurationSettings.AppSettings.AllKeys["PasswordMail"], ConfigurationSettings.AppSettings.AllKeys["Mail"]);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.SenderPasswordBox.UseSystemPasswordChar = true;
            if (this.SenderPasswordBox.Text.Length > 4)
                this.SenderPasswordBox.BackColor = Color.YellowGreen;
            else
            {
                this.SenderPasswordBox.BackColor = Color.WhiteSmoke;
            }
            CheckAll();
        }

        public bool IsValid(string emailaddress)
        {
            if (String.IsNullOrEmpty(emailaddress) || emailaddress == " ")
            {
                return false;
            }
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (this.SenderEmailBox.Text == "")
                {
                    this.SenderEmailBox.BackColor = Color.WhiteSmoke;
                    
                    return;
                }
                if (IsValid(this.SenderEmailBox.Text))
                {
                    this.SenderEmailBox.BackColor = Color.YellowGreen;
                }
                else this.SenderEmailBox.BackColor = Color.Brown;
            }
            catch (Exception)
            { }
            CheckAll();

        }

        private void subjectBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zhluktenko Dmytro,\nSchoolMailSender for ROLI\nd1mnewz@gmail.com\n\t2015", "Info");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj.Logger("Form was opened by " + Environment.UserName);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.obj.Logger("Form was closed");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Office Files|*.doc;*.xls;*.ppt;*.txt;*.html;*.xml;| All Files| *.*";
            openFileDialog1.InitialDirectory = @"C:\";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    this.MailBodyBox.Text = text;
                }
                catch (IOException)
                {
                    MessageBox.Show("Something went wrong", "Oh god not again");
                }
            }

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MailBodyBox.Clear();
            this.SenderEmailBox.Clear();
            this.SenderPasswordBox.Clear();
            this.RecipientsBox.Items.Clear();
            this.subjectBox.Clear();
            
            this.obj.atts = new List<Attachment>();
            this.obj.FinalText = "";
            this.obj.Recipients = new List<MailAddress>();
            this.obj.SendPass = "";
            this.obj.SubjectMail = "";
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.obj.Logger("Log was opened from programm by " + Environment.UserName);
            Process.Start("notepad.exe", @"Log/log.dat");
        }

        private void RecipientsBox_TextChanged(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Addmail form = new Addmail();
            form.ShowDialog();
            // to add to Recipients list 
            // to add to obj.recipients
        }


    }
}
