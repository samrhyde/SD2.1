using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HydeMvcP1.Models
{
    public class PetOwner
    {

        public int petOwnerID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Your name is required")]
        [StringLength(12)]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Your last name is required")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Your email is required")]
        [StringLength(30)]
        public string email { get; set; }
        [Display(Name = "Phone")]
        [DataType(DataType.PhoneNumber)]
        [Required( ErrorMessage = "Your phone number is required")]
        [StringLength(12)]
        public string phone { get; set; }
        //public DateTime customerSince { get; set; }

        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Groomer> Groomer { get; set; }
    }
}