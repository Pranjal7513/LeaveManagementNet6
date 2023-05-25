using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class testallocationleave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802f9f7",
                column: "ConcurrencyStamp",
                value: "2afa66dd-cae9-4613-9c98-407c4875d7e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cnn405b1-0155-46ff-ad24-d4e45802a8f2",
                column: "ConcurrencyStamp",
                value: "69ac2ee7-aa41-4609-9219-bff68cc2a5d8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18906a8b-41f2-43fc-beed-51aa12a61771",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2c0f1de-afe6-45ad-a946-7ca5cb681476", "AQAAAAEAACcQAAAAEAMK/WZiMKCer6tTEuNHHPsUgAx0S3oGWDy+IRDIWn1YBamNz58BYJYkKKn74Ec45w==", "6402f00d-7122-41f7-81ad-12991ed96437" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd405b1-0155-46ff-ad24-d4e45802b9c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a9e9a1e-38a3-45c6-92f2-30c52d9a67c4", "AQAAAAEAACcQAAAAEDRz50//T+8n/u1NBqAcOyGyORVtWnsDELDM0+v64XGTOnBhOpUwNn/tFjGnglQ4Zg==", "6027b3aa-db71-453e-9d5f-5e575da8e5e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
