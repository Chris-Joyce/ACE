using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTrackingSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false),
                    LicenseNumber = table.Column<string>(nullable: true),
                    CBHT = table.Column<bool>(nullable: false),
                    APDSupportedLiving = table.Column<bool>(nullable: false),
                    APDSupportedEmployement = table.Column<bool>(nullable: false),
                    ARNP = table.Column<bool>(nullable: false),
                    DCFHippastartDate = table.Column<DateTime>(nullable: false),
                    DCFHippaEndDate = table.Column<DateTime>(nullable: false),
                    VehicleRegistrationStartDate = table.Column<DateTime>(nullable: false),
                    VehicleRegistrationEndDate = table.Column<DateTime>(nullable: false),
                    VehicleInsuranceCardStartDate = table.Column<DateTime>(nullable: false),
                    VehicleInsuranceCardEndDate = table.Column<DateTime>(nullable: false),
                    YearlyEvaluationStartDate = table.Column<DateTime>(nullable: false),
                    YearlyEvaluationEndDate = table.Column<DateTime>(nullable: false),
                    TargetCaseManagmentStartDate = table.Column<DateTime>(nullable: false),
                    TargetCaseManagmentEndDate = table.Column<DateTime>(nullable: false),
                    AffidavitOfGoodMoralCharacterStartDate = table.Column<DateTime>(nullable: false),
                    AffidavitOfGoodMoralCharacterEndDate = table.Column<DateTime>(nullable: false),
                    FDLEBGSStartDate = table.Column<DateTime>(nullable: false),
                    FDLEBGSEndDate = table.Column<DateTime>(nullable: false),
                    JSOLocalBGSStartDate = table.Column<DateTime>(nullable: false),
                    JSOLocalBGSEndDate = table.Column<DateTime>(nullable: false),
                    DEAStartDate = table.Column<DateTime>(nullable: false),
                    DEAEndDate = table.Column<DateTime>(nullable: false),
                    ARNPLicenceStartDate = table.Column<DateTime>(nullable: false),
                    ARNPLicenceEndDate = table.Column<DateTime>(nullable: false),
                    InsuranceStartDate = table.Column<DateTime>(nullable: false),
                    InsuranceEndDate = table.Column<DateTime>(nullable: false),
                    ClinicalCompetenceStartDate = table.Column<DateTime>(nullable: false),
                    ClinicalCompetenceEndDate = table.Column<DateTime>(nullable: false),
                    ClientPersonalSafetyStartDate = table.Column<DateTime>(nullable: false),
                    ClientPersonalSafetyEndDate = table.Column<DateTime>(nullable: false),
                    PatientConfidentialityStartDate = table.Column<DateTime>(nullable: false),
                    PatientConfidentialityEndDate = table.Column<DateTime>(nullable: false),
                    EthicalProfessionalStartDate = table.Column<DateTime>(nullable: false),
                    EthicalProfessionalEndDate = table.Column<DateTime>(nullable: false),
                    ElectivesStartDate = table.Column<DateTime>(nullable: false),
                    ElectivesEndDate = table.Column<DateTime>(nullable: false),
                    ZeroToleranceStartDate = table.Column<DateTime>(nullable: false),
                    ZeroToleranceEndDate = table.Column<DateTime>(nullable: false),
                    DCCCStartDate = table.Column<DateTime>(nullable: false),
                    DCCCEndDate = table.Column<DateTime>(nullable: false),
                    FirstAidStartDate = table.Column<DateTime>(nullable: false),
                    FirstAidEndDate = table.Column<DateTime>(nullable: false),
                    APDHIPAAStartDate = table.Column<DateTime>(nullable: false),
                    APDHIPAAEndDate = table.Column<DateTime>(nullable: false),
                    CPRStartDate = table.Column<DateTime>(nullable: false),
                    CPREndDate = table.Column<DateTime>(nullable: false),
                    HIVAIDSStartDate = table.Column<DateTime>(nullable: false),
                    HIVAIDSEndDate = table.Column<DateTime>(nullable: false),
                    SocialSecurityStartDate = table.Column<DateTime>(nullable: false),
                    SocialSecurityEndDate = table.Column<DateTime>(nullable: false),
                    InServiceTrainingStartDate = table.Column<DateTime>(nullable: false),
                    InServiceTrainingEndDate = table.Column<DateTime>(nullable: false),
                    InServiceTrainingHours = table.Column<int>(nullable: false),
                    RelatedToEmploymentStartDate = table.Column<DateTime>(nullable: false),
                    RelatedToEmploymentEndDate = table.Column<DateTime>(nullable: false),
                    RelatedToEmploymentHours = table.Column<int>(nullable: false),
                    MedicationAdministrationStartDate = table.Column<DateTime>(nullable: false),
                    MedicationAdministrationEndDate = table.Column<DateTime>(nullable: false),
                    ReactiveStrategiesStartDate = table.Column<DateTime>(nullable: false),
                    ReactiveStrategiesEndDate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
