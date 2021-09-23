using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disci_Hekim_Program.HekimServis;

namespace Disci_Hekim_Program
{
    public partial class HekimIslemleriEkran : Form
    {
        public HekimIslemleriEkran()
        {
            InitializeComponent();
        }

        private void HekimIslemleriEkran_Load(object sender, EventArgs e)
        {
            HekimListele();
        }
        private void HekimListele()
        {
            HekimSoapClient client = new HekimSoapClient();
            dataGridView1.DataSource = client.HekimleriGetir();
        }

        private void btnhekimekle_Click(object sender, EventArgs e)
        {
            HekimSoapClient client = new HekimSoapClient();
            client.hekimekle(txthekimadekle.Text, txthekimsoyadekle.Text);
            HekimListele();
            txthekimadekle.Text = "";
            txthekimsoyadekle.Text = "";
        }

        private void btnhekimguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidguncelle.Text);
            HekimSoapClient client = new HekimSoapClient();
            client.hekimguncelle(id, txthekimadiguncelle.Text, txthekimsoyadguncelle.Text);
            MessageBox.Show("İşlem Başarılı!");
            HekimListele();
            txtidguncelle.Text = "";
            txthekimadiguncelle.Text = "";
            txthekimsoyadguncelle.Text = "";
            txthekimadiguncelle.Enabled = false;
            txthekimsoyadguncelle.Enabled = false;
            btnhekimguncelle.Enabled = false;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Güncelle", dataGridView1_guncelle));
                    m.MenuItems.Add(new MenuItem("Sil", dataGridView1_sil));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void dataGridView1_sil(object sender, EventArgs e)
        {
            HekimSoapClient client = new HekimSoapClient();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            client.hekimsil(id);
            HekimListele();
        }

        private void dataGridView1_guncelle(object sender, EventArgs e)
        {
            txthekimadiguncelle.Enabled = true;
            txthekimsoyadguncelle.Enabled = true;
            btnhekimguncelle.Enabled = true;
            txtidguncelle.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txthekimadiguncelle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txthekimsoyadguncelle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void HekimIslemleriEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Resepsiyon rs = new Resepsiyon();
            rs.Show();
            this.Hide();
        }


    }
}
