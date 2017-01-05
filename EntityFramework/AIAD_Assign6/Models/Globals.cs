using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AIAD_Assign6.Models
{
    public  class Globals
{
public  List<Ticket> ListOfTickets
{
get
{
var list = new List<Ticket>()
{
new Ticket { Username = "John Smith", DateOpened = new DateTime(2020,3,21), IsClosed=true},
new Ticket { Username = "Jane Doe", DateOpened = new DateTime(2024,6,14), IsClosed=false},
new Ticket { Username = "Jill Jones", DateOpened = new DateTime(2022,9,8), IsClosed=true}
};
return list;
}
}
}

}