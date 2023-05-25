using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddeingPeriodToAllocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802f9f7",
                column: "ConcurrencyStamp",
                value: "c41a8932-cf02-462e-a96e-f4f34c51ce36");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cnn405b1-0155-46ff-ad24-d4e45802a8f2",
                column: "ConcurrencyStamp",
                value: "ae53c987-3552-42d5-af8c-77380c23462b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18906a8b-41f2-43fc-beed-51aa12a61771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "986888c1-2475-42cb-94dd-45034fceda6d", "AQAAAAEAACcQAAAAEPJyBrEE9JWPs/RtaF0SPkeJwncA2V1vo6VWoukxLS95cYEvwQ7vRSAUN9P94Awfxg==", "6019a150-4a69-4457-a532-e035d9ff1c61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802b9c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6537e8f5-7c39-4c26-b95a-335937d8ef04", "AQAAAAEAACcQAAAAEORCkk5tNAiGnAakcdfdeUmTNHY3bKUyUk+08PkhUU+ctWlSLFVHbTWeCWShxeKP6A==", "f3432bfa-780e-473c-95eb-857259fa1b40" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86441ff9-8e0f-482b-a369-a493c6f9802b", "AQAAAAEAACcQAAAAEJ++FOUJseuhValCen8OHWcOgXqRccAdwAgybJNpIqpc/tkSFwjx+agKNr6XShyiQw==", "a729fbf2-dfa8-4488-be89-cdb386422545" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802b9c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f82e8e26-8f1e-447f-9584-9815500394e1", "AQAAAAEAACcQAAAAEAznaC1w0/9vwBiYZ5XP2g5lDlP7wTJWz15HycLkKBBlmYcb74LGMjVlqbfTx/nPew==", "a6b6e10a-21ce-4407-8098-fef7b6a3af8c" });
        }
    }
}
