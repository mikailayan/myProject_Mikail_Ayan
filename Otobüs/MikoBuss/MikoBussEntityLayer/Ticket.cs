using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikoBussEntityLayer
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public string TicketSurname { get; set; }
        public string TicketMail { get; set; }
        public string TicketNereden { get; set; }
        public string TicketNereye { get; set; }
        public int TicketSeatNo { get; set; }
        public decimal TicketPrice { get; set; }

        public Guzergah Guzergah { get; set; }
        public int GuzergahId { get; set; }

    }
}
