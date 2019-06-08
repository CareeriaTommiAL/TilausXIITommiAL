using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TilausXIITommiAL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Mistä tässä on kysymys?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Näistä minut tavoittaa.";

            return View();
        }

        public ActionResult Map()
        {
            ViewBag.Message = "Kartta";

            return View();
        }
    }
}