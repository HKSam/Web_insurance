using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_insurance.Models;
namespace Web_insurance.Controllers
{
    public class huqController : Controller
    {
        // GET: huq
        public ActionResult Index()
        {
            var name = new home { name = Session["name"].ToString() };
            return View(name);
        }
        public JsonResult Table()
        {
            MydataDataContext date = new MydataDataContext();
            var las = from r in date.manpower
                       where r.number == Session["number"].ToString()
                      select r;
            return Json(las, JsonRequestBehavior.AllowGet);
        }
        public int ReturnData(huq dat)
        {
            int s = 1;
            string numbernew = dat.numbernew;
            try
            {
                MydataDataContext datas = new MydataDataContext();
                var pass = from r in datas.manpower
                           where r.numbernew == numbernew
                           select r;
                datas.manpower.DeleteAllOnSubmit(pass);
                datas.SubmitChanges();
                s = 0;
            }
            catch (Exception)
            {
                Response.Write(" <script>function window.onload() {alert( '此保单删除失败' ); } </script> ");
            }
            return s;
        }
    }
}