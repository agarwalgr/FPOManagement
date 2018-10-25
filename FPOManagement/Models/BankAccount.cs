using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPOManagement.Models
{
    public abstract class BankAccount
    {

        public int BankAccountID { get; set; }

        [Display(Name = "Bank Name")]
        public string BankName { get; set; }

        [Display(Name = "Branch Name")]
        public string BankBranch { get; set; }

        [Display(Name = "Account Name")]
        public string AccountNumber { get; set; }

        [Display(Name = "IFSC Code")]
        public string IFSCCode { get; set; }

        [Display(Name = "Date of Account Opening")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfOpening { get; set; }

    }

    public class MemberBankAccount : BankAccount {
        public int MemberBankAccountID { get; set; }
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }
    }

    public class FPOBankAccount : BankAccount {
        public int FPOBankAccountID { get; set; }
        public int FPOID { get; set; }
        public virtual FPO FPO { get; set; }
    }
}
