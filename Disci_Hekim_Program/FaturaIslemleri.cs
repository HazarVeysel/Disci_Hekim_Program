using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Disci_Hekim_Program.IslemServis;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Disci_Hekim_Program.IslemDetay;

namespace Disci_Hekim_Program
{
    public partial class FaturaIslemleri : Form
    {
        public FaturaIslemleri()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Fatura Oluştur", datagridview1_faturaolustur));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void datagridview1_faturaolustur(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            double tutar = Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value);
            string hastaadi = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string hastasoyad = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string TC = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pdfolustur(hastaadi, hastasoyad,TC,id,tutar,hastaadi+"_"+hastasoyad);
        }

        private void pdfolustur(string ad, string soyad, string tc, int islemid, double tutar,string dosyaadi)
        {
            IslemDetaySoapClient client = new IslemDetaySoapClient();
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10f, 10f, 42f, 35f);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(dosyaadi+"_"+DateTime.Now.ToShortDateString()+"_"+tutar.ToString()+".pdf", FileMode.Create));
            doc.Open();
            var bosluk = new Paragraph("")
            {
                SpacingBefore = 10f,
                SpacingAfter = 10f
            };

            var baslik = new PdfPTable(new[] { .75f, 2f })
            {
                HorizontalAlignment = Left,
                WidthPercentage = 75,
                DefaultCell = { MinimumHeight = 22f }
            };

            baslik.AddCell("Tarih");
            baslik.AddCell(DateTime.Now.ToShortDateString());
            baslik.AddCell("Ad Soyad");
            baslik.AddCell(ad + " " + soyad);
            baslik.AddCell("TC");
            baslik.AddCell(tc);
            doc.Add(baslik);
            doc.Add(bosluk);

            var sutunsayisi = new[] { 2f, 1f, 1f };

            var icerik = new PdfPTable(new[] { 2f, 1f, 1f }) {
                HorizontalAlignment = 1,
                WidthPercentage = 100,
                DefaultCell = { MinimumHeight = 22f }
            };

            var tutaralani = new PdfPCell(new Phrase("Toplam Tutar : " + tutar.ToString()))
            {
                HorizontalAlignment = 2,
                Colspan = 3,
                MinimumHeight = 30f,
                PaddingRight = 25f
            };

            var anabaslik = new PdfPCell(new Phrase("Hesap Özeti"))
            {
                HorizontalAlignment = 1,
                Colspan = 3,
                MinimumHeight = 30f
            };

            icerik.AddCell(anabaslik);
            icerik.AddCell("YAPILAN ISLEM");
            icerik.AddCell("ADET");
            icerik.AddCell("BIRIM FIYAT");

            var liste = client.islemdetaylisteleID(islemid);

            foreach (var item in liste)
            {
                icerik.AddCell(item.IslemAdi.ToLower());
                icerik.AddCell(item.Adet.ToString().ToLower());
                icerik.AddCell(item.BirimFiyat.ToString().ToLower());
            }

            icerik.AddCell(tutaralani);
            

            doc.Add(icerik);
       

            doc.Close();
            System.Diagnostics.Process.Start(dosyaadi + "_" + DateTime.Now.ToShortDateString() + "_" + tutar.ToString()+".pdf");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string tarih = dateTimePicker1.Value.ToShortDateString();
            IslemlerSoapClient client = new IslemlerSoapClient();
            dataGridView1.DataSource = client.TariheGoreVeriGetir(tarih);
        }

        private void FaturaIslemleri_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            IslemlerSoapClient client = new IslemlerSoapClient();
            dataGridView1.DataSource = client.IslemListele();
        }

        private void FaturaIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Resepsiyon rs = new Resepsiyon();
            rs.Show();
            this.Hide();
        }
    }
}
