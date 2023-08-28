using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class ThirdOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Employees",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "bd5c0b2e-a05b-4dec-bf6c-0baeb5a5bf07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F5ADAFD5-A464-485E-A924-AAFE642619FE",
                column: "ConcurrencyStamp",
                value: "90feb4e7-7832-4329-a022-afe11176eb1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "206b299a-5cfe-4357-9e0a-8c60b05acf75", "AQAAAAEAACcQAAAAEDv6XVwaB8zIxIq4hiT3ATf3DwA/XiQarzwEyXy7pZAMCFRJHHGaB+o1GNFmiAx2+w==", "0f746329-320e-4f27-bc3b-b8de7e4d42b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4623A85-4A75-4020-BD41-D22B366F8ED7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5cae0a5-a0c3-49dd-a994-a598bd67818d", "AQAAAAEAACcQAAAAEEEn5kD1raPhkSSUMDaCd7f7tX59iS5pAPgqwXr/79Qa4AXWx9u1t3sXc2gE7JXPUw==", "a3870c6e-f998-4632-b361-b06c83ff7293" });
        }
    }
}
