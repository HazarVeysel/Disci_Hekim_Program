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
using Disci_Hekim_Program.GirisKontrol;
using Disci_Hekim_Program.AdminServis;

namespace Disci_Hekim_Program
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            GirisSoapClient client = new GirisSoapClient();
            bool mailvarmi = client.MailKontrol(txtmail.Text);
            if (mailvarmi == true)
            {
                mailgonder();
                groupBox1.Visible = true;
                txtilk.Focus();

            }
            else
            {
                MessageBox.Show("Böyle Bir Mail Bulunmamakta", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        int sayi;
        private void mailgonder()
        {
            AdminSoapClient client = new AdminSoapClient();

            if (client.MailVarMi(txtmail.Text))
            {
                Random rastgele = new Random();
                sayi = rastgele.Next(1000, 9999);
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress("denememailleri2020@gmail.com");
                    mail.To.Add(txtmail.Text);
                    mail.Subject = "Sifre Hatirlatma";
                    mail.Body += " <html>";
                    mail.Body += "<body>";
                    mail.Body += "<table>";

                    mail.Body += "<tr>";
                    mail.Body += "<td>Dogrulama Kodu : </td><td>" + sayi.ToString() + "" + " </td>";
                    mail.Body += "</tr>";

                    mail.Body += "</table>";
                    mail.Body += "</body>";
                    mail.Body += "</html>";

                    mail.IsBodyHtml = true;
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("denememailleri2020@gmail.com", "Sfiklos89");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Sistemde Böyle Bir Mail Bulunmamakta Lütfen Mailinizi Kontrol Ediniz!");
            }


        }

        private void btndogrula_Click(object sender, EventArgs e)
        {
            int dogrulamakodu = Convert.ToInt32(txtilk.Text + txtikinci.Text + txtucuncu.Text + txtdorduncu.Text);
            if (dogrulamakodu == sayi)
            {
                mailgondersifre();
            }
        }

        private bool mailgondersifre()
        {
            GirisSoapClient client = new GirisSoapClient();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("denememailleri2020@gmail.com");
                mail.To.Add("italhamengi@gmail.com");
                mail.Subject = "Sifre Hatirlatma";
                mail.Body += " <html>";
                mail.Body += "<body>";
                mail.Body += "<table>";

                mail.Body += "<tr>";
                mail.Body += "<td>Sifre : </td><td>" + client.SifreGonder(txtmail.Text) + "" + " </td>";
                mail.Body += "</tr>";

                mail.Body += "</table>";
                mail.Body += "</body>";
                mail.Body += "</html>";

                mail.IsBodyHtml = true;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("denememailleri2020@gmail.com", "Sfiklos89");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }

        }

        private void txtilk_TextChanged(object sender, EventArgs e)
        {
            if (txtilk.Text.Length == 1)
            {
                txtikinci.Focus();
            }
        }

        private void txtikinci_TextChanged(object sender, EventArgs e)
        {
            if (txtikinci.Text.Length == 1)
            {
                txtucuncu.Focus();
            }
        }

        private void txtucuncu_TextChanged(object sender, EventArgs e)
        {
            if (txtucuncu.Text.Length == 1)
            {
                txtdorduncu.Focus();
            }
        }

        private void SifremiUnuttum_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
