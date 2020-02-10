using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HydeMvcP1.Models
{
    public class Class1
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }
    }
}