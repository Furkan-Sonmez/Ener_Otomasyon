using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Ener_Otomasyon
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
        }
        public string mail; 

        private void Mail_Load(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                textBox1.Text = mail.ToString();
            }

        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MailMessage ePosta = new MailMessage();

            //
            ePosta.To.Add(textBox1.Text);
            //
            ePosta.Attachments.Add(new Attachment(@"C:\deneme-upload.jpg"));
            //
            ePosta.Subject = textBox2.Text;
            //
            ePosta.Body = richTextBox1.Text;
            //
            SmtpClient smtp = new SmtpClient();
            //
            smtp.Credentials = new System.Net.NetworkCredential("mail", "şifre");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            smtp.SendAsync(ePosta, (object)ePosta);
        }

       

    }
}
