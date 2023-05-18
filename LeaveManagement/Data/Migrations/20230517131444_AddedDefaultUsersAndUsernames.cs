using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802f9f7",
                column: "ConcurrencyStamp",
                value: "ac6fe19a-697c-4f5f-bc37-ccbfc6277fc4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cnn405b1-0155-46ff-ad24-d4e45802a8f2",
                column: "ConcurrencyStamp",
                value: "4d2f37d7-dc26-49e2-9fa6-5d6b72e08f19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18906a8b-41f2-43fc-beed-51aa12a61771",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "86441ff9-8e0f-482b-a369-a493c6f9802b", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJ++FOUJseuhValCen8OHWcOgXqRccAdwAgybJNpIqpc/tkSFwjx+agKNr6XShyiQw==", "a729fbf2-dfa8-4488-be89-cdb386422545", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802b9c7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f82e8e26-8f1e-447f-9584-9815500394e1", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEAznaC1w0/9vwBiYZ5XP2g5lDlP7wTJWz15HycLkKBBlmYcb74LGMjVlqbfTx/nPew==", "a6b6e10a-21ce-4407-8098-fef7b6a3af8c", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802f9f7",
                column: "ConcurrencyStamp",
                value: "620c6a3a-024f-43db-b405-6a5326c8468a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cnn405b1-0155-46ff-ad24-d4e45802a8f2",
                column: "ConcurrencyStamp",
                value: "cb98f90b-a9c2-4c21-9146-72e9eefa624f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18906a8b-41f2-43fc-beed-51aa12a61771",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d0a3f0f0-9efb-44be-a6d4-c0d950b54432", false, null, "AQAAAAEAACcQAAAAEEBqeNfcHcua3PJgwcpYjlssOhMHcepEj0t1KYcK0wr7I5S0YjmwEc6Pm0fXKyErcg==", "8a1dad5a-b1f7-4307-bfb8-556b6225b9b3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802b9c7",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "086e6166-8523-4aa4-b6e6-79182480b414", false, null, "AQAAAAEAACcQAAAAEF6kcFvLs+YQL+EYhDzv3e4solnM+AnnmekDbbrZl1lGknx37Q4Y12U6QIjo5x2/+A==", "430b8a97-a3ca-4bb5-87ed-371db82d4d2b", null });
        }
    }
}
