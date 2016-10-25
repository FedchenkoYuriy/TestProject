using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Client()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Patrol()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult ClienList()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
       
    }
}
