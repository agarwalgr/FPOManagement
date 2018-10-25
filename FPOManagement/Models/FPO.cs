using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPOManagement.Models
{
    public enum FPOType {
        FPO, FPC
    }

    public enum FPOPromoterType {
        NGO, SRLM, STATE_GOVT_DEPARTMENT,
            FARMERS_CLUB, BANK, FEDERATION, PACS, OTHER
    
    }

    public enum MeetingFrequency {
        WEEKLY, FORTNIGHTLY, MONTHLY
    }

    public class Auditor : Business {

        [Display(Name = "Auditor Name")]
        public string AuditorName { get; set; }

        public virtual ICollection<FPO> FPOs { get; set; }
    }

    public class FPOPromoter : Business
    {
        [Display(Name = "Promoter Type")]
        public FPOPromoterType FPOPromoterType { get; set; }

        public virtual ICollection<FPO> FPOs { get; set; }

    }

    public class FPO : Business
    { 
        [Display(Name = "FPO Type")]
        public FPOType FPOType { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of Formation")]
        public DateTime DateOfFormation { get; set; }

        [Display(Name = "Company Registration Number")]
        public string CompanyRegistrationNumber { get; set; }

        [Display(Name = "Board Meeting Frequency")]
        public MeetingFrequency MeetingFrequency { get; set; }


        public int? AuditorID { get; set; }
        public int? FPOPromoterID { get; set; }

        public virtual Auditor  Auditor { get; set; }
        public virtual FPOPromoter FPOPromoter { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<FPOAsset> FPOAssets { get; set; }
        public virtual ICollection<FPOBankAccount> BankAccounts { get; set; }

    }
}
