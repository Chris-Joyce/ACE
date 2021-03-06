﻿// <auto-generated />
using System;
using EmployeeTrackingSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeTrackingSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeTrackingSystem.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("APDHIPAAEndDate");

                    b.Property<DateTime>("APDHIPAAStartDate");

                    b.Property<bool>("APDSupportedEmployement");

                    b.Property<bool>("APDSupportedLiving");

                    b.Property<bool>("ARNP");

                    b.Property<DateTime>("ARNPLicenceEndDate");

                    b.Property<DateTime>("ARNPLicenceStartDate");

                    b.Property<string>("Address");

                    b.Property<DateTime>("AffidavitOfGoodMoralCharacterEndDate");

                    b.Property<DateTime>("AffidavitOfGoodMoralCharacterStartDate");

                    b.Property<bool>("CBHT");

                    b.Property<DateTime>("CPREndDate");

                    b.Property<DateTime>("CPRStartDate");

                    b.Property<string>("City");

                    b.Property<DateTime>("ClientPersonalSafetyEndDate");

                    b.Property<DateTime>("ClientPersonalSafetyStartDate");

                    b.Property<DateTime>("ClinicalCompetenceEndDate");

                    b.Property<DateTime>("ClinicalCompetenceStartDate");

                    b.Property<DateTime>("DCCCEndDate");

                    b.Property<DateTime>("DCCCStartDate");

                    b.Property<DateTime>("DCFHippaEndDate");

                    b.Property<DateTime>("DCFHippastartDate");

                    b.Property<DateTime>("DEAEndDate");

                    b.Property<DateTime>("DEAStartDate");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<DateTime>("ElectivesEndDate");

                    b.Property<DateTime>("ElectivesStartDate");

                    b.Property<string>("Email");

                    b.Property<DateTime>("EthicalProfessionalEndDate");

                    b.Property<DateTime>("EthicalProfessionalStartDate");

                    b.Property<DateTime>("FDLEBGSEndDate");

                    b.Property<DateTime>("FDLEBGSStartDate");

                    b.Property<DateTime>("FirstAidEndDate");

                    b.Property<DateTime>("FirstAidStartDate");

                    b.Property<DateTime>("HIVAIDSEndDate");

                    b.Property<DateTime>("HIVAIDSStartDate");

                    b.Property<DateTime>("HireDate");

                    b.Property<DateTime>("InServiceTrainingEndDate");

                    b.Property<int>("InServiceTrainingHours");

                    b.Property<DateTime>("InServiceTrainingStartDate");

                    b.Property<DateTime>("InsuranceEndDate");

                    b.Property<DateTime>("InsuranceStartDate");

                    b.Property<DateTime>("JSOLocalBGSEndDate");

                    b.Property<DateTime>("JSOLocalBGSStartDate");

                    b.Property<string>("LicenseNumber");

                    b.Property<DateTime>("MedicationAdministrationEndDate");

                    b.Property<DateTime>("MedicationAdministrationStartDate");

                    b.Property<string>("Name");

                    b.Property<string>("Notes");

                    b.Property<DateTime>("PatientConfidentialityEndDate");

                    b.Property<DateTime>("PatientConfidentialityStartDate");

                    b.Property<string>("Phone");

                    b.Property<DateTime>("ReactiveStrategiesEndDate");

                    b.Property<DateTime>("ReactiveStrategiesStartDate");

                    b.Property<DateTime>("RelatedToEmploymentEndDate");

                    b.Property<int>("RelatedToEmploymentHours");

                    b.Property<DateTime>("RelatedToEmploymentStartDate");

                    b.Property<DateTime>("SocialSecurityEndDate");

                    b.Property<DateTime>("SocialSecurityStartDate");

                    b.Property<string>("State");

                    b.Property<DateTime>("TargetCaseManagmentEndDate");

                    b.Property<DateTime>("TargetCaseManagmentStartDate");

                    b.Property<string>("Title");

                    b.Property<DateTime>("VehicleInsuranceCardEndDate");

                    b.Property<DateTime>("VehicleInsuranceCardStartDate");

                    b.Property<DateTime>("VehicleRegistrationEndDate");

                    b.Property<DateTime>("VehicleRegistrationStartDate");

                    b.Property<DateTime>("YearlyEvaluationEndDate");

                    b.Property<DateTime>("YearlyEvaluationStartDate");

                    b.Property<DateTime>("ZeroToleranceEndDate");

                    b.Property<DateTime>("ZeroToleranceStartDate");

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
