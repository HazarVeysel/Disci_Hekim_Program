using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disci_Hekim_Program.GirisKontrol;
using Disci_Hekim_Program.HekimServis;
using Disci_Hekim_Program.HastaServis;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Disci_Hekim_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Giris()
        {
            GirisSoapClient client = new GirisSoapClient();
            HekimSoapClient client2 = new HekimSoapClient();
            HastaSoapClient client3 = new HastaSoapClient();
            int sonuc = client.GirisKontrol(txtkullaniciadi.Text, txtsifre.Text);
            if (sonuc == 1)
            {
                int id;
                id = client2.HekimIDGetir(txtkullaniciadi.Text, txtsifre.Text);
                HekimEkran he = new HekimEkran();
                he.lblisim.Text = client2.IsimGetir(txtkullaniciadi.Text, txtsifre.Text);
                he.lblad.Text = client3.IsimGetir(id);
                he.lblsoyad.Text = client3.Soyad(id);
                he.lbltc.Text = client3.TCGetir(id);
                he.lbltel.Text = client3.TelGetir(id);
                he.lblmail.Text = client3.MailGetir(id);
                he.lblyas.Text = client3.YasGetir(id).ToString();
                he.lblcinsiyet.Text = client3.CinsyetGetir(id);
                he.lblhekimid.Text = id.ToString();
                he.Show();
                this.Hide();
            }
            else if (sonuc == 2)
            {
                Resepsiyon rsp = new Resepsiyon();
                rsp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!!!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (chkbenihatirla.Checked == true)
            {
                Properties.Settings.Default["KullaniciAdi"] = txtkullaniciadi.Text;
                Properties.Settings.Default["Sifre"] = txtsifre.Text;
            }
            Properties.Settings.Default.Save();
            Giris();

        }

        private void lnksifremiunuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum su = new SifremiUnuttum();
            su.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = Properties.Settings.Default["KullaniciAdi"].ToString();
            txtsifre.Text = Properties.Settings.Default["Sifre"].ToString();
            if (txtkullaniciadi.Text.Count() > 1)
            {
                chkbenihatirla.Checked = true;
            }
        }

    }
}
