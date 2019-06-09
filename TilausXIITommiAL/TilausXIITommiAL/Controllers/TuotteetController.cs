using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TilausXIITommiAL.Models;

namespace TilausXIITommiAL.Controllers
{
    public class TuotteetController : Controller
    {
        // GET: Tuotteet
        public ActionResult Index()
        {
            TilausDBEntities db = new TilausDBEntities();
            List<Tuotteet> model = db.Tuotteet.ToList();
            db.Dispose();
            return View(model);
        }
    }
}