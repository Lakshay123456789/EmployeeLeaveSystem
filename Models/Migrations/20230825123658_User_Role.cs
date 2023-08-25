using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Models.Migrations
{
    public partial class User_Role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", "48fb6982-fc5a-4240-bab3-4e09af454c2c", "Admin", "ADMIN" },
                    { "F5ADAFD5-A464-485E-A924-AAFE642619FE", "9a958a76-4497-4792-9fa1-7a2fcdfee000", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "f7ae19bb-0c96-49c2-92e4-42b00d6a1169", "Admin123@gmail.com", false, "ADMIN", null, false, null, "ADMIN123@GMAIL.COM", "ADMIN123@GMAIL.COM", "AQAAAAEAACcQAAAAEExvdaXA3Pn1oraGS3Y9rwRLpkPoftIPLXOSM+N3+OyjBJnxPpnEIu82aL5V1Bt3sg==", null, false, "5f7cf833-dd35-45c4-9f5b-0c6aee39b032", false, "Admin123@gmail.com" },
                    { "C4623A85-4A75-4020-BD41-D22B366F8ED7", 0, "e5dfea61-27f7-4297-bde9-d75830a921d1", "User123@gmail.com", false, "USER", null, false, null, "USER123@GMAIL.COM", "USER123@GMAIL.COM", "AQAAAAEAACcQAAAAEB+wMuJZ8rWC6AkZzGf8GG7UgDYmy9s6TuLBn6xKfLahO9tl4D4SOmY2v7Z0xqfyww==", null, false, "f45a7ec1-377a-4dca-93f9-5e2e3451083f", false, "User123@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "F5ADAFD5-A464-485E-A924-AAFE642619FE", "C4623A85-4A75-4020-BD41-D22B366F8ED7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7210", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "F5ADAFD5-A464-485E-A924-AAFE642619FE", "C4623A85-4A75-4020-BD41-D22B366F8ED7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "F5ADAFD5-A464-485E-A924-AAFE642619FE");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4623A85-4A75-4020-BD41-D22B366F8ED7");
        }
    }
}
