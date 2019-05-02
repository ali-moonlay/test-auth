using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Com.Danliris.Service.Auth.Lib.Migrations
{
    public partial class AddNewPropertyInAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "AccountProfiles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AccountProfiles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dob",
                table: "AccountProfiles");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AccountProfiles");
        }
    }
}
