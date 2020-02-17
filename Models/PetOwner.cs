using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HydeMvcP1.Models
{
    public class PetOwner
    {
        public int petOwnerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        //public DateTime customerSince { get; set; }

        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Groomer> Groomer { get; set; }
    }
}