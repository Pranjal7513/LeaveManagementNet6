using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class testallocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802f9f7",
                column: "ConcurrencyStamp",
                value: "bbac7e4c-a405-4230-bd2a-6fbbd5d3ec1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cnn405b1-0155-46ff-ad24-d4e45802a8f2",
                column: "ConcurrencyStamp",
                value: "fa32ac99-665c-4002-a591-ca0866734620");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18906a8b-41f2-43fc-beed-51aa12a61771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a627da8-2049-44d8-8a76-376b52f8c5bd", "AQAAAAEAACcQAAAAEBt7GR2c3Eg+XCwNfiYLG3QwWWwiKGpPqSzqZf3ps+O3bTzwk30ZOOe7o/0zLRrLYw==", "4dc6223a-f300-4f34-b251-9617ea1b6c50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802b9c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88bda233-fd8d-4957-b11d-d617f6c4f44a", "AQAAAAEAACcQAAAAEN2vyeGc23hb9cVm09KN2nd73SFD2boSmcZoSwrCtgeYr2lUhRkIjn4Dl8gPpGJOxw==", "7e4a55e1-bb41-4bf8-9e89-edf899c91f8c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
