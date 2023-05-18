using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cdd405b1-0155-46ff-ad24-d4e45802f9f7", "620c6a3a-024f-43db-b405-6a5326c8468a", "Administrator", "ADMINISTRATOR" },
                    { "cnn405b1-0155-46ff-ad24-d4e45802a8f2", "cb98f90b-a9c2-4c21-9146-72e9eefa624f", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateofBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "18906a8b-41f2-43fc-beed-51aa12a61771", 0, "d0a3f0f0-9efb-44be-a6d4-c0d950b54432", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEEBqeNfcHcua3PJgwcpYjlssOhMHcepEj0t1KYcK0wr7I5S0YjmwEc6Pm0fXKyErcg==", null, false, "8a1dad5a-b1f7-4307-bfb8-556b6225b9b3", null, false, null },
                    { "cdd405b1-0155-46ff-ad24-d4e45802b9c7", 0, "086e6166-8523-4aa4-b6e6-79182480b414", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEF6kcFvLs+YQL+EYhDzv3e4solnM+AnnmekDbbrZl1lGknx37Q4Y12U6QIjo5x2/+A==", null, false, "430b8a97-a3ca-4bb5-87ed-371db82d4d2b", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cdd405b1-0155-46ff-ad24-d4e45802f9f7", "18906a8b-41f2-43fc-beed-51aa12a61771" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cnn405b1-0155-46ff-ad24-d4e45802a8f2", "cdd405b1-0155-46ff-ad24-d4e45802b9c7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cdd405b1-0155-46ff-ad24-d4e45802f9f7", "18906a8b-41f2-43fc-beed-51aa12a61771" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cnn405b1-0155-46ff-ad24-d4e45802a8f2", "cdd405b1-0155-46ff-ad24-d4e45802b9c7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802f9f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cnn405b1-0155-46ff-ad24-d4e45802a8f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18906a8b-41f2-43fc-beed-51aa12a61771");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802b9c7");
        }
    }
}
