using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class SixthOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "0980e797-cfb6-4ffc-98f6-dbdcb0ae87b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F5ADAFD5-A464-485E-A924-AAFE642619FE",
                column: "ConcurrencyStamp",
                value: "76f16596-3423-46a5-abbc-e3c90d98d812");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50fcddb4-65a6-4c61-af2c-77e557b818a6", "AQAAAAEAACcQAAAAEKuGvuxYyRZOmlbs8UQdloypnmt3CdYU42jT0oCGUIeh0yAnZ0yWm0pW6cjgTXcFAA==", "012baeaf-0edf-4c71-8a3d-254ea4766d6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4623A85-4A75-4020-BD41-D22B366F8ED7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84c12437-90f5-44a0-943a-c3b85d2dd167", "AQAAAAEAACcQAAAAEM7by+GpuaF9JWuPPUa0ubqIdsKKKBNKlmn9jkS1WWmCMnw/o8dflpikv/lnGYensw==", "6066cc9d-6960-493e-881b-5725086e1666" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 31, 12, 12, 25, 383, DateTimeKind.Local).AddTicks(1253));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Departments");

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
    }
}
