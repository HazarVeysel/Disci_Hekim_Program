using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disci_Hekim_Program.HizmetServis;

namespace Disci_Hekim_Program
{
    public partial class HizmetIslemleriEkran : Form
    {
        public HizmetIslemleriEkran()
        {
            InitializeComponent();
        }

        private void HizmetIslemleriEkran_Load(object sender, EventArgs e)
        {
            Hizmetler1SoapClient client = new Hizmetler1SoapClient();
            hizmetlistele();
        }

        private void btnhizmetekle_Click(object sender, EventArgs e)
        {
            Hizmetler1SoapClient client = new Hizmetler1SoapClient();
            client.HizmetEkle(txthizmetadiekle.Text, Convert.ToDouble(txthizmetfiyatekle.Text));
            MessageBox.Show("Ekleme İşlemi Başarılı!");
            txthizmetadiekle.Text = "";
            txthizmetfiyatekle.Text = "";
            hizmetlistele();
        }

        private void btnhizmetguncelle_Click(object sender, EventArgs e)
        {
            Hizmetler1SoapClient client = new Hizmetler1SoapClient();
            int id = Convert.ToInt32(txtidguncelle.Text);
            client.HizmetGuncelle(id,txthizmetadiguncelle.Text,Convert.ToDouble(txthizmetfiyatguncelle.Text));
            MessageBox.Show("İşlem Başarılı");
            txthizmetfiyatguncelle.Text = "";
            txthizmetadiguncelle.Text = "";
            txthizmetfiyatguncelle.Enabled = false;
            txthizmetadiguncelle.Enabled = false;
            hizmetlistele();
        }

        private void hizmetlistele()
        {
            Hizmetler1SoapClient client = new Hizmetler1SoapClient();
            dataGridView1.DataSource = client.HizmetListele();
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

        private void dataGridView1_guncelle(object sender, EventArgs e)
        {
            int id;
            Hizmetler1SoapClient client = new Hizmetler1SoapClient();

            txthizmetadiguncelle.Enabled = true;
            txthizmetfiyatguncelle.Enabled = true;
            btnhizmetguncelle.Enabled = true;

            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            txtidguncelle.Text = id.ToString();
            txthizmetadiguncelle.Text = client.HizmetAdiGetir(id);
            txthizmetfiyatguncelle.Text = client.BirimFiyatGetir(id).ToString();
            
        }

        private void dataGridView1_sil(object sender, EventArgs e)
        {
            Hizmetler1SoapClient client = new Hizmetler1SoapClient();
            int id = (Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            client.HizmetSil(id);
            MessageBox.Show("Silme İşlemi Başarılı!");
            hizmetlistele();
        }

        private void txthizmetfiyatekle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void txthizmetfiyatguncelle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void HizmetIslemleriEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Resepsiyon rs = new Resepsiyon();
            rs.Show();
            this.Hide();
        }
    }
}
