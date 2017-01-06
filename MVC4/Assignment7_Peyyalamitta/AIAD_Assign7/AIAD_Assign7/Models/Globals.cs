using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIAD_Assign7.Models
{
    public class Globals
    {
        public List<Ticket> ListOfTickets
        {
            get
            {
                List<Ticket> myTickets = new List<Ticket>();
                using (Database1Entities db = new Database1Entities())
                {

                    var result = (from p in db.TicketTables
                                  select new
                                  {
                                      Date = p.DateOpened ,
                                      //.Date.Month + "/" + i.Date.Date.Day + "/" + i.Date.Date.Year,
                                      Username = p.Username,
                                      Status = p.Status,
                                      Priority = p.Priority

                                  }).ToList();

                    for (int i = 0; i < result.Count; i++)
                    {
                        Ticket ticket = new Ticket();
                        ticket.Username = result[i].Username;
                        ticket.DateOpened = result[i].Date.Value;
                        ticket.Status = result[i].Status;
                        ticket.Priority = result[i].Priority;

                        myTickets.Add(ticket);



                    }



                }

                return myTickets;
            }
        }
    }
}