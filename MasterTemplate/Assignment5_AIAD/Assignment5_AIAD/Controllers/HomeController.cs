using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5_AIAD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VehiclesForSale()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}