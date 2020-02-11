using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HydeMvcP1.Models
{
    public class ApptDetail
    {
        public int apptDetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int appointmentID { get; set; }
        public virtual Appointment Appointment { get; set; }
        // the next two properties link the orderDetail to the Product
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }
    }
}