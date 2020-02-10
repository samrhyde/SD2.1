using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HydeMvcP1.Models
{
    public class order
    {
        public int orderID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}