using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MikoBussEntityLayer
{
    public class Guzergah
    {
        public int GuzergahId { get; set; }
        public string GuzergahStart { get; set; }
        public string GuzergahEnd { get; set; }
        public DateTime GuzergahTarihi { get; set; }
        public decimal GuzargahFiyat { get; set; }

        public List<Ticket> Tickets { get; set; }
    }
}
