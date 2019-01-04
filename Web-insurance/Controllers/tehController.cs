using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_insurance.Models;

namespace Web_insurance.Controllers
{
    public class tehController : Controller
    {
        // GET: teh
        public ActionResult Index()
        {
            var name = new home { name = Session["name"].ToString() };
            return View(name);
        }

        public int ReturnData(teh dat)
        {
            string username = dat.username;
            string sext = dat.sext;
            string datet = dat.datet;
            string phonet = dat.phonet;
            string jiguan = dat.jiguan;
            string numbernew = dat.numbernew;
            string number = dat.number;
            string datel = dat.datel;
            try
            {
                MydataDataContext datas = new MydataDataContext();
                manpower manp = new manpower();
                manp.username = username;
                manp.sext = sext;
                manp.datet = datet;
                manp.phone = phonet;
                manp.jiguan = jiguan;
                manp.numbernew = numbernew;
                manp.number = number;
                manp.datel = datel;
                datas.manpower.InsertOnSubmit(manp);
                datas.SubmitChanges();
                var pass = from r in datas.data
                           where r.mouth == DateTime.Now.Month.ToString()
                           select r;
                if (pass != null)
                {
                    foreach (data r in pass)
                    {
                        int data2 = int.Parse(r.data2) + 1;
                        r.data2 = Convert.ToString(data2);
                    }
                    datas.SubmitChanges();
                }
            }
            catch(Exception)
            {
                Response.Write(" <script>function window.onload() {alert( '此工号已注册' ); } </script> ");
            }
          
            return 0;
        }
        
    }
}