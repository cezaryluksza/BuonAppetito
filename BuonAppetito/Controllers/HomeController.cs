using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuonAppetito.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu1()
        {
            ViewBag.Message = "Propozycja menu na imprezę plenerową";

            return View();
        }

        public ActionResult Menu2()
        {
            ViewBag.Message = "Propozycja menu wielkanocnego";

            return View();
        }
        public ActionResult Menu3()
        {
            ViewBag.Message = "Propozycja menu wigilijnego";

            return View();
        }
    }
}