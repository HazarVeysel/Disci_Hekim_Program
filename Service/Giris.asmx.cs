using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for Giris
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Giris : System.Web.Services.WebService
    {

        [WebMethod]
        public int GirisKontrol(string kullaniciadi, string sifre)
        {
            using (DisciDBEntities1 db = new DisciDBEntities1())
            {
                var kisi = (from i in db.AdminTablo
                            where
                                i.KullaniciAdi == kullaniciadi && i.Sifre == sifre
                            select new
                            {
                                i.KullaniciAdi,
                                i.Sifre,
                                i.Hekimmi
                            }).FirstOrDefault();
                if (kisi != null)
                {
                    if (kisi.Hekimmi == true)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        [WebMethod]
        public string SifreGonder(string mail)
        {
            using (DisciDBEntities1 db = new DisciDBEntities1())
            {
                var kontrol = (from i in db.AdminTablo
                               where i.Mail == mail
                               select i).FirstOrDefault();
                return kontrol.Sifre;
            }
        }
        [WebMethod]
        public bool MailKontrol(string mail)
        {
            using (DisciDBEntities1 db = new DisciDBEntities1())
            {
                var kontrol = (from i in db.AdminTablo
                               where i.Mail == mail
                               select i).FirstOrDefault();
                if (kontrol != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
