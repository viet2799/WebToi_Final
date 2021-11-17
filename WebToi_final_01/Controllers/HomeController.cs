using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebToi_final_01.Models;
namespace WebToi_final_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var con = new Shop())
            {
                var model = con.SanPhams.ToList();
                return View(model);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}