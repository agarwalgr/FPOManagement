using System;
using System.ComponentModel.DataAnnotations;

namespace FPOManagement.Models
{
    public abstract class Business
    {
        public int BusinessID { get; set; }

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public virtual BusinessAddress Address { get; set; }

    }
}
