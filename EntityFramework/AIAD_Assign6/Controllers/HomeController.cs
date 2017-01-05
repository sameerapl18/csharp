using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIAD_Assign6.Models;

namespace AIAD_Assign6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Globals globals = new Globals();
            List<Ticket> tickets = globals.ListOfTickets;
            return View(globals);
        }

        public ActionResult AddTicket()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddTicket(Ticket ticket)
        {

            return View("Thankyou",ticket);
        }
    }
}