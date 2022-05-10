using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Product
    {
        public int ProductId { get; set; }
        public string PropductName { get; set; }
        public string ProductDetail { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
