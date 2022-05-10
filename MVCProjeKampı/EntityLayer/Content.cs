using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Content
    {
        public int ContentId { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingId { get; set; }
        public Heading Heading { get; set; }

        public int WriterID { get; set; }
        public Writer Writer { get; set; }

    }
}
