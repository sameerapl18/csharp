using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIAD_Assign6.Models
{
    public class Ticket
    {
      public String Username {get; set;}
      public String description { get; set; }
      public String Priority { get; set; }
      public bool IsClosed { get; set; }
      public String AdditionalComments { get; set; }
      public String Resolution { get; set; }
      public DateTime DateResolved { get; set; }
      public DateTime DateOpened { get; set; }
      public DateTime DateClosed { get; set; }

    
    }
}