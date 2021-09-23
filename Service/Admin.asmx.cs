using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    /// <summary>
    /// Summary description for Admin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Admin : System.Web.Services.WebService
    {
        DisciDBEntities1 db = new DisciDBEntities1();

        [WebMethod]
        public bool MailVarMi(string mail)
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
