using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Hastane_Sistemi2
{
    public partial class İLETİŞİM : Form
    {
        public İLETİŞİM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mesajım = new MailMessage();
                SmtpClient istemci2 = new SmtpClient();
                istemci2.Credentials = new System.Net.NetworkCredential("emresefer53@outlook.com", "Babam1998");
                istemci2.Port = 587;
                istemci2.Host = "smtp-mail.outlook.com";
                istemci2.EnableSsl = true;
                mesajım.To.Add(textBox1.Text);
                mesajım.From = new MailAddress("emresefer53@outlook.com");
                mesajım.Subject = textKONU.Text;
                mesajım.Body = rchtxtŞkyt.Text;
                istemci2.Send(mesajım);
                MessageBox.Show("Mesajınız başarıyla iletildi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }
    }
}
