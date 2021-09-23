using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for Hasta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Hasta : System.Web.Services.WebService
    {
        DisciDBEntities1 db = new DisciDBEntities1();



        [WebMethod]
        public string IsimGetir(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id && i.Durum == "İşleme Alındı"
                         select i).FirstOrDefault();
            return sorgu.HastaAd;
        }
        [WebMethod]
        public string Soyad(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id && i.Durum == "İşleme Alındı"
                         select i).FirstOrDefault();
            return sorgu.HastaSoyad;
        }
        [WebMethod]
        public string TCGetir(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id && i.Durum == "İşleme Alındı"
                         select i).FirstOrDefault();
            return sorgu.TC;
        }
        [WebMethod]
        public string TelGetir(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id && i.Durum == "İşleme Alındı"
                         select i).FirstOrDefault();
            return sorgu.Tel;
        }
        [WebMethod]
        public string MailGetir(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id && i.Durum == "İşleme Alındı"
                         select i).FirstOrDefault();
            return sorgu.Mail;
        }
        [WebMethod]
        public int YasGetir(int id)
        {
            int yas;
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id && i.Durum == "İşleme Alındı"
                         select i).FirstOrDefault();
            yas = Convert.ToInt32(sorgu.Yas);
            return yas;
        }
        [WebMethod]
        public string CinsyetGetir(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id && i.Durum == "İşleme Alındı"
                         select i).FirstOrDefault();
            return sorgu.Cinsiyet;
        }

        [WebMethod]
        public int IDGetir(string TC)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.TC == TC
                         select new
                         {
                             i.HastaID
                         }).FirstOrDefault();
            return sorgu.HastaID;
        }

        [WebMethod]
        public void DurumGuncelle(int id, string durum)
        {
            var gnc = (from i in db.HastaTablo
                       where i.HastaID == id
                       select i).FirstOrDefault();
            gnc.Durum = durum;
            db.SaveChanges();
        }

        [WebMethod]
        public string IsimGetirResepsiyon(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id
                         select i).FirstOrDefault();
            return sorgu.HastaAd;
        }

        [WebMethod]
        public string SoyadGetirResepsiyon(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id
                         select i).FirstOrDefault();
            return sorgu.HastaSoyad;
        }

        [WebMethod]
        public string TCGetirResepsiyon(int id)
        {
            var sorgu = (from i in db.HastaTablo
                         where i.HekimID == id
                         select i).FirstOrDefault();
            return sorgu.TC;
        }

        [WebMethod]
        public List<Hastalar> HastaListele()
        {
            var liste = (from i in db.HastaTablo
                         select new Hastalar
                         {
                             HastaID = i.HastaID,
                             HekimID = i.HekimID,
                             HastaAd = i.HastaAd,
                             HastaSoyad = i.HastaSoyad,
                             TC = i.TC,
                             Tel = i.Tel,
                             Mail = i.Mail,
                             Durum = i.Durum,
                             Yas = i.Yas,
                             Cinsiyet = i.Cinsiyet
                         }).ToList();

            return liste;
        }

        public class Hastalar
        {
            public int HastaID { get; set; }
            public int? HekimID { get; set; }
            public string HastaAd { get; set; }
            public string HastaSoyad { get; set; }
            public string TC { get; set; }
            public string Tel { get; set; }
            public string Mail { get; set; }
            public string Durum { get; set; }
            public int? Yas { get; set; }
            public string Cinsiyet { get; set; }
        }

        [WebMethod]
        public List<Hastalar> HastaListeleTCGore(string tc)
        {
            var liste = (from i in db.HastaTablo
                         where i.TC == tc
                         select new Hastalar
                         {
                             HastaID = i.HastaID,
                             HekimID = i.HekimID,
                             HastaAd = i.HastaAd,
                             HastaSoyad = i.HastaSoyad,
                             TC = i.TC,
                             Tel = i.Tel,
                             Mail = i.Mail,
                             Durum = i.Durum,
                             Yas = i.Yas,
                             Cinsiyet = i.Cinsiyet
                         }).ToList();

            return liste;
        }

        [WebMethod]
        public void HastaEkle(string hastad, string hastasoyad, string tc, string tel, string mail, string durum, int yas, string cinsiyet)
        {
            HastaTablo tbl = new HastaTablo();
            tbl.HekimID = null;
            tbl.HastaAd = hastad;
            tbl.HastaSoyad = hastasoyad;
            tbl.TC = tc;
            tbl.Tel = tel;
            tbl.Mail = mail;
            tbl.Durum = durum;
            tbl.Yas = yas;
            tbl.Cinsiyet = cinsiyet;
            db.HastaTablo.Add(tbl);
            db.SaveChanges();
        }

        [WebMethod]
        public void HastaGuncelle(int id, string hastad, string hastasoyad, string tc, string tel, string mail, string durum, int yas, string cinsiyet)
        {
            var guncellenecek = (from i in db.HastaTablo
                                 where i.HastaID == id
                                 select i).FirstOrDefault();
            guncellenecek.HekimID = null;
            guncellenecek.HastaAd = hastad;
            guncellenecek.HastaSoyad = hastasoyad;
            guncellenecek.TC = tc;
            guncellenecek.Tel = tel;
            guncellenecek.Mail = mail;
            guncellenecek.Durum = durum;
            guncellenecek.Yas = yas;
            guncellenecek.Cinsiyet = cinsiyet;
            db.SaveChanges();
        }

        [WebMethod]
        public void hastasil(int id)
        {
            var silinecek = (from i in db.HastaTablo where i.HastaID == id select i).FirstOrDefault();
            db.HastaTablo.Remove(silinecek);
            db.SaveChanges();
        }

        [WebMethod]
        public void hekimegonder(int id, int hekimid)
        {
            var gnc = db.HastaTablo.Where(x => x.HastaID == id).FirstOrDefault();
            gnc.Durum = "İşleme Alındı";
            gnc.HekimID = hekimid;
            db.SaveChanges();
        }
    }
}
