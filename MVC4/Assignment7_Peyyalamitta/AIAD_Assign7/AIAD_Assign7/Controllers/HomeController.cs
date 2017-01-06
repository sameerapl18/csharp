using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AIAD_Assign7.Models;

namespace AIAD_Assign7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Globals globals = new Globals();
           
            return View(globals);
        }

        public ActionResult AddTicket()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddTicket(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                using (Database1Entities db = new Database1Entities())
                {
                    TicketTable tableTicket = new TicketTable();

                    tableTicket.Username = ticket.Username;
                    tableTicket.DateOpened = System.DateTime.Today;
                    tableTicket.Status = ticket.Status;
                    tableTicket.Priority = ticket.Priority;
                    if (ticket.description != null)
                    {
                        tableTicket.ProbDesc = ticket.description;
                    }
                    if (ticket.Resolution != null)
                    {
                        tableTicket.Resolution = ticket.Resolution;
                    }
                    if (ticket.AdditionalComments != null)
                    {
                        tableTicket.AdditionalComments = ticket.AdditionalComments;
                    }


                    db.TicketTables.Add(tableTicket);
                    db.SaveChanges();

                }

                return View("Thankyou", ticket);
            }
            return View();
        }
    }
}