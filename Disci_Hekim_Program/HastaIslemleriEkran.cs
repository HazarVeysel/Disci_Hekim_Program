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

namespace Disci_Hekim_Program
{
    public partial class HastaIslemleriEkran : Form
    {
        public HastaIslemleriEkran()
        {
            InitializeComponent();
        }

        private void HastaIslemleriEkran_Load(object sender, EventArgs e)
        {
            Hastalistele();
            
        }

        private void Hastalistele()
        {
            HastaSoapClient client = new HastaSoapClient();
            dataGridView1.DataSource = client.HastaListele();
        }

        private void HastaListeleTC(string tc)
        {
            HastaSoapClient client = new HastaSoapClient();
            dataGridView1.DataSource = client.HastaListeleTCGore(tc);
        }

        private void msktc_TextChanged(object sender, EventArgs e)
        {
            if (msktc.Text == "")
            {
                Hastalistele();
            }
            else
            {
                HastaListeleTC(msktc.Text);
            }

        }

        private void btnhastaekle_Click(object sender, EventArgs e)
        {
            HastaSoapClient client = new HastaSoapClient();
            client.HastaEkle(txtadekle.Text, txtsoyadekle.Text, msktcekle.Text, txttelekle.Text, txtmailekle.Text, "Boşta", Convert.ToInt32(nmyasekle.Value), cmbcinsiyetekle.Text);
            MessageBox.Show("Başarılı");
            txtadekle.Text = "";
            txtsoyadekle.Text = "";
            msktcekle.Text = "";
            txttelekle.Text = "";
            txtmailekle.Text = "";
            nmyasekle.Value = 0;
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
            HastaSoapClient client = new HastaSoapClient();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            client.hastasil(id);
            Hastalistele();
        }

        private void dataGridView1_guncelle(object sender, EventArgs e)
        {
            txthastaadiguncelle.Enabled = true;
            txthastasoyadiguncelle.Enabled = true;
            msktcguncelle.Enabled = true;
            txttelguncelle.Enabled = true;
            txtmailguncelle.Enabled = true;
            nmyasguncelle.Enabled = true;
            cmbcinsiyetguncelle.Enabled = true;
            btnguncelle.Enabled = true;
            txthastaidguncelle.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txthastaadiguncelle.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txthastasoyadiguncelle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            msktcguncelle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txttelguncelle.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtmailguncelle.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            nmyasguncelle.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txthastaidguncelle.Text);
            HastaSoapClient client = new HastaSoapClient();
            client.HastaGuncelle(id, txthastaadiguncelle.Text, txthastasoyadiguncelle.Text, msktcguncelle.Text, txttelguncelle.Text, txtmailguncelle.Text, "Boşta", Convert.ToInt32(nmyasguncelle.Value), cmbcinsiyetguncelle.Text);
            MessageBox.Show("Başarılı");
            Hastalistele();
            txthastaadiguncelle.Text = "";
            txthastasoyadiguncelle.Text = "";
            msktcguncelle.Text = "";
            txttelguncelle.Text = "";
            txtmailguncelle.Text = "";
            nmyasguncelle.Value = 0;
            txthastaadiguncelle.Enabled = false;
            txthastasoyadiguncelle.Enabled = false;
            msktcguncelle.Enabled = false;
            txttelguncelle.Enabled = false;
            txtmailguncelle.Enabled = false;
            nmyasguncelle.Enabled = false;
            cmbcinsiyetguncelle.Enabled = false;
            btnguncelle.Enabled = false;

        }

        private void HastaIslemleriEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Resepsiyon rs = new Resepsiyon();
            rs.Show();
            this.Hide();
        }
    }
}
