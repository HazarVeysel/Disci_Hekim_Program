using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for Islemler
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Islemler : System.Web.Services.WebService
    {

        DisciDBEntities1 db = new DisciDBEntities1();
        [WebMethod]
        public List<Islem> GecmisIslemler(int id)
        {
            var liste = (from i in db.IslemTablo
                         join x in db.HastaTablo on i.HastaID equals x.HastaID
                         where i.HastaID == id
                         select new Islem
                         {
                             IslemID = i.IslemID,
                             HekimID = i.HekimID,
                             HastaID = i.HastaID,
                             HastaAdi = x.HastaAd,
                             HastaSoyad = x.HastaSoyad,
                             TC = x.TC,
                             IslemAdi = i.IslemAdi,
                             Tarih = i.Tarih,
                             ToplamTutar = i.ToplamTutar


                         }).ToList();
            return liste;
        }

        public class Islem
        {
            public int IslemID { get; set; }
            public int? HekimID { get; set; }
            public int? HastaID { get; set; }
            public string HastaAdi { get; set; }
            public string HastaSoyad { get; set; }
            public string TC { get; set; }
            public string IslemAdi { get; set; }
            public string Tarih { get; set; }
            public double? ToplamTutar { get; set; }

        }

        [WebMethod]
        public int IslemOlusturVeIDGetir(int hekimid, int hastaid, string islemadi, string tarih, double toplamtutar)
        {
            int id;
            IslemTablo tbl = new IslemTablo();
            tbl.HekimID = hekimid;
            tbl.HastaID = hastaid;
            tbl.IslemAdi = islemadi;
            tbl.Tarih = tarih;
            tbl.ToplamTutar = toplamtutar;
            db.IslemTablo.Add(tbl);
            db.SaveChanges();
            id = tbl.IslemID;
            return id;
        }

        [WebMethod]
        public List<Islem> TariheGoreVeriGetir(string tarih)
        {
            var liste = (from i in db.IslemTablo
                         join x in db.HastaTablo on i.HastaID equals x.HastaID
                         where i.Tarih == tarih
                         select new Islem
                         {
                             IslemID = i.IslemID,
                             HekimID = i.HekimID,
                             HastaID = i.HastaID,
                             HastaAdi = x.HastaAd,
                             HastaSoyad = x.HastaSoyad,
                             TC = x.TC,
                             IslemAdi = i.IslemAdi,
                             Tarih = i.Tarih,
                             ToplamTutar = i.ToplamTutar

                         }).ToList();
            return liste;
        }
        [WebMethod]
        public List<Islem> IslemListele()
        {
            var liste = (from i in db.IslemTablo
                         join x in db.HastaTablo on i.HastaID equals x.HastaID
                         orderby i.IslemID descending
                         select new Islem
                         {
                             IslemID = i.IslemID,
                             HekimID = i.HekimID,
                             HastaID = i.HastaID,
                             HastaAdi = x.HastaAd,
                             HastaSoyad = x.HastaSoyad,
                             TC = x.TC,
                             IslemAdi = i.IslemAdi,
                             Tarih = i.Tarih,
                             ToplamTutar = i.ToplamTutar

                         }).ToList();
            return liste;
        }

    }
}
