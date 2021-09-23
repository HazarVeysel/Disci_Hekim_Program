using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for RandevuIslemleri
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RandevuIslemleri : System.Web.Services.WebService
    {

        DisciDBEntities1 db = new DisciDBEntities1();

        [WebMethod]
        public List<Randevu> RandevuListele()
        {
            string tarih = DateTime.Now.ToShortDateString();
            var liste = (from i in db.RandevuTablo
                         join x in db.HastaTablo on i.HastaID equals x.HastaID
                         where i.RandevuTarih == tarih
                         select new Randevu
                         {
                             RandevuID = i.RandevuID,
                             HastaID = i.HastaID,
                             HastaAdi = x.HastaAd,
                             HekimID = i.HekimID,
                             HastaSoyad = x.HastaSoyad,
                             TC = x.TC,
                             RandevuTarih = i.RandevuTarih,
                             RandevuSaat = i.RandevuSaat
                         }).ToList();
            return liste;
        }

        public class Randevu
        {
            public int RandevuID { get; set; }
            public int? HastaID { get; set; }
            public int? HekimID { get; set; }
            public string HastaAdi { get; set; }
            public string HastaSoyad { get; set; }
            public string TC { get; set; }
            public string RandevuTarih { get; set; }
            public string RandevuSaat { get; set; }
        }

        [WebMethod]
        public List<Randevu> KisiGetir(string TC)
        {
            var liste = (from i in db.RandevuTablo
                         join x in db.HastaTablo on i.HastaID equals x.HastaID
                         where x.TC == TC
                         select new Randevu
                         {
                             RandevuID = i.RandevuID,
                             HastaID = i.HastaID,
                             HastaAdi = x.HastaAd,
                             HastaSoyad = x.HastaSoyad,
                             TC = x.TC,
                             RandevuTarih = i.RandevuTarih,
                             RandevuSaat = i.RandevuSaat
                         }).ToList();
            return liste;
        }

        [WebMethod]
        public void RandevuEkle(int hastaid, int hekimid, string tarih, string saat)
        {
            RandevuTablo tbl = new RandevuTablo();
            tbl.HastaID = hastaid;
            tbl.HekimID = hekimid;
            tbl.RandevuTarih = tarih;
            tbl.RandevuSaat = saat;
            db.RandevuTablo.Add(tbl);
            db.SaveChanges();
        }

        [WebMethod]
        public List<Randevu> RandevuFiltrele(string tarih)
        {
            var liste = (from i in db.RandevuTablo
                         join x in db.HastaTablo on i.HastaID equals x.HastaID
                         where i.RandevuTarih == tarih
                         select new Randevu
                         {
                             RandevuID = i.RandevuID,
                             HastaID = i.HastaID,
                             HastaAdi = x.HastaAd,
                             HekimID = i.HekimID,
                             HastaSoyad = x.HastaSoyad,
                             TC = x.TC,
                             RandevuTarih = i.RandevuTarih,
                             RandevuSaat = i.RandevuSaat
                         }).ToList();
            return liste;
        }

        [WebMethod]
        public void RandevuGuncelle(int id, int hastaid, int hekimid, string randevutarih, string randevusaat)
        {
            var guncellenecek = (from i in db.RandevuTablo
                                 where i.RandevuID == id
                                 select i).FirstOrDefault();
            guncellenecek.HastaID = hastaid;
            guncellenecek.HekimID = hekimid;
            guncellenecek.RandevuTarih = randevutarih;
            guncellenecek.RandevuSaat = randevusaat;
            db.SaveChanges();

        }

        [WebMethod]
        public void RandevuSil(int id)
        {
            var silinecek = (from i in db.RandevuTablo
                             where i.RandevuID == id
                             select i).FirstOrDefault();
            db.RandevuTablo.Remove(silinecek);
            db.SaveChanges();
        }

        [WebMethod]
        public void hekimata(int randid, int hekimid){
            var guncellenecek = (from i in db.RandevuTablo
                                 where i.RandevuID == randid
                                 select i).FirstOrDefault();
            guncellenecek.HekimID = hekimid;
            db.SaveChanges();
        }
    }
}
