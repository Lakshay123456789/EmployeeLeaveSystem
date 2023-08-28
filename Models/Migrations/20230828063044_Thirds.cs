using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class Thirds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[] { 1, "IT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "48fb6982-fc5a-4240-bab3-4e09af454c2c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F5ADAFD5-A464-485E-A924-AAFE642619FE",
                column: "ConcurrencyStamp",
                value: "9a958a76-4497-4792-9fa1-7a2fcdfee000");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7ae19bb-0c96-49c2-92e4-42b00d6a1169", "AQAAAAEAACcQAAAAEExvdaXA3Pn1oraGS3Y9rwRLpkPoftIPLXOSM+N3+OyjBJnxPpnEIu82aL5V1Bt3sg==", "5f7cf833-dd35-45c4-9f5b-0c6aee39b032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4623A85-4A75-4020-BD41-D22B366F8ED7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5dfea61-27f7-4297-bde9-d75830a921d1", "AQAAAAEAACcQAAAAEB+wMuJZ8rWC6AkZzGf8GG7UgDYmy9s6TuLBn6xKfLahO9tl4D4SOmY2v7Z0xqfyww==", "f45a7ec1-377a-4dca-93f9-5e2e3451083f" });
        }
    }
}
