using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security;
using System.IO;
namespace MailSenderSchool
{ 
    // TO DO :::::::::::::::::::::::
    // Log for programm @Need to put messages on events@
 
    // done :
    // encrypt decrypt password & mail in log
    // log events 
    // sending mail as well 
    // recipients 
    // attach
    // 1st item of menustrip
    // open log

    public class SchoolSender
    {

        public MailAddress _senderMail;
        private string _senderPass;
        public string SubjectMail;
        public string SendPass
        {
            set { this._senderPass = value;}
            get { return this._senderPass; }
        }
        public List<MailAddress> Recipients;
        public List<Attachment> atts;
        private string _finalText;
        public string FinalText
        {
            set
            {
                this._finalText = value;
            }
            get { return this._finalText; }
        }
        public void SendMailToAll()
        {
            
            SmtpClient mailer = DealWithSMTP(new SmtpClient());
            MailMessage msg = new MailMessage();
            msg.From = this._senderMail;
            msg.Subject = this.SubjectMail;
            msg.Body = this.FinalText;
            foreach (var el in atts)
            {
                msg.Attachments.Add(el);
            }
            foreach (var rec in Recipients)
            {
                msg.To.Add(rec.Address);
            }
                try
                {
                    mailer.SendMailAsync(msg);
                    string logStr = @"Adresses were taken from recipients.xml and sent using " + this.Encrypt(this._senderMail.Address) + " ; " + this.Encrypt(this.SendPass) + Environment.NewLine;
                    if (this.atts.Count != 0)
                    {
                        logStr += "Attachments : ";
                        foreach (var el in this.atts)
                        {
                            logStr += el.Name + "; ";
                        }
                    }
                    this.Logger(logStr);
                    MessageBox.Show("Mail was sent!", "Info");
                    //logStr += msg.To.Address + " ,";
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            
        }
        public void Logger(string msg)
        {
            DateTime dateTime = DateTime.Now;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"Log/log.dat", true);
            file.WriteLine(dateTime.ToString("yyyy-MM-dd HH:mm:ss") + " " + msg);
            file.Close();
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        public SchoolSender()
        {
            this.Recipients = new List<MailAddress>();
            this.atts = new List<Attachment>();
         
        }
        public SmtpClient DealWithSMTP(SmtpClient mailer)
        {
            const int port = 587;
            mailer = new SmtpClient();
            if (this._senderMail.Address.IndexOf("@gmail.com") != -1)
            {
                mailer = new SmtpClient("smtp.gmail.com", port);
            }
            else if (this._senderMail.Address.IndexOf("@yahoo.com") != -1)
            {
                mailer = new SmtpClient("smtp.mail.yahoo.com", port);
            }
            else if (this._senderMail.Address.IndexOf("@hotmail.com") != -1)
            {
                mailer = new SmtpClient("smtp.live.com", 25);
            }
            else if (this._senderMail.Address.IndexOf("@mail.ru") != -1)
            {
                mailer = new SmtpClient("smtp.mail.ru", port);
            }
            else if (this._senderMail.Address.IndexOf("@yandex.ru") != -1)
            {
                mailer = new SmtpClient("smtp.yandex.ru", port);
            }
            else
            {
                mailer = new SmtpClient("proxy.mailserver.com", 8080);
            }
            mailer.Credentials = new System.Net.NetworkCredential(this._senderMail.Address, this._senderPass);
            mailer.EnableSsl = true;
            return mailer;
        }
    }
}
