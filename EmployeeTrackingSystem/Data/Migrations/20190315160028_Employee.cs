using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTrackingSystem.Data.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequiredCerts",
                table: "Employee",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Cert3StartDate",
                table: "Employee",
                newName: "YearlyEvaluationStartDate");

            migrationBuilder.RenameColumn(
                name: "Cert3EndDate",
                table: "Employee",
                newName: "YearlyEvaluationEndDate");

            migrationBuilder.RenameColumn(
                name: "Cert2StartDate",
                table: "Employee",
                newName: "VehicleRegistrationStartDate");

            migrationBuilder.RenameColumn(
                name: "Cert2EndDate",
                table: "Employee",
                newName: "VehicleRegistrationEndDate");

            migrationBuilder.RenameColumn(
                name: "Cert1StartDate",
                table: "Employee",
                newName: "VehicleInsuranceCardStartDate");

            migrationBuilder.RenameColumn(
                name: "Cert1EndDate",
                table: "Employee",
                newName: "VehicleInsuranceCardEndDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "AffidavitOfGoodMoralCharacterEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AffidavitOfGoodMoralCharacterStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DCFHippaEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DCFHippastartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FDLEBGSEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FDLEBGSStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "JSOLocalBGSEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "JSOLocalBGSStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetCaseManagmentEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetCaseManagmentStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AffidavitOfGoodMoralCharacterEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "AffidavitOfGoodMoralCharacterStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DCFHippaEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DCFHippastartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FDLEBGSEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "FDLEBGSStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JSOLocalBGSEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "JSOLocalBGSStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TargetCaseManagmentEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "TargetCaseManagmentStartDate",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "YearlyEvaluationStartDate",
                table: "Employee",
                newName: "Cert3StartDate");

            migrationBuilder.RenameColumn(
                name: "YearlyEvaluationEndDate",
                table: "Employee",
                newName: "Cert3EndDate");

            migrationBuilder.RenameColumn(
                name: "VehicleRegistrationStartDate",
                table: "Employee",
                newName: "Cert2StartDate");

            migrationBuilder.RenameColumn(
                name: "VehicleRegistrationEndDate",
                table: "Employee",
                newName: "Cert2EndDate");

            migrationBuilder.RenameColumn(
                name: "VehicleInsuranceCardStartDate",
                table: "Employee",
                newName: "Cert1StartDate");

            migrationBuilder.RenameColumn(
                name: "VehicleInsuranceCardEndDate",
                table: "Employee",
                newName: "Cert1EndDate");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Employee",
                newName: "RequiredCerts");
        }
    }
}
