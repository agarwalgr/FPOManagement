﻿// <auto-generated />
using System;
using FPOManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FPOManagement.Migrations
{
    [DbContext(typeof(FPOManagementContext))]
    partial class FPOManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FPOManagement.Models.Business", b =>
                {
                    b.Property<int>("BusinessID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessName");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.HasKey("BusinessID");

                    b.ToTable("Business");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Business");
                });

            modelBuilder.Entity("FPOManagement.Models.BusinessAddress", b =>
                {
                    b.Property<int>("BusinessAddressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<int>("AddressID");

                    b.Property<int>("BusinessID");

                    b.Property<string>("City");

                    b.Property<string>("District");

                    b.Property<string>("GramPanchayat");

                    b.Property<int?>("Pincode");

                    b.Property<int?>("State");

                    b.Property<string>("Village");

                    b.HasKey("BusinessAddressID");

                    b.HasIndex("BusinessID")
                        .IsUnique();

                    b.ToTable("BusinessAddress");
                });

            modelBuilder.Entity("FPOManagement.Models.FPOAsset", b =>
                {
                    b.Property<int>("FPOAssetID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Acreage");

                    b.Property<int>("AssetID");

                    b.Property<int>("AssetType");

                    b.Property<int>("Count");

                    b.Property<bool>("DoesOwn");

                    b.Property<int>("FPOID");

                    b.Property<int>("HouseAssetType");

                    b.Property<int>("HouseType");

                    b.Property<int>("IrrigrationSource");

                    b.Property<int>("LandType");

                    b.Property<int>("LiveStockAssetType");

                    b.Property<string>("PumpType");

                    b.Property<string>("SRO");

                    b.Property<string>("SurveyNumber");

                    b.Property<string>("Village");

                    b.Property<string>("Zone");

                    b.HasKey("FPOAssetID");

                    b.HasIndex("FPOID");

                    b.ToTable("FPOAsset");
                });

            modelBuilder.Entity("FPOManagement.Models.FPOBankAccount", b =>
                {
                    b.Property<int>("FPOBankAccountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber");

                    b.Property<int>("BankAccountID");

                    b.Property<string>("BankBranch");

                    b.Property<string>("BankName");

                    b.Property<DateTime>("DateOfOpening");

                    b.Property<int>("FPOID");

                    b.Property<string>("IFSCCode");

                    b.HasKey("FPOBankAccountID");

                    b.HasIndex("FPOID");

                    b.ToTable("FPOBankAccount");
                });

            modelBuilder.Entity("FPOManagement.Models.MemberAsset", b =>
                {
                    b.Property<int>("MemberAssetID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Acreage");

                    b.Property<int>("AssetID");

                    b.Property<int>("AssetType");

                    b.Property<int>("Count");

                    b.Property<bool>("DoesOwn");

                    b.Property<int>("HouseAssetType");

                    b.Property<int>("HouseType");

                    b.Property<int>("IrrigrationSource");

                    b.Property<int>("LandType");

                    b.Property<int>("LiveStockAssetType");

                    b.Property<int>("MemberID");

                    b.Property<string>("PumpType");

                    b.Property<string>("SRO");

                    b.Property<string>("SurveyNumber");

                    b.Property<string>("Village");

                    b.Property<string>("Zone");

                    b.HasKey("MemberAssetID");

                    b.HasIndex("MemberID");

                    b.ToTable("MemberAsset");
                });

            modelBuilder.Entity("FPOManagement.Models.MemberBankAccount", b =>
                {
                    b.Property<int>("MemberBankAccountID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber");

                    b.Property<int>("BankAccountID");

                    b.Property<string>("BankBranch");

                    b.Property<string>("BankName");

                    b.Property<DateTime>("DateOfOpening");

                    b.Property<string>("IFSCCode");

                    b.Property<int>("MemberID");

                    b.HasKey("MemberBankAccountID");

                    b.HasIndex("MemberID");

                    b.ToTable("MemberBankAccount");
                });

            modelBuilder.Entity("FPOManagement.Models.MemberCommodity", b =>
                {
                    b.Property<string>("MemberCommodityID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Acreage");

                    b.Property<string>("CommodityName");

                    b.Property<int>("MemberID");

                    b.HasKey("MemberCommodityID");

                    b.HasIndex("MemberID");

                    b.ToTable("MemberCommodity");
                });

            modelBuilder.Entity("FPOManagement.Models.MemberGroup", b =>
                {
                    b.Property<int>("MemberGroupID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName");

                    b.HasKey("MemberGroupID");

                    b.ToTable("MemberGroup");
                });

            modelBuilder.Entity("FPOManagement.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("Gender");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<string>("Photo");

                    b.HasKey("ID");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("FPOManagement.Models.PersonAddress", b =>
                {
                    b.Property<int>("PersonAddressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<int>("AddressID");

                    b.Property<string>("City");

                    b.Property<string>("District");

                    b.Property<string>("GramPanchayat");

                    b.Property<int>("PersonID");

                    b.Property<int?>("Pincode");

                    b.Property<int?>("State");

                    b.Property<string>("Village");

                    b.HasKey("PersonAddressID");

                    b.HasIndex("PersonID")
                        .IsUnique();

                    b.ToTable("PersonAddress");
                });

            modelBuilder.Entity("FPOManagement.Models.Auditor", b =>
                {
                    b.HasBaseType("FPOManagement.Models.Business");

                    b.Property<string>("AuditorName");

                    b.ToTable("Auditor");

                    b.HasDiscriminator().HasValue("Auditor");
                });

            modelBuilder.Entity("FPOManagement.Models.FPO", b =>
                {
                    b.HasBaseType("FPOManagement.Models.Business");

                    b.Property<int?>("AuditorID");

                    b.Property<string>("CompanyRegistrationNumber");

                    b.Property<DateTime>("DateOfFormation");

                    b.Property<int?>("FPOPromoterID");

                    b.Property<int>("FPOType");

                    b.Property<int>("MeetingFrequency");

                    b.HasIndex("AuditorID");

                    b.HasIndex("FPOPromoterID");

                    b.ToTable("FPO");

                    b.HasDiscriminator().HasValue("FPO");
                });

            modelBuilder.Entity("FPOManagement.Models.FPOPromoter", b =>
                {
                    b.HasBaseType("FPOManagement.Models.Business");

                    b.Property<int>("FPOPromoterType");

                    b.ToTable("FPOPromoter");

                    b.HasDiscriminator().HasValue("FPOPromoter");
                });

            modelBuilder.Entity("FPOManagement.Models.Member", b =>
                {
                    b.HasBaseType("FPOManagement.Models.Person");

                    b.Property<string>("AadharNumber");

                    b.Property<string>("Caste");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("DateOfJoining");

                    b.Property<bool>("DoesFamilyMigrate");

                    b.Property<bool>("DoesMigrate");

                    b.Property<int>("FPOID");

                    b.Property<string>("FatherName");

                    b.Property<bool>("HasHealthInsurance");

                    b.Property<bool>("HasLifeInsurance");

                    b.Property<bool>("HasMicroPension");

                    b.Property<bool>("IsBOD");

                    b.Property<bool>("IsDifferentlyAbled");

                    b.Property<bool>("IsMarried");

                    b.Property<string>("MNREGACardNumber");

                    b.Property<string>("MainIncome");

                    b.Property<int>("MemberCode");

                    b.Property<int>("MemberGroupID");

                    b.Property<bool>("MemberOfAnotherGroup");

                    b.Property<int>("PrimaryOccupation");

                    b.Property<int>("Religion");

                    b.Property<string>("SecondaryIncome");

                    b.Property<string>("SecondaryOccupation");

                    b.Property<decimal>("ShareCertificateNumber");

                    b.Property<int>("TotalHouseholdMembers");

                    b.Property<string>("VoterIdNumber");

                    b.HasIndex("FPOID");

                    b.HasIndex("MemberGroupID");

                    b.ToTable("Member");

                    b.HasDiscriminator().HasValue("Member");
                });

            modelBuilder.Entity("FPOManagement.Models.BusinessAddress", b =>
                {
                    b.HasOne("FPOManagement.Models.Business", "Business")
                        .WithOne("Address")
                        .HasForeignKey("FPOManagement.Models.BusinessAddress", "BusinessID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPOManagement.Models.FPOAsset", b =>
                {
                    b.HasOne("FPOManagement.Models.FPO", "FPO")
                        .WithMany("FPOAssets")
                        .HasForeignKey("FPOID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPOManagement.Models.FPOBankAccount", b =>
                {
                    b.HasOne("FPOManagement.Models.FPO", "FPO")
                        .WithMany("BankAccounts")
                        .HasForeignKey("FPOID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPOManagement.Models.MemberAsset", b =>
                {
                    b.HasOne("FPOManagement.Models.Member", "Member")
                        .WithMany("MemberAssets")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPOManagement.Models.MemberBankAccount", b =>
                {
                    b.HasOne("FPOManagement.Models.Member", "Member")
                        .WithMany("BankAccounts")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPOManagement.Models.MemberCommodity", b =>
                {
                    b.HasOne("FPOManagement.Models.Member", "Member")
                        .WithMany("MemberCommodities")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPOManagement.Models.PersonAddress", b =>
                {
                    b.HasOne("FPOManagement.Models.Person", "Person")
                        .WithOne("Address")
                        .HasForeignKey("FPOManagement.Models.PersonAddress", "PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FPOManagement.Models.FPO", b =>
                {
                    b.HasOne("FPOManagement.Models.Auditor", "Auditor")
                        .WithMany("FPOs")
                        .HasForeignKey("AuditorID");

                    b.HasOne("FPOManagement.Models.FPOPromoter", "FPOPromoter")
                        .WithMany("FPOs")
                        .HasForeignKey("FPOPromoterID");
                });

            modelBuilder.Entity("FPOManagement.Models.Member", b =>
                {
                    b.HasOne("FPOManagement.Models.FPO", "FPO")
                        .WithMany("Members")
                        .HasForeignKey("FPOID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FPOManagement.Models.MemberGroup", "MemberGroup")
                        .WithMany("Members")
                        .HasForeignKey("MemberGroupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
