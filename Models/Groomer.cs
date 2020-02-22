using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HydeMvcP1.Models
{
    public class Groomer
    {
        [Display(Name = "Groomer")]
        [Required(ErrorMessage = "Groomer ID required")]
        [StringLength(12)]
        public int groomerID { get; set; }
        [Display(Name = "Pet Owner")]
        [Required(ErrorMessage = "Owner ID required")]
        [StringLength(12)]
        public int petOwnerID { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Leave a brief description required")]
        [StringLength(80)]
        public string description { get; set; }
        [Display(Name = "Review Score")]
        [Required(ErrorMessage = "Please leave a score 1-5")]
        [StringLength(12)]
        public int reviewScore { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<PetOwner> petOwner { get; set; }
    }
}