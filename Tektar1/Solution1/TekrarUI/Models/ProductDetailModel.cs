using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TekrarEntityLayer;

namespace TekrarUI.Models
{
    public class ProductDetailModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
