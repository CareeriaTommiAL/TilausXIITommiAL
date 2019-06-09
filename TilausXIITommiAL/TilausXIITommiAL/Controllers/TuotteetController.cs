using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TilausXIITommiAL.Controllers
{
    public class TuotteetController : Controller
    {
        // GET: Tuotteet
        public ActionResult Index()
        {
            return View();
        }
    }
}