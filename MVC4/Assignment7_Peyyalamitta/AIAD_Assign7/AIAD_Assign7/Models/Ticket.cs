using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AIAD_Assign7.Models
{
    public class Ticket
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is required")]
        [StringLength(30,MinimumLength=5, ErrorMessage = "Username should be between 5 and 30 characters long")]
        public String Username { get; set; }
        public String description { get; set; }

         [Required(AllowEmptyStrings = false, ErrorMessage = "Priority is required")]
        public String Priority { get; set; }

         [Required(AllowEmptyStrings = false, ErrorMessage = "Status is required")]
        public String Status { get; set; }
        public String AdditionalComments { get; set; }
        public String Resolution { get; set; }
        public DateTime DateResolved { get; set; }
        public System.DateTime DateOpened { get; set; }
        public DateTime DateClosed { get; set; }


    }
}