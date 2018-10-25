using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPOManagement.Models
{
    public enum Gender
    {
        Male, Female, Other
    }

    public class Person
    {
        public int ID { get; set; }

        [Display(Name = "Member Name")]
        [Required]
        public string Name { get; set; }

        public Gender Gender { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public string Photo { get; set; }

        public virtual PersonAddress Address { get; set; }

    }
}
