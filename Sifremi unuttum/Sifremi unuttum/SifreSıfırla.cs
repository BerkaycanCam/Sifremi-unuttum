using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace Sifremi_unuttum
{
    public partial class SifreSıfırla : Form
    {
        public SifreSıfırla()
        {
            InitializeComponent();
        }

        private void SifreSıfırla_Load(object sender, EventArgs e)
        {

        } string random;

        private void Gö_Click(object sender, EventArgs e)
        {
            try
            {
               
                Random code = new Random();
                random = code.Next(999999).ToString();
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                mailMessage.From = new MailAddress("berkay.can1565@gmail.com");
                mailMessage.To.Add("berkay.can1565@gmail.com");
                mailMessage.Subject = "Şifre Sıfırlama";
                mailMessage.Body = "kodunuz:"+random;
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("berkay.can1565@gmail.com", "xtzlhyxfnmqhaxjx");
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);
                MessageBox.Show("mail gönderildi.");
            }
            catch (Exception error)
            {
                MessageBox.Show("mesaj gönderilmedi");
                Console.WriteLine(error.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Dogrula.Text.Equals(random))
            {
                this.Hide();
                Resetle resetle = new Resetle();
                resetle.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("kod hatalı tekrar deneyiniz");
            }
        }
    }
}
