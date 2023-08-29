using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class FivthOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancel",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "7bc5b848-0b0f-424e-ab81-0873a3ddfc66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F5ADAFD5-A464-485E-A924-AAFE642619FE",
                column: "ConcurrencyStamp",
                value: "7c841432-1137-40bb-8daf-84a3df4eebf2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "022013b5-6668-47dd-8839-2a1402be92a4", "AQAAAAEAACcQAAAAEDo2yCGVsPOkZopPGJaj5Q6RPqZQQ1ex8HGjswdCS9K2KR6pczYrewCwPYba5STmnQ==", "e26fe0e6-1bc0-4e82-90d9-bfbd7f7e8e94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4623A85-4A75-4020-BD41-D22B366F8ED7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "774d06e3-42e9-4c2e-afd0-1557cbf69aa7", "AQAAAAEAACcQAAAAEOLld9hYkZ/h0ftDofqM2q6++x94S58bbr51pLMaJ92tbQfxspTODK+chg0bNNMchg==", "e19b7e44-ac6e-4730-a634-6397e7302cf7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancel",
                table: "LeaveRequests");

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
    }
}
