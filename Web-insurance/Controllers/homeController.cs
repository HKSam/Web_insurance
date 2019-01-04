using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_insurance.Models;

namespace Web_insurance.Controllers
{
    public class homeController : Controller
    {
        public string username;
        // GET: home
        public ActionResult Index()
        {
            username = Session["name"].ToString();
            var name = new home { name = Session["name"].ToString() };

            DateTime.Now.Month.ToString();
            MydataDataContext datas = new MydataDataContext();
            var pass = from r in datas.data
                       where (r.mouth == DateTime.Now.Month.ToString()) && (r.name == Session["name"].ToString())
                       select r;
            ViewBag.home = pass;
            var datad = from s in datas.data
                        where s.name == Session["name"].ToString()
                        select s;
            ViewBag.data = datad;
            return View(name);
        }


    }
}