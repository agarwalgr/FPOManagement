using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FPOManagement.Models;

namespace FPOManagement.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new FPOManagementContext(
                serviceProvider.GetRequiredService<DbContextOptions<FPOManagementContext>>()))
            {
                if (context.FPO.Any()) { return;  }

                context.FPO.AddRange(
                    new FPO
                    {
                        BusinessName = "IAPCL",
                        CompanyRegistrationNumber = "C1234",
                        Phone = "8052805607",
                        DateOfFormation = DateTime.Parse("2018-01-01"),
                        FPOType = FPOType.FPC,
                        MeetingFrequency = MeetingFrequency.MONTHLY,
                      
                    });

                context.SaveChanges();
            }
        }
    }
}
