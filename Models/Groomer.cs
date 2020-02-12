﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HydeMvcP1.Models
{
    public class Groomer
    {
        //public int supplierID { get; set; }
        public int petOwnerID { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Appointment> Appointment { get; set; }
    }
}