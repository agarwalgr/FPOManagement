using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPOManagement.Models
{
    public enum PrimaryOccupation {
        HOME_MAKER, LANDLESS_LABOURER, MARGINAL_FARMER, SMALL_FARMER
    }

    public enum Religion {
        HINDU, MUSLIM, CHRISTIAN, BUDDHIST, SIKH, JAIN, PARSI, OTHER
    }

    public enum Education {
        ILLITERATE, BELOW_5, PASSED_5, PASSED_8, PASSED_10, DEGREE 
    }

    public class MemberCommodity
    {
        public string MemberCommodityID { get; set; }

        [Display(Name = "Commodity Name")]
        public string CommodityName { get; set; }

        [Display(Name = "Farm Acreage devoted to Commodity")]
        public double Acreage { get; set; }
    
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }

    }

    public class MemberGroup
    {
        public int MemberGroupID { get; set; }

        [Display(Name = "Member Group Name")]
        public string GroupName { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }

    public class Member: Person
    {

        [Display(Name = "Member Code")]
        public int MemberCode { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Share Certificate Number")]
        public decimal ShareCertificateNumber { get; set; }

        [Display(Name = "Father/Husband Name")]
        public string FatherName { get; set; }

        [Display(Name = "Has Life Insurance?")]
        public bool HasLifeInsurance { get; set; }

        [Display(Name = "Has Health Insurance?")]
        public bool HasHealthInsurance { get; set; }

        [Display(Name = "Has MicroPension?")]
        public bool HasMicroPension { get; set; }

        [Display(Name = "Date of Joining FPO")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfJoining { get; set; }

        [Display(Name = "Is a Board of Director?")]
        public bool IsBOD { get; set; }
        
        [Display(Name = "Is Member of another Group?")]
        public bool MemberOfAnotherGroup { get; set; }

        [Display(Name = "Primary Occupation")]
        public PrimaryOccupation PrimaryOccupation { get; set; }

        [Display(Name = "Secondary Occupation")]
        public string SecondaryOccupation { get; set; }


        // Optional Information

        [Display(Name = "Caste")]
        public string Caste { get; set; }

        [Display(Name = "Religion")]
        public Religion Religion { get; set; }

        [Display(Name = "Aadhar Number")]
        public string AadharNumber { get; set; }
        
        [Display(Name = "Voter ID Number")]
        public string VoterIdNumber { get; set; }

        [Display(Name = "MNREGA Card Number")]
        public string MNREGACardNumber { get; set; }

        [Display(Name = "Main Income")]
        public string MainIncome { get; set; }

        [Display(Name = "Secondary Income")]
        public string SecondaryIncome { get; set; }

        [Display(Name = "Is Married?")]
        public bool IsMarried { get; set; }

        [Display(Name = "Is Differently Abled?")]
        public bool IsDifferentlyAbled { get; set; }

        [Display(Name = "Does the Member Migrate?")]
        public bool DoesMigrate { get; set; }

        [Display(Name = "Does the Family Migrate?")]
        public bool DoesFamilyMigrate { get; set; }

        [Display(Name = "Total number of household members")]
        public int TotalHouseholdMembers { get; set; }


        public int FPOID { get; set; }
        public int MemberGroupID { get; set; }

        // Links
        public virtual FPO FPO { get; set; }
        public virtual MemberGroup MemberGroup { get; set; }
        public virtual ICollection<MemberCommodity> MemberCommodities { get; set; }
        public virtual ICollection<MemberAsset> MemberAssets { get; set; }
        public virtual ICollection<MemberBankAccount> BankAccounts { get; set; }

    }

}
