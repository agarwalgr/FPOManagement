using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPOManagement.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Business",
                columns: table => new
                {
                    BusinessID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessName = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AuditorName = table.Column<string>(nullable: true),
                    FPOType = table.Column<int>(nullable: true),
                    DateOfFormation = table.Column<DateTime>(nullable: true),
                    CompanyRegistrationNumber = table.Column<string>(nullable: true),
                    MeetingFrequency = table.Column<int>(nullable: true),
                    AuditorID = table.Column<int>(nullable: true),
                    FPOPromoterID = table.Column<int>(nullable: true),
                    FPOPromoterType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business", x => x.BusinessID);
                    table.ForeignKey(
                        name: "FK_Business_Business_AuditorID",
                        column: x => x.AuditorID,
                        principalTable: "Business",
                        principalColumn: "BusinessID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Business_Business_FPOPromoterID",
                        column: x => x.FPOPromoterID,
                        principalTable: "Business",
                        principalColumn: "BusinessID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberGroup",
                columns: table => new
                {
                    MemberGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberGroup", x => x.MemberGroupID);
                });

            migrationBuilder.CreateTable(
                name: "BusinessAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    GramPanchayat = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: true),
                    Pincode = table.Column<int>(nullable: true),
                    BusinessAddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BusinessID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessAddress", x => x.BusinessAddressID);
                    table.ForeignKey(
                        name: "FK_BusinessAddress_Business_BusinessID",
                        column: x => x.BusinessID,
                        principalTable: "Business",
                        principalColumn: "BusinessID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FPOAsset",
                columns: table => new
                {
                    AssetID = table.Column<int>(nullable: false),
                    AssetType = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    LiveStockAssetType = table.Column<int>(nullable: false),
                    HouseType = table.Column<int>(nullable: false),
                    HouseAssetType = table.Column<int>(nullable: false),
                    LandType = table.Column<int>(nullable: false),
                    DoesOwn = table.Column<bool>(nullable: false),
                    IrrigrationSource = table.Column<int>(nullable: false),
                    PumpType = table.Column<string>(nullable: true),
                    Acreage = table.Column<double>(nullable: false),
                    Zone = table.Column<string>(nullable: true),
                    SRO = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    SurveyNumber = table.Column<string>(nullable: true),
                    FPOAssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FPOID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FPOAsset", x => x.FPOAssetID);
                    table.ForeignKey(
                        name: "FK_FPOAsset_Business_FPOID",
                        column: x => x.FPOID,
                        principalTable: "Business",
                        principalColumn: "BusinessID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FPOBankAccount",
                columns: table => new
                {
                    BankAccountID = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    BankBranch = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    IFSCCode = table.Column<string>(nullable: true),
                    DateOfOpening = table.Column<DateTime>(nullable: false),
                    FPOBankAccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FPOID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FPOBankAccount", x => x.FPOBankAccountID);
                    table.ForeignKey(
                        name: "FK_FPOBankAccount_Business_FPOID",
                        column: x => x.FPOID,
                        principalTable: "Business",
                        principalColumn: "BusinessID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    MemberCode = table.Column<int>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    ShareCertificateNumber = table.Column<decimal>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    HasLifeInsurance = table.Column<bool>(nullable: true),
                    HasHealthInsurance = table.Column<bool>(nullable: true),
                    HasMicroPension = table.Column<bool>(nullable: true),
                    DateOfJoining = table.Column<DateTime>(nullable: true),
                    IsBOD = table.Column<bool>(nullable: true),
                    MemberOfAnotherGroup = table.Column<bool>(nullable: true),
                    PrimaryOccupation = table.Column<int>(nullable: true),
                    SecondaryOccupation = table.Column<string>(nullable: true),
                    Caste = table.Column<string>(nullable: true),
                    Religion = table.Column<int>(nullable: true),
                    AadharNumber = table.Column<string>(nullable: true),
                    VoterIdNumber = table.Column<string>(nullable: true),
                    MNREGACardNumber = table.Column<string>(nullable: true),
                    MainIncome = table.Column<string>(nullable: true),
                    SecondaryIncome = table.Column<string>(nullable: true),
                    IsMarried = table.Column<bool>(nullable: true),
                    IsDifferentlyAbled = table.Column<bool>(nullable: true),
                    DoesMigrate = table.Column<bool>(nullable: true),
                    DoesFamilyMigrate = table.Column<bool>(nullable: true),
                    TotalHouseholdMembers = table.Column<int>(nullable: true),
                    FPOID = table.Column<int>(nullable: true),
                    MemberGroupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Person_Business_FPOID",
                        column: x => x.FPOID,
                        principalTable: "Business",
                        principalColumn: "BusinessID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Person_MemberGroup_MemberGroupID",
                        column: x => x.MemberGroupID,
                        principalTable: "MemberGroup",
                        principalColumn: "MemberGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberAsset",
                columns: table => new
                {
                    AssetID = table.Column<int>(nullable: false),
                    AssetType = table.Column<int>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    LiveStockAssetType = table.Column<int>(nullable: false),
                    HouseType = table.Column<int>(nullable: false),
                    HouseAssetType = table.Column<int>(nullable: false),
                    LandType = table.Column<int>(nullable: false),
                    DoesOwn = table.Column<bool>(nullable: false),
                    IrrigrationSource = table.Column<int>(nullable: false),
                    PumpType = table.Column<string>(nullable: true),
                    Acreage = table.Column<double>(nullable: false),
                    Zone = table.Column<string>(nullable: true),
                    SRO = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    SurveyNumber = table.Column<string>(nullable: true),
                    MemberAssetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberAsset", x => x.MemberAssetID);
                    table.ForeignKey(
                        name: "FK_MemberAsset_Person_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberBankAccount",
                columns: table => new
                {
                    BankAccountID = table.Column<int>(nullable: false),
                    BankName = table.Column<string>(nullable: true),
                    BankBranch = table.Column<string>(nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    IFSCCode = table.Column<string>(nullable: true),
                    DateOfOpening = table.Column<DateTime>(nullable: false),
                    MemberBankAccountID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberBankAccount", x => x.MemberBankAccountID);
                    table.ForeignKey(
                        name: "FK_MemberBankAccount_Person_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberCommodity",
                columns: table => new
                {
                    MemberCommodityID = table.Column<string>(nullable: false),
                    CommodityName = table.Column<string>(nullable: true),
                    Acreage = table.Column<double>(nullable: false),
                    MemberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCommodity", x => x.MemberCommodityID);
                    table.ForeignKey(
                        name: "FK_MemberCommodity_Person_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddress",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false),
                    Address1 = table.Column<string>(nullable: true),
                    Address2 = table.Column<string>(nullable: true),
                    GramPanchayat = table.Column<string>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    State = table.Column<int>(nullable: true),
                    Pincode = table.Column<int>(nullable: true),
                    PersonAddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PersonID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddress", x => x.PersonAddressID);
                    table.ForeignKey(
                        name: "FK_PersonAddress_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Business_AuditorID",
                table: "Business",
                column: "AuditorID");

            migrationBuilder.CreateIndex(
                name: "IX_Business_FPOPromoterID",
                table: "Business",
                column: "FPOPromoterID");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessAddress_BusinessID",
                table: "BusinessAddress",
                column: "BusinessID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FPOAsset_FPOID",
                table: "FPOAsset",
                column: "FPOID");

            migrationBuilder.CreateIndex(
                name: "IX_FPOBankAccount_FPOID",
                table: "FPOBankAccount",
                column: "FPOID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberAsset_MemberID",
                table: "MemberAsset",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberBankAccount_MemberID",
                table: "MemberBankAccount",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberCommodity_MemberID",
                table: "MemberCommodity",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_FPOID",
                table: "Person",
                column: "FPOID");

            migrationBuilder.CreateIndex(
                name: "IX_Person_MemberGroupID",
                table: "Person",
                column: "MemberGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_PersonID",
                table: "PersonAddress",
                column: "PersonID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessAddress");

            migrationBuilder.DropTable(
                name: "FPOAsset");

            migrationBuilder.DropTable(
                name: "FPOBankAccount");

            migrationBuilder.DropTable(
                name: "MemberAsset");

            migrationBuilder.DropTable(
                name: "MemberBankAccount");

            migrationBuilder.DropTable(
                name: "MemberCommodity");

            migrationBuilder.DropTable(
                name: "PersonAddress");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Business");

            migrationBuilder.DropTable(
                name: "MemberGroup");
        }
    }
}
