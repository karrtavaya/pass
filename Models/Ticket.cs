using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace pass.Models
{
    internal class Ticket
    {
        [Key]
        public Guid IdTicket { get; set; }
        public Passanger Passanger { get; set; }
        public Point PointDeparture { get; set; }
        public Point PointArrival { get; set; }
        public DateTime DataArriva { get; set; }


    }
}
