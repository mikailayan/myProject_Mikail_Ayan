using MikoBussEntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MikoBussUI.Models
{
    public class BiletGuzergah
    {
        public List<Ticket> Tickets { get; set; }
        public List<Guzergah> Guzergahs { get; set; }
        public List<City> Cities { get; set; }
        public Guzergah Guzergah { get; set; }
        public Ticket Ticket { get; set; }
        public City city { get; set; }
        public int GuzergahId { get; set; }
        public int GuzergahPrice { get; set; }

    }
}
