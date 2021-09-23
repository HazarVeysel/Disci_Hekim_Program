using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for Hekim
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Hekim : System.Web.Services.WebService
    {
        DisciDBEntities1 db = new DisciDBEntities1();
        [WebMethod]
        public string IsimGetir(string kadi, string sifre)
        {
            int adminid;
            string adsoyad;
            var getirilecek = (from i in db.AdminTablo
                               where i.KullaniciAdi == kadi && i.Sifre == sifre
                               select new
                               {
                                   i.AdminID
                               }).FirstOrDefault();

            adminid = getirilecek.AdminID;
            var hekim = (from i in db.HekimTablo
                         where i.AdminID == adminid
                         select new
                         {
                             i.HekimAdi,
                             i.HekimSoyad
                         }).FirstOrDefault();
            adsoyad = hekim.HekimAdi + " " + hekim.HekimSoyad;
            return adsoyad;
        }

        [WebMethod]
        public int HekimIDGetir(string kadi, string sifre)
        {
            int adminid;
            int hekimid;
            var getirilecek = (from i in db.AdminTablo
                               where i.KullaniciAdi == kadi && i.Sifre == sifre
                               select new
                               {
                                   i.AdminID
                               }).FirstOrDefault();

            adminid = getirilecek.AdminID;
            var hekim = (from i in db.HekimTablo
                         where i.AdminID == adminid
                         select new
                         {
                             i.HekimID
                         }).FirstOrDefault();
            hekimid = hekim.HekimID;
            return hekimid;
        }

        [WebMethod]
        public List<HekimListe> HekimleriGetir()
        {
            var liste = (from i in db.HekimTablo
                         select new HekimListe
                         {
                             HekimID = i.HekimID,
                             HekimAd = i.HekimAdi,
                             HekimSoyad = i.HekimSoyad
                         }).ToList();
            return liste;
        }

        public class HekimListe
        {
            public int HekimID { get; set; }
            public string HekimAd { get; set; }
            public string HekimSoyad { get; set; }
        }

        [WebMethod]
        public void hekimekle(string ad, string soyad)
        {
            HekimTablo tbl = new HekimTablo();
            tbl.HekimAdi = ad;
            tbl.HekimSoyad = soyad;
            db.HekimTablo.Add(tbl);
            db.SaveChanges();
        }

        [WebMethod]
        public void hekimguncelle(int id,string ad, string soyad)
        {
            var guncellenecek = (from i in db.HekimTablo
                                 where i.HekimID == id
                                 select i).FirstOrDefault();
            guncellenecek.HekimAdi = ad;
            guncellenecek.HekimSoyad = soyad;
            db.SaveChanges();
        }

        [WebMethod]
        public void hekimsil(int id)
        {
            var silinecek = (from i in db.HekimTablo
                             where i.HekimID == id
                             select i).FirstOrDefault();
            db.HekimTablo.Remove(silinecek);
            db.SaveChanges();
        }
    }
}
