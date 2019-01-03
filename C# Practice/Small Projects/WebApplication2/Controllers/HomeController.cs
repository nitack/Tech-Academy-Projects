using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> names = new List<string>
            {
                "Jesse",
                "Adam",
                "Brett"
            };
            return View(names);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(int number)
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}