using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTrackingSystem.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "APDHIPAAEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "APDHIPAAStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CPREndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CPRStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DCCCEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DCCCStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstAidEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FirstAidStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HIVAIDSEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HIVAIDSStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InServiceTrainingEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InServiceTrainingStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MedicationAdministrationEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "MedicationAdministrationStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReactiveStrategiesEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReactiveStrategiesStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RelatedToEmploymentEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RelatedToEmploymentStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SocialSecurityEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "SocialSecurityStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ZeroToleranceEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ZeroToleranceStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "APDHIPAAEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "APDHIPAAStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CPREndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CPRStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DCCCEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DCCCStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FirstAidEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FirstAidStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HIVAIDSEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "HIVAIDSStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "InServiceTrainingEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "InServiceTrainingStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MedicationAdministrationEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MedicationAdministrationStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ReactiveStrategiesEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ReactiveStrategiesStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RelatedToEmploymentEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "RelatedToEmploymentStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SocialSecurityEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "SocialSecurityStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ZeroToleranceEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ZeroToleranceStartDate",
                table: "Employee");
        }
    }
}
