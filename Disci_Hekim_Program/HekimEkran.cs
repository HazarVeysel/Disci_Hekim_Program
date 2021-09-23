using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disci_Hekim_Program.HastaServis;
using Disci_Hekim_Program.IslemServis;
using Disci_Hekim_Program.HizmetServis;
using Disci_Hekim_Program.IslemDetay;

namespace Disci_Hekim_Program
{
    public partial class HekimEkran : Form
    {
        public HekimEkran()
        {
            InitializeComponent();
        }

        private void comboboxverigetir()
        {
            Hizmetler1SoapClient client = new Hizmetler1SoapClient();
            cmbislemler.DataSource = client.HizmetListele();
            cmbislemler.ValueMember = "ID";
            cmbislemler.DisplayMember = "HizmetAdi";
        }

        private void GecmisBilgiler()
        {
            int id;
            HastaSoapClient hasta = new HastaSoapClient();
            IslemlerSoapClient islemler = new IslemlerSoapClient();
            id = hasta.IDGetir(lbltc.Text);
            dataGridView1.DataSource = islemler.GecmisIslemler(id);
        }

        private void HekimEkran_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            string tarih = DateTime.Now.ToString();
            lbltarih.Text = tarih;
            GecmisBilgiler();
            comboboxverigetir();
        }

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string tarih;
            a++;
            if (a == 1)
            {
                a = 0;
                tarih = DateTime.Now.ToString();
                lbltarih.Text = tarih;
            }
        }
        double tp = 0;
        private void btnuygula_Click(object sender, EventArgs e)
        {
            tp += Toplam(BirimFiyat(), Convert.ToInt32(nmadet.Value));
            lbltoplam.Text = tp.ToString();
            ListeyeEkle(cmbislemler.Text);
        }

        private void ListeyeEkle(string islem)
        {
            dataGridView2.Rows.Add(islem, BirimFiyat(), nmadet.Value.ToString());
        }

        private double BirimFiyat()
        {
            int id = Convert.ToInt32(cmbislemler.SelectedValue);
            Hizmetler1SoapClient hizmet = new Hizmetler1SoapClient();
            double birimfiyat = hizmet.BirimFiyatGetir(id);
            return birimfiyat;
        }

        private double Toplam(double birimfiyat, int adet)
        {
            return birimfiyat * adet;
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            IslemlerSoapClient client = new IslemlerSoapClient();
            HastaSoapClient client2 = new HastaSoapClient();
            IslemDetaySoapClient client3 = new IslemDetaySoapClient();
            int hekimid = Convert.ToInt32(lblhekimid.Text);
            int hastaid = Convert.ToInt32(client2.IDGetir(lbltc.Text));
            int islemid = client.IslemOlusturVeIDGetir(hekimid, hastaid, islemadigetir(), DateTime.Now.ToShortDateString(), Convert.ToDouble(lbltoplam.Text));
            for (int i = 0; i < dataGridView2.Rows.Count-1; i++)
            {
                if (dataGridView2.Rows[i] == null)
                {
                    break;
                }
                client3.IslemDetayEkle(islemid, dataGridView2.Rows[i].Cells[0].Value.ToString(), Convert.ToDouble(dataGridView2.Rows[i].Cells[1].Value), Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value));
               
            }
            client2.DurumGuncelle(hastaid,"İşlem Tamamlandı");
        }

        string isl = "";
        private string islemadigetir()
        {
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                isl += dataGridView2.Rows[i].Cells[0].Value.ToString() + " ";
            }
            return isl;
        }

        private void HekimEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
