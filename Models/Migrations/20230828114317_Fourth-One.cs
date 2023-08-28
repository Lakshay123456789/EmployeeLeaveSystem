using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class FourthOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "8bd00b12-264c-4327-ac34-ba305f41c376");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F5ADAFD5-A464-485E-A924-AAFE642619FE",
                column: "ConcurrencyStamp",
                value: "c8d30af5-d038-4ed4-b720-c6df43658d74");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43235baf-27d4-4deb-88c6-b2edd0efaaa8", "AQAAAAEAACcQAAAAEO67F8Y64DBdYSpJnPVdo/vdc/Egneqk6L4SvlYUjI2ZHojNc1PrFobM6El2ZGzxHQ==", "b16f555e-5d89-4b25-a3d2-43981e101d5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4623A85-4A75-4020-BD41-D22B366F8ED7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05d3953a-cc20-405e-b0fb-1862b383e3e8", "AQAAAAEAACcQAAAAEFPVTn23fpjXfHFUAdc9VpjhqqNkY1lDTJN4OXnmsGsIELCluvZTnuIJKbNYWG4rhw==", "5b5f4653-4ae0-435d-9c07-6e2460ed0af0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "f36a6f9a-8022-4056-abce-8a2aee50975c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F5ADAFD5-A464-485E-A924-AAFE642619FE",
                column: "ConcurrencyStamp",
                value: "5b38abf1-e5fb-4df9-b255-45b0e653ede9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23d601f6-f326-4c93-89af-5ab4e2dcd6a4", "AQAAAAEAACcQAAAAEGT2WpcCuHJPmNEAfyxcSsjlsNPWox8Sf7XBJqvw5pAOp7f/8MEh2GdoNfcbjxJUDg==", "44157526-1194-4805-9814-2ffde9c3aa3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4623A85-4A75-4020-BD41-D22B366F8ED7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04434de8-3473-452d-9b3e-97718e26eee8", "AQAAAAEAACcQAAAAEIMZPJlsbKVAgVeF/Ex0C89PJsx97CQ52ctwLx/aCDEs6WgERxiIcSCxyk4nnE3zlQ==", "0025ab67-f011-4d41-98a6-9eca77ba044d" });
        }
    }
}
