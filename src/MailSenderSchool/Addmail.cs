using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MailSenderSchool
{
    public partial class Addmail : Form
    {
        public Addmail()
        {
            InitializeComponent();
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.EmailTextBox.Text == "" || String.IsNullOrWhiteSpace(this.EmailTextBox.Text))
            {
                this.EmailTextBox.BackColor = Color.WhiteSmoke;
                return;
            }
            if (IsValid(this.EmailTextBox.Text))
            {
                this.EmailTextBox.BackColor = Color.YellowGreen;
                this.FinishButton.Enabled = true;
                return;
            }
            else this.EmailTextBox.BackColor = Color.Brown;
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

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (this.AddToXMLCheck.Checked)
            {
                XDocument doc = XDocument.Load(@"Recipients/recipients.xml");
                XElement recipient = new XElement("recipient",  new XElement("email", this.EmailTextBox.Text));
                doc.Root.Add(recipient);
                doc.Save(@"Recipients/recipients.xml");
            }
            //(this.Parent.Parent as Form1).RecipientsBox.Items.Add(new MailAddress(this.EmailTextBox.Text));
            // to do !!!!!!!!!!!!
            Application.Exit();
            
        }



    }
}
