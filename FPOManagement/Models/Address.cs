using System;
using System.ComponentModel.DataAnnotations;

namespace FPOManagement.Models
{
    public enum State {
        TamilNadu, Karnataka
    }
    public abstract class Address
    {

        public int AddressID { get; set; }

        [Display(Name = "Address 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address 2")]
        public string Address2{ get; set; }


        [Display(Name = "Gram Panchayat")]
        public string GramPanchayat { get; set; }


        [Display(Name = "Village")]
        public string Village{ get; set; }

        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "District")]
        public string District { get; set; }


        [Display(Name = "State")]
        public State? State { get; set; }


        [Display(Name = "Pincode")]
        public int? Pincode { get; set; }
        
    }

    public class PersonAddress : Address {
        public int PersonAddressID { get; set; }
        public int PersonID { get; set; }
        public virtual Person Person { get; set; }
    }

    public class BusinessAddress : Address {
        public int BusinessAddressID { get; set; }
        public int BusinessID { get; set; }
        public virtual Business Business { get; set; }
    }
}
