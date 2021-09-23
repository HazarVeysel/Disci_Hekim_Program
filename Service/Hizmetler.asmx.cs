using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for Hizmetler1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Hizmetler1 : System.Web.Services.WebService
    {
        DisciDBEntities1 db = new DisciDBEntities1();
        [WebMethod]
        public List<Hizmet> HizmetListele()
        {
            var liste = (from i in db.Hizmetler
                         select new Hizmet
                         {
                             ID = i.ID,
                             HizmetAdi = i.HizmetAdi,
                             BirimFiyat = i.BirimFiyat
                         }).ToList();
            return liste;
        }

        public class Hizmet
        {
            public int ID { get; set; }
            public string HizmetAdi { get; set; }
            public double? BirimFiyat { get; set; }
        }

        [WebMethod]
        public double BirimFiyatGetir(int id)
        {
            double bf;
            var birimfiyat = (from i in db.Hizmetler
                              where i.ID == id
                              select new
                              {
                                  i.BirimFiyat
                              }).FirstOrDefault();
            bf = Convert.ToDouble(birimfiyat.BirimFiyat);
            return bf;
        }

        [WebMethod]
        public string HizmetAdiGetir(int id)
        {
            string ha;
            var hizmetad = (from i in db.Hizmetler
                            where i.ID == id
                            select new
                            {
                                i.HizmetAdi
                            }).FirstOrDefault();
            ha = hizmetad.HizmetAdi;
            return ha;
        }

        [WebMethod]
        public void HizmetEkle(string hizmetadi, double birimfiyat)
        {
            Hizmetler hz = new Hizmetler();
            hz.HizmetAdi = hizmetadi;
            hz.BirimFiyat = birimfiyat;
            db.Hizmetler.Add(hz);
            db.SaveChanges();
        }

        [WebMethod]
        public void HizmetGuncelle(int id, string hizmetadi, double birimfiyat)
        {
            var gnc = (from i in db.Hizmetler
                       where i.ID == id
                       select i).FirstOrDefault();
            gnc.HizmetAdi = hizmetadi;
            gnc.BirimFiyat = birimfiyat;
            db.SaveChanges();
        }


        [WebMethod]
        public void HizmetSil(int id)
        {
            var silinecek = (from i in db.Hizmetler
                             where i.ID == id
                             select i).FirstOrDefault();
            db.Hizmetler.Remove(silinecek);
            db.SaveChanges();
        }
    }
}
