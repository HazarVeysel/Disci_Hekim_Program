using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for IslemDetay
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class IslemDetay : System.Web.Services.WebService
    {

        DisciDBEntities1 db = new DisciDBEntities1();

        [WebMethod]
        public void IslemDetayEkle(int islemid, string islemadi, double birimfiyat, int adet)
        {
            IslemDetayTablo tbl = new IslemDetayTablo();
            tbl.IslemID = islemid;
            tbl.İslemAdi = islemadi;
            tbl.BirimFiyat = birimfiyat;
            tbl.Adet = adet;
            db.IslemDetayTablo.Add(tbl);
            db.SaveChanges();
        }

        [WebMethod]
        public List<IslemDetaylari> islemdetaylisteleID(int islemid)
        {
            var liste = (from i in db.IslemDetayTablo
                         where i.IslemID == islemid
                         select new IslemDetaylari
                         {
                             IslemAdi = i.İslemAdi,
                             Adet = i.Adet,
                             BirimFiyat = i.BirimFiyat
                         }).ToList();

            return liste;

        }

        public class IslemDetaylari
        {
            public string IslemAdi { get; set; }
            public int? Adet { get; set; }
            public double? BirimFiyat { get; set; }
        }
    }
}
