using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery
{
    class ProductInfo
    {
        public int IDproduct { get; set; }
        public string NameProduct { get; set; }
        public decimal PriceProduct { get; set; }
        public int Quantity { get; set; }


        //get and set used because we have a private List in Shopping Form.
    }
}
