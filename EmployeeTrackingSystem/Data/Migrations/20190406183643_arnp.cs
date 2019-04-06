using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTrackingSystem.Data.Migrations
{
    public partial class arnp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ANRPStartDate",
                table: "Employee",
                newName: "SSWIStartDate");

            migrationBuilder.RenameColumn(
                name: "ANRPEndDate",
                table: "Employee",
                newName: "SSWIEndDate");

            migrationBuilder.AddColumn<bool>(
                name: "ARNP",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ARNPLicenceEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ARNPLicenceStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DEAEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DEAStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsuranceEndDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "InsuranceStartDate",
                table: "Employee",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ARNP",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ARNPLicenceEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ARNPLicenceStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DEAEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DEAStartDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "InsuranceEndDate",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "InsuranceStartDate",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "SSWIStartDate",
                table: "Employee",
                newName: "ANRPStartDate");

            migrationBuilder.RenameColumn(
                name: "SSWIEndDate",
                table: "Employee",
                newName: "ANRPEndDate");
        }
    }
}
