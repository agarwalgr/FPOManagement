using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Models
{
    public class FPOManagementContext : DbContext
    {
        public FPOManagementContext (DbContextOptions<FPOManagementContext> options)
            : base(options)
        {
        }

        public DbSet<FPOManagement.Models.Member> Member { get; set; }

        public DbSet<FPOManagement.Models.FPO> FPO { get; set; }

        public DbSet<FPOManagement.Models.MemberAsset> MemberAsset { get; set; }

        public DbSet<FPOManagement.Models.Asset> Asset { get; set; }

        public DbSet<FPOManagement.Models.BankAccount> BankAccount { get; set; }

        public DbSet<FPOManagement.Models.Auditor> Auditor { get; set; }

        public DbSet<FPOManagement.Models.FPOPromoter> FPOPromoter { get; set; }

        public DbSet<FPOManagement.Models.MemberGroup> MemberGroup { get; set; }
    }
}
