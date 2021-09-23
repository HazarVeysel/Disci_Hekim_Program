using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disci_Hekim_Program.RandevuServis;
using Disci_Hekim_Program.HastaServis;
using Disci_Hekim_Program.HekimServis;

namespace Disci_Hekim_Program
{
    public partial class Resepsiyon : Form
    {
        public Resepsiyon()
        {
            InitializeComponent();
        }

        private void HekimGetirComboBox()
        {
            HekimSoapClient client = new HekimSoapClient();
            cmbdoktoradiekle.DataSource = client.HekimleriGetir();
            cmbdoktoradiekle.DisplayMember = "HekimAd";
            cmbdoktoradiekle.ValueMember = "HekimID";
            cmbdoktorlar.DataSource = client.HekimleriGetir();
            cmbdoktorlar.DisplayMember = "HekimAd";
            cmbdoktorlar.ValueMember = "HekimID";
            cmbhekimdoktor.DataSource = client.HekimleriGetir();
            cmbhekimdoktor.DisplayMember = "HekimAd";
            cmbhekimdoktor.ValueMember = "HekimID";

        }

        private void Resepsiyon_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            dttarihfiltrele.Value = DateTime.Now;
            timer1.Start();
            string tarih = DateTime.Now.ToString();
            lbltarih.Text = tarih;
            randevulistele();
            HekimGetirComboBox();
   
        }

        private void randevulistele()
        {
            RandevuIslemleriSoapClient client = new RandevuIslemleriSoapClient();
            dataGridView1.DataSource = client.RandevuListele();
        }

        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            if (a == 1)
            {
                a = 0;
                string tarih = DateTime.Now.ToString();
                lbltarih.Text = tarih;
            }

        }

        private void btnhastaislem_Click(object sender, EventArgs e)
        {
            HastaIslemleriEkran ekran = new HastaIslemleriEkran();
            ekran.Show();
            this.Hide();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            RandevuIslemleriSoapClient client = new RandevuIslemleriSoapClient();
            if (txttc.Text != "")
            {
                dataGridView1.DataSource = client.KisiGetir(txttc.Text);
            }
            else
            {
                dataGridView1.DataSource = client.RandevuListele();
            }
        }

        private void btnhizmetislemleri_Click(object sender, EventArgs e)
        {
            HizmetIslemleriEkran ekran = new HizmetIslemleriEkran();
            ekran.Show();
            this.Hide();
        }

        private void btnhekimislem_Click(object sender, EventArgs e)
        {
            HekimIslemleriEkran heekran = new HekimIslemleriEkran();
            heekran.Show();
            this.Hide();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            HastaSoapClient client = new HastaSoapClient();
            RandevuIslemleriSoapClient client2 = new RandevuIslemleriSoapClient();
            int id = client.IDGetir(msktcekle.Text);
            int hekimid = Convert.ToInt32(cmbdoktoradiekle.SelectedValue);
            string randevutarih = dttarihekle.Value.ToShortDateString();
            string saat = msksaatekle.Text;
            client2.RandevuEkle(id, hekimid, randevutarih, saat);
            MessageBox.Show("İşlem Başarılı!");
            msktcekle.Text = "";
            msksaatekle.Text = "";
            dttarihekle.Value = DateTime.Now;
            randevulistele();
        }

        private int hastaid;
        private int hekimid;
        private int randid;

        private void btnrandevuguncelle_Click(object sender, EventArgs e)
        {
            RandevuIslemleriSoapClient client = new RandevuIslemleriSoapClient();
            hekimid = Convert.ToInt32(cmbdoktorlar.SelectedValue);
            client.RandevuGuncelle(randid, hastaid, hekimid, dttarihguncelle.Value.ToShortDateString(), msksaatguncelle.Text);
            randevulistele();
            txtidguncelle.Text = "";
            msksaatguncelle.Text = "";

        }

        private void btnfaturaislem_Click(object sender, EventArgs e)
        {
            FaturaIslemleri fi = new FaturaIslemleri();
            fi.Show();
            this.Hide();
        }

        private void btnrandevuislem_Click(object sender, EventArgs e)
        {

        }

        private void dttarihfiltrele_ValueChanged(object sender, EventArgs e)
        {
            RandevuIslemleriSoapClient client = new RandevuIslemleriSoapClient();
            dataGridView1.DataSource = client.RandevuFiltrele(dttarihfiltrele.Value.ToShortDateString());
        }

        private void btnbugun_Click(object sender, EventArgs e)
        {
            RandevuIslemleriSoapClient client = new RandevuIslemleriSoapClient();
            dataGridView1.DataSource = client.RandevuFiltrele(DateTime.Now.ToShortDateString());
            dttarihfiltrele.Value = DateTime.Now;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Güncelle", datagridview1_guncelle));
                    m.MenuItems.Add(new MenuItem("Sil", datagridview1_sil));
                    m.MenuItems.Add(new MenuItem("Hekime Gönder", datagridview1_hekimegonder));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void datagridview1_hekimegonder(object sender, EventArgs e)
        {
            int randevuid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            int hastaid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

            txthekimrandevuid.Text = randevuid.ToString();
            txthekimhastaid.Text = hastaid.ToString();

        }

        private void datagridview1_sil(object sender, EventArgs e)
        {
            RandevuIslemleriSoapClient client = new RandevuIslemleriSoapClient();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            client.RandevuSil(id);
            randevulistele();
            dttarihfiltrele.Value = DateTime.Now;

        }

        private void datagridview1_guncelle(object sender, EventArgs e)
        {
            randid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            hastaid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            txtidguncelle.Text = randid.ToString();
        }

        private void btngonder_Click(object sender, EventArgs e)
        {
            HastaSoapClient client = new HastaSoapClient();
            int hekimid = Convert.ToInt32(cmbhekimdoktor.SelectedValue);
            int hastaid = Convert.ToInt32(txthekimhastaid.Text);
            client.hekimegonder(hastaid, hekimid);
            MessageBox.Show("İşlem Başarılı");
            txthekimhastaid.Text = "";
            txthekimrandevuid.Text = "";
        }

        private void Resepsiyon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

    }
}
