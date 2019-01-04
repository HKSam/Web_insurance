using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_insurance.Models;
namespace Web_insurance.Controllers
{
    public class pinController : Controller
    {
        // GET: pin
        public ActionResult Index()
        {
            var name = new home { name = Session["name"].ToString() };
            return View(name);
        }
       
        public int ReturnData(pin dat)
        {
            string usernamet = dat.usernamet;
            string phonet = dat.phonet;
            string usernameb = dat.usernameb;
            string sexb = dat.sexb;
            string money = dat.money;
            string baodanid = dat.baodanid;
            string number = dat.number;
            string datel = dat.datel;
            try
            {
                MydataDataContext datas = new MydataDataContext();
                gus guss = new gus();
                guss.usernamet = usernamet;
                guss.phonet = phonet;
                guss.usernameb = usernameb;
                guss.sexb = sexb;
                guss.money = money;
                guss.baodanid = baodanid;
                guss.number = number;
                guss.datel = datel;
                datas.gus.InsertOnSubmit(guss);
                datas.SubmitChanges();
                var pass = from r in datas.data
                           where r.mouth == DateTime.Now.Month.ToString()
                           select r;
              if(pass!=null)  
                {
                    foreach(data r in pass)
                    {
                        int data3 = int.Parse(r.data3)+int.Parse(money);
                        int data1 = int.Parse(r.data1) + 1;
                        r.data1 = Convert.ToString(data1);
                        r.data3 = Convert.ToString(data3);
                        r.data4 = Convert.ToString(data3 * 0.4);
                    }

                    datas.SubmitChanges();
                }
            }
            catch (Exception)
            {
                Response.Write(" <script>function window.onload() {alert( '此保单号已注册' ); } </script> ");
            }

            return 0;
        }
    }
}